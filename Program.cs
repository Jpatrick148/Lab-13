using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Player p = new Randy(r);
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(p.GenRPS());
            }

            Console.ReadLine();

        }
    }
}
