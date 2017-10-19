﻿/*************************************************************  
 *          Project: NetCoreCMS                              *
 *           Author: OnnoRokom Software Ltd.                 *
 *          Website: www.onnorokomsoftware.com               *
 *            Email: info@onnorokomsoftware.com              *
 *        Copyright: OnnoRokom Software Ltd.                 *
 *           Mobile: +88 017 08 166 003                      *
 *          License: BSD-3-Clause                            *
 *************************************************************/

using NetCoreCMS.Framework.Core.Mvc.Repository;
using NetCoreCMS.HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Text;
using NetCoreCMS.Framework.Core.Data;
using NetCoreCMS.Framework.Core.IoC;

namespace NetCoreCMS.HelloWorld.Repository
{
    public class HelloRepository : BaseRepository<HelloModel, long>, ISingleton
    {
        public HelloRepository(NccDbContext context) : base(context)
        {
        }
    }
}
