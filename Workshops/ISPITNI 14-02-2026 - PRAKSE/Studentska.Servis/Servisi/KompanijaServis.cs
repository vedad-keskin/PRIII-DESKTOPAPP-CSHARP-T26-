using Microsoft.EntityFrameworkCore;
using Studentska.Data.IspitIB180079;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Servis.Servisi
{
    public class KompanijaServis : BaseServis<KompanijeIB180079>
    {
        public List<KompanijeIB180079> GetAllIncluded()
        {
            return _dbContext.Set<KompanijeIB180079>()
                .Include(x => x.Grad)
                .ToList();
        }
    }
}
