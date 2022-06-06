using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egzamin
{
    class Odbiorca
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Miasto { get; set; }
        public string KodPocztowy { get; set; }
        public string Ulica { get; set; }
        public string NrTel { get; set; }
        public string Mail { get; set; }

        public Odbiorca(string imie, string nazwisko, string miasto, string kod, string ul, string nrtel, string mail=null)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Miasto = miasto;
            KodPocztowy = kod;
            Ulica = ul;
            NrTel = nrtel;
            Mail = mail;
        }
    }
}
