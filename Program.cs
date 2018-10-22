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

            RoshamboApp menu = new RoshamboApp();
            menu.CreatingNewUser();

            menu.Opponent();

            menu.PickRoshambo();

            Console.ReadLine();



        }
    }
}
