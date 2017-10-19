/*************************************************************  
 *          Project: NetCoreCMS                              *
 *           Author: OnnoRokom Software Ltd.                 *
 *          Website: www.onnorokomsoftware.com               *
 *            Email: info@onnorokomsoftware.com              *
 *        Copyright: OnnoRokom Software Ltd.                 *
 *           Mobile: +88 017 08 166 003                      *
 *          License: BSD-3-Clause                            *
 *************************************************************/

using System;
using System.Collections.Generic;
using NetCoreCMS.Framework.Core.Data;
using NetCoreCMS.Framework.Core.Models;
using NetCoreCMS.Framework.Core.Mvc.Repository;
using System.Linq;

namespace NetCoreCMS.Framework.Core.Repository
{
    public class NccModuleRepository : BaseRepository<NccModule, long>
    {
        public NccModuleRepository(NccDbContext context) : base(context)
        {

        }

        internal List<NccModule> LoadByModuleStatus(NccModule.NccModuleStatus active)
        {
            return Query().Where(x => x.ModuleStatus == active).ToList();
        }
    }
}
