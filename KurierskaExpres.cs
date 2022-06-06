using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egzamin
{
    
    class KurierskaExpres:Przesylka
    {
        public KurierskaExpres(Nadawca n, Odbiorca o, int waga, int dlugosc, int szerokosc, int wysokosc, DateTime data)
        {
            nadawca = n;
            odbiorca = o;
            Waga = waga;
            Dlugosc = dlugosc;
            Szerokosc = szerokosc;
            Wysokosc = wysokosc;
            DataNadania = data;
            Nr = ++Poczta.id;
        }

        protected override DateTime DataNadania { get; }
        protected override int Waga { get;}
        protected override int Dlugosc { get; }
        protected override int Szerokosc { get; }
        protected override int Wysokosc { get; }
        protected override Nadawca nadawca { get; }
        protected override Odbiorca odbiorca { get; }
        protected override int Nr { get; }
        
        public override double ObliczKoszt()

        {

            int x = 0;
            int waga1 = Poczta.CenaWagi[0].waga;
            int waga2 = Poczta.CenaWagi[1].waga;
            int waga3 = Poczta.CenaWagi[2].waga;

            if (Waga <= waga1) x = waga1;
            else if (Waga > waga1 && Waga <= waga2) x = waga2;
            else if (Waga > waga2 && Waga <= waga3) x = waga3;

            double kosztPrzesylkiA = 0;

            for (int i = 0; i < Poczta.CenaWagi.Count; i++)
            {
                if (Poczta.CenaWagi[i].waga == x) kosztPrzesylkiA = Poczta.CenaWagi[i].koszt;
            }

            //liczę objętość każdego wymiaru paczki na podstawie wymiarów podnych w klasie Poczta, jeśli wartość nadawanej paczki jest mniejsza lub równa wymiarowi
            //przypisuję odpowiedni koszt.

            double kosztPrzesylkiB = 0;
            double y = 0;

            double objPaczki = Dlugosc * Szerokosc * Wysokosc;

            double obj1 = Poczta.CenaWymiar[0].x * Poczta.CenaWymiar[0].y * Poczta.CenaWymiar[0].z; //dla najmniejszych paczek
            double obj2 = Poczta.CenaWymiar[1].x * Poczta.CenaWymiar[1].y * Poczta.CenaWymiar[1].z; //dla średnich paczek
            double obj3 = Poczta.CenaWymiar[2].x * Poczta.CenaWymiar[2].y * Poczta.CenaWymiar[2].z; //dla największych paczek

            if (objPaczki <= obj1) y = obj1;
            else if (objPaczki > obj1 && objPaczki <= obj2) y = obj2;
            else if (objPaczki > obj2 && objPaczki <= obj3) y = obj3;

            for (int i = 0; i < Poczta.CenaWymiar.Count; i++)
            {
                if (Poczta.CenaWymiar[i].x * Poczta.CenaWymiar[i].y * Poczta.CenaWymiar[i].z == y) kosztPrzesylkiB = Poczta.CenaWymiar[i].cena;
            }

            //cena wysyłki to suma ceny wymiaru i ceny wagi
            return kosztPrzesylkiB + kosztPrzesylkiA;

        }

        public override ListPrzewozowy GenerujListPrzwozowy()
        {
            ListPrzewozowy list = new ListPrzewozowy(nadawca, odbiorca, DataNadania);
            return list;
        }
    }
    
}
