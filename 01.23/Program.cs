using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01._23
{
    class Program
    {

        /*
         * HammingLista(string szo, List<string> lista)
         * visszatérési érték egy lista
         *          - olyan elemekből áll, amelyekre igaz
         *          - H.t. <= 3 
         */


        /*
         * HammingErtek(string szo1, string szo2)
         * visszatérési értéke: Hamming-távolság (egész szám)
         */
        static int HammingErtek(string szo1, string szo2)
        {
            int ham = 0;
            for (int i = 0; i < szo1.Length; i++)
            {
                if (!szo1[i].Equals(szo2[i]))
                {
                    ham++;
                }
                
            }
            return ham;
        }
        static List<string> HammingLista(string szo, List<string> lista)
        {

            List<string> jok = new List<string>();
            foreach (var i in lista)
            {
                if (HammingErtek(szo, i) <= 3)
                {
                    jok.Add(i);
                }
            }
            return jok;

        }
        static void Main(string[] args)
        {

            Console.WriteLine(HammingErtek("elma", "almo"));

            StreamReader be = new StreamReader("humming.txt");
            string szo = "";
            List<string> lista = new List<string>();
            while (!be.EndOfStream)
            {
                szo = be.ReadLine();

                string[] tmp = be.ReadLine().Split(';');

                lista.Clear();
                foreach (var t in tmp)
                {
                    lista.Add(t);
                }
                
                Console.WriteLine($"szó: {szo}");
                Console.Write("lista: ");
                foreach (var i in lista)
                {
                    Console.Write($"{i}, ");
                }


                Console.Write("\neredmény: ");
                foreach (var item in HammingLista(szo, lista))
                {
                    Console.Write($"{item}, ");
                }

                Console.WriteLine();
            }
            be.Close();
            


            Console.ReadKey();
        }
    }
}
