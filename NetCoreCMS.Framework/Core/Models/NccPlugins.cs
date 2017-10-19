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
using NetCoreCMS.Framework.Core.Mvc.Models;

namespace NetCoreCMS.Framework.Core.Models
{
    public class NccPlugins : BaseModel, IBaseModel<long>
    { 
        public NccPlugins()
        {
            Widgets = new List<NccWidget>();
        }

        public bool AntiForgery { get; set; }
        public string Author { get; set; }
        public string Website { get; set; }
        public string Version { get; set; }
        public string NetCoreCMSVersion { get; set; }
        public string Description { get; set; }
        public string Dependencies { get; set; }
        public string Category { get; set; }
        public string SortName { get; set; }
        public string Path { get; set; }

        public NccPluginsStatus PluginsStatus { get; set; }
        public List<NccWidget> Widgets { get; set; }

        public enum NccPluginsStatus
        {
            Listed,
            Installed,
            Active,
            Inactive,
            Uninstalled
        }
    }
}
