using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiedontallennus
{
    class Program
    {
        static void Main(string[] args)
        {
            int lämpötila = 0;
            Console.Write("Anna uusi lämpötila: ");
            string syöte =Console.ReadLine();
            lämpötila = int.Parse(syöte);

            //tiedoston kirjoittaminen
            string tiedosto = @"C:\test\lämpötila.txt";
            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu");

            Console.ReadLine();
        }
    }
}
