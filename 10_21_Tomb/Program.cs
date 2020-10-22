using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _10_21_Tomb
{
    class Program
    {
        static void Paratlantomb()
        {
            int[] tombparatlan = new int[12];
            Random rnd = new Random();
            Console.WriteLine("12 db páratlan 3 számjegyű számok: ");
            for (int i = 0; i < 12; i++)
            {
                int x = rnd.Next(100,999);
                if (x % 2 == 0)
                {
                    x+= 1;
                    Console.WriteLine(tombparatlan[i] = x );
                }
                else
                {
                    Console.WriteLine(tombparatlan[i] = x);
                }
            }
        }
        static void Main(string[] args)
        {
            Paratlantomb();
            Console.ReadKey();
        }
    }
}
