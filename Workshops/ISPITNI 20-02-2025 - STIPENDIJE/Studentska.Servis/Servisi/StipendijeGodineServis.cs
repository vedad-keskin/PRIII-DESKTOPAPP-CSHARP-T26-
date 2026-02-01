using Microsoft.EntityFrameworkCore;
using Studentska.Data.IspitIB180079;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Servis.Servisi
{
    public class StipendijeGodineServis : BaseServis<StipendijeGodineIB180079>
    {
        public List<StipendijeGodineIB180079> GetAllIncludedWithFilter(string godina = "")
        {
            return _dbContext.Set<StipendijeGodineIB180079>()
                .Include(x => x.Stipendija)
                .Where(x => x.Godina == godina)
                .ToList();
        }



    }
}
