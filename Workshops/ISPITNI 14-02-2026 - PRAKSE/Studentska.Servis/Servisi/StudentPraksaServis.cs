using Microsoft.EntityFrameworkCore;
using Studentska.Data.IspitIB180079;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Servis.Servisi
{
    public class StudentPraksaServis : BaseServis<StudentiPraksaIB180079>
    {
        public List<StudentiPraksaIB180079> GetAllIncluded()
        {
            return _dbContext.Set<StudentiPraksaIB180079>()
                .Include(x => x.Student)
                .Include(x => x.Kompanija.Grad)
                .ToList();
        }

    }
}
