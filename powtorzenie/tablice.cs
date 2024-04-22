using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powtorzenie
{
    public class tablice
    {
        public void Wyswietl(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i] + ",sr5y ");
            }
        }
        public int[] Tworzenie_tablicy()
        {
            Console.WriteLine("Ile znaków ma mieć tablica?");
            int dl = int.Parse(Console.ReadLine());
            int[] ints = new int[dl];
            for (int i = 0; i < dl; i++)
            {
                Console.Write("Podaj kolejny element tablicy: ");
                ints[i] = int.Parse(Console.ReadLine());
            }
            return ints;
        }
        public void Sortowanie_babelkowe(int[] tabliczka)
        {
            for( int i =0; i <tabliczka.Length; i++)
            {
                for(int j =0; j < tabliczka.Length; j++)
                {
                    if (tabliczka[j-1] > tabliczka[j])
                    {
                        int temp = tabliczka[j - 1];
                        tabliczka[j - 1] = tabliczka[j];
                        tabliczka[j] = temp;
                    }
                }
            }
        }
    }
}
