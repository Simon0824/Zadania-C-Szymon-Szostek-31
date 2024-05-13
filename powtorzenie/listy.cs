using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powtorzenie
{
    public class Listy
    {

        public List<int> Stowrzliste()
        {
            List<int> lista = new List<int>();
            string decyzja = "";
            while(decyzja == "t")
            {
                Console.WriteLine("Czy chcesz dodać element");
                decyzja = Console.ReadLine();
                if (decyzja == "t")
                {
                    Console.Write("Podaj element");
                    int element = int.Parse(Console.ReadLine());
                    lista.Add(element);
                }
                else
                {
                    Console.WriteLine("Podano wszystkie elementy");
                }
            }

        }

    }
}
