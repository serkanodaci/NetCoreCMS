﻿/*************************************************************  
 *          Project: NetCoreCMS                              *
 *           Author: OnnoRokom Software Ltd.                 *
 *          Website: www.onnorokomsoftware.com               *
 *            Email: info@onnorokomsoftware.com              *
 *        Copyright: OnnoRokom Software Ltd.                 *
 *           Mobile: +88 017 08 166 003                      *
 *          License: BSD-3-Clause                            *
 *************************************************************/

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreCMS.Framework.Core.Mvc.Models
{
    public abstract class ValidateableModel
    {
        public virtual bool IsValid()
        {
            return this.ValidationResults().Count == 0;
        }

        public virtual IList<ValidationResult> ValidationResults()
        {
            IList<ValidationResult> validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(this, new ValidationContext(this, null, null), validationResults, true);
            return validationResults;
        }
    }
}
