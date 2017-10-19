﻿/*************************************************************  
 *          Project: NetCoreCMS                              *
 *           Author: OnnoRokom Software Ltd.                 *
 *          Website: www.onnorokomsoftware.com               *
 *            Email: info@onnorokomsoftware.com              *
 *        Copyright: OnnoRokom Software Ltd.                 *
 *           Mobile: +88 017 08 166 003                      *
 *          License: BSD-3-Clause                            *
 *************************************************************/

using NetCoreCMS.Framework.Core.Data;
using NetCoreCMS.Framework.Setup;
using System.ComponentModel.DataAnnotations;

namespace NetCoreCMS.Core.Modules.Setup.Models.ViewModels
{
    public class SetupViewModel : DatabaseInfo
    { 
        public DatabaseEngine Database { get; set; }
        
    }
}
