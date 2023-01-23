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
        static void Main(string[] args)
        {
            StreamReader be = new StreamReader("humming.txt");
            string szo = "";
            List<string> lista = new List<string>();
            while (!be.EndOfStream)
            {
                
                
                
                Console.WriteLine($"szó: {szo}");
                Console.Write("lista: ");
                foreach (var i in lista)
                {
                    Console.Write($"{i}");
                }
                Console.WriteLine();
            }
            be.Close();
            


            Console.ReadKey();
        }
    }
}
