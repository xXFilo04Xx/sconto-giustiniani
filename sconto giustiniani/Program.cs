using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sconto_giustiniani
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il prezzo totale: ");
            double totale = double.Parse(Console.ReadLine());
            double s = totale * 20 / 100;
            if (totale > 100)
            {
                double totalescontato = totale - s;
                Console.WriteLine($"il prezzo scontato è:{totalescontato} ");
            }
            else
            {
                Console.WriteLine($"l'importo è: {totale}");
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
