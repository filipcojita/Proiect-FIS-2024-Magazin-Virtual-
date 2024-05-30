using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_FIS
{
    public class Product
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public decimal Pret { get; set; }
        public string Vanzator { get; set; }
        public string Descriere { get; set; }
        public bool Negociabil { get; set; }
        public decimal? PretMinim { get; set; }

        public override string ToString()
        {
            if (Negociabil)
            {
                return $"{Id},{Nume},{Pret},{Vanzator},{Descriere},{Negociabil},{PretMinim}";
            }
            else
            {
                return $"{Id},{Nume},{Pret},{Vanzator},{Descriere},{Negociabil}";
            }
        }
    }


}
