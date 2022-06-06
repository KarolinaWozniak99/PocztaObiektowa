using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egzamin
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Nadawca conadaje = new Nadawca("Jan", "Kowalki", "Glwice", "44-121","Granitowa", "444333222", "ss@interia.pl");
            Odbiorca coodbiera = new Odbiorca("Anna", "jakas", "Gdynia", "44-999", "Januszowa", "222111222");
            Paczkomat paczkomat = new Paczkomat(22, "gdynia, ul jakas");
            Kurierska kurierska = new Kurierska(conadaje, coodbiera, 30, 11, 12,15, DateTime.Now);
            Paczkomatowa paczkomatowa = new Paczkomatowa(conadaje, coodbiera, 30, 11, 12, 15, DateTime.Now, paczkomat);
            KurierskaExpres kurierskaExpres = new KurierskaExpres(conadaje, coodbiera, 30, 11, 12, 15, DateTime.Now);


            void pokaz(Przesylka paczka)
            {
                Console.WriteLine($"NADAWCA Imie: { paczka.GenerujListPrzwozowy().nadawca.Imie}, Nazwisko: {paczka.GenerujListPrzwozowy().nadawca.Nazwisko} " +
                    $"ODBIORCA Imie:{paczka.GenerujListPrzwozowy().odbiorca.Imie}, Nazwisko:{paczka.GenerujListPrzwozowy().odbiorca.Nazwisko}, koszt:{paczka.ObliczKoszt()}");
            }

            pokaz(kurierska);
            pokaz(paczkomatowa);
            pokaz(kurierskaExpres);
            Console.ReadKey();
        }
    }
}
