using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egzamin
{
    class ListPrzewozowy
    {
        public Nadawca nadawca { get; set; }
        public Odbiorca odbiorca { get; set; }
        public string adresDoreczenia { get; set; }
        
        public DateTime dataNadania { get; set; }

        public ListPrzewozowy(Nadawca n, Odbiorca o, DateTime data)
        {
            nadawca = n;
            odbiorca = o;
            adresDoreczenia = odbiorca.Miasto+" "+odbiorca.Ulica;
            dataNadania = data;
        }
    }
}
