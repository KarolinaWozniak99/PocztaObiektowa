using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egzamin
{
    abstract class Przesylka
    {
        protected abstract Nadawca nadawca { get;  }
        protected abstract Odbiorca odbiorca { get; }
        protected abstract int Wysokosc { get; }
        protected abstract int Szerokosc { get;  }
        protected abstract int Dlugosc { get; }
        protected abstract int Waga { get; }
        protected abstract int Nr { get; }
        protected abstract  DateTime DataNadania { get; }

        

        public abstract double ObliczKoszt();
        public abstract ListPrzewozowy GenerujListPrzwozowy();
        

        
    }
}
