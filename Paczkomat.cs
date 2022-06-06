using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egzamin
{
    class Paczkomat
    {
        private int Numer { get; set; }
        private string Adres { get; set; }

        public Paczkomat(int nr, string adres)
        {
            Numer = nr;
            Adres = adres;
        }
    }
}
