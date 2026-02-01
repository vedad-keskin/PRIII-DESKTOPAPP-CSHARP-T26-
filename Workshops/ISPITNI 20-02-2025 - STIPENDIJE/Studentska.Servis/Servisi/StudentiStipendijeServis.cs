using DLWMS.Data.IspitIB180079;
using Microsoft.EntityFrameworkCore;
using Studentska.Data.IspitIB180079;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Servis.Servisi
{
    public class StudentiStipendijeServis : BaseServis<StudentiStipendijeIB180079>
    {

        public List<StudentiStipendijeIB180079> GetAllIncluded()
        {
            return _dbContext.Set<StudentiStipendijeIB180079>()
                .Include(x => x.Student)
                .Include(x => x.StipendijaGodina.Stipendija)
                .ToList();
        }



        //public List<StudentiStipendijeIB180079> GetAllIncludedWithFilter(int stipendijeGodinaId = 0)
        //{
        //    return _dbContext.Set<StudentiStipendijeIB180079>()
        //        .Include(x => x.StipendijaGodina.Stipendija)
        //        .Include(x => x.Student)
        //        .Where(x => x.StipendijaGodinaId == stipendijeGodinaId)
        //        .ToList();
        //}

    }
}
