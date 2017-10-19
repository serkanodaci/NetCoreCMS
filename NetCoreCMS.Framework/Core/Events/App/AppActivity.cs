﻿/*************************************************************  
 *          Project: NetCoreCMS                              *
 *           Author: OnnoRokom Software Ltd.                 *
 *          Website: www.onnorokomsoftware.com               *
 *            Email: info@onnorokomsoftware.com              *
 *        Copyright: OnnoRokom Software Ltd.                 *
 *           Mobile: +88 017 08 166 003                      *
 *          License: BSD-3-Clause                            *
 *************************************************************/
 
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace NetCoreCMS.Framework.Core.Events.App
{
    public class AppActivity
    {
        public HttpContext Context { get; set; }
        public IServiceCollection Services { get; set; }
        public Type ActivityType { get; set; }

        public enum Type
        {
            BeforeStart,
            Started,
            SessionStart,
            SessionEnd,
            RequestStart,
            RequestEnd,
            BeforeRestart
        }
    }
}
