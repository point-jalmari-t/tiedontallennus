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
            string tiedosto = @"C:\test\lämpötila.txt";
        
            //luetaan aiempi lämpö
            if (File.Exists(tiedosto))
            {
                string aiempiArvo = File.ReadAllText(tiedosto);
                Console.WriteLine("Aiempi lämpötila: " + aiempiArvo);
            }
            

            int lämpötila = 0;
            Console.Write("Anna uusi lämpötila: ");
            string syöte =Console.ReadLine();
            lämpötila = int.Parse(syöte);

            //tiedoston kirjoittaminen
            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu");

            Console.ReadLine();
        }
    }
}
