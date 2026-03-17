using Studentska.Data.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Data.IspitIB180079
{
    public class StudentiPraksaIB180079
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int KompanijaId { get; set; }
        public KompanijeIB180079 Kompanija { get; set; }
        public DateTime DatumPrijave { get; set; }
        public string Status { get; set; }
        public DateTime? DatumPromjene { get; set; }

        public string GradInfo => Kompanija?.Grad?.Naziv ?? "N/A";

    }
}
