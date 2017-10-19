/*************************************************************  
 *          Project: NetCoreCMS                              *
 *           Author: OnnoRokom Software Ltd.                 *
 *          Website: www.onnorokomsoftware.com               *
 *            Email: info@onnorokomsoftware.com              *
 *        Copyright: OnnoRokom Software Ltd.                 *
 *           Mobile: +88 017 08 166 003                      *
 *          License: BSD-3-Clause                            *
 *************************************************************/

using NetCoreCMS.Framework.Core.Data;
using NetCoreCMS.Framework.Core.Mvc.Repository;
using NetCoreCMS.Modules.News.Models;

namespace NetCoreCMS.Modules.News.Repository
{
    public class NeNewsRepository : BaseRepository<NeNews, long>
    {
        public NeNewsRepository(NccDbContext context) : base(context)
        {
        }
    }
}
