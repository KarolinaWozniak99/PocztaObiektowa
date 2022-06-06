using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egzamin
{
    static class Poczta
    {
        

        public static List<Para> CenaWagi = new List<Para>() { new Para(20000,10), new Para(30000,12), new Para(40000,18)};
        public static List<Czworka> CenaWymiar = new List<Czworka>() { new Czworka(50,100,150,13),new Czworka(100,150,200,16), new Czworka(150,200,300,20)};

        public static int id = 0;

        


    }
}
