using Studentska.Data.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Data.IspitIB180079
{
    public class KompanijeIB180079
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int GradId { get; set; }
        public Grad Grad { get; set; }

        public string Adresa { get; set; }

        //[Url]
        public string Url { get; set; }
        public byte[] Logo { get; set; }
        public int Max { get; set; }
        public bool Aktivna { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
