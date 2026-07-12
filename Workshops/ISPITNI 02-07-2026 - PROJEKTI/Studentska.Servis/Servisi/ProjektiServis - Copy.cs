using Microsoft.EntityFrameworkCore;
using Studentska.Data.Entiteti;
using Studentska.Data.IspitIB180079;

namespace Studentska.Servis.Servisi
{
    public class StudentiProjektiServis : BaseServis<StudentiProjektiIB180079>
    {

        public List<StudentiProjektiIB180079> GetAllIncluded()
        {
            return _dbContext.Set<StudentiProjektiIB180079>()
                .Include(x => x.Student)
                .Include(x => x.Projekat)
                .ToList();
        }

    }
}
