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

            int loss = 0;
            int win = 0;
            int tie = 0;


            RoshamboApp menu = new RoshamboApp();
            User person = menu.CreatingNewUser();


            Player opp = menu.Opponent();

            do
            {
                Console.Clear();
                string playerPick = menu.PickRoshambo(person);

                Console.WriteLine("You: " + playerPick);

                string x = opp.GenRPS();

                Console.WriteLine("Opponent: " + x);

                int outcome = menu.GameLogic(playerPick, x);

                string msg = menu.Result(outcome);



                Console.WriteLine(msg);

                //string runningTotals = Totals(outcome);
                //Console.WriteLine(runningTotals);

                if (outcome == -1)
                {
                    loss++;
                }

                if (outcome == 0)
                {
                    tie++;
                }

                if (outcome == 1)
                {
                    win++;
                }

                Console.WriteLine(
                    "Wins: " + win + " Loses: " + loss + " Ties: " + tie);

            } while (Continue());

            Console.ReadLine();

            


        }

        public static bool Continue()
        {
            Console.WriteLine("Again? {Y/N}");
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please Try Again.");
                return Continue();
            }
        }

        public static string Totals(int i)
        {
            int loss = 0;
            int win = 0;
            int tie = 0;

            if (i == -1)
            {
                loss++;
            }

            if (i == 0)
            {
                tie++;
            }

            if (i == 1)
            {
                win++;
            }

            return "Wins: " + win + "Loses: " + loss + "Ties: " + tie;
        }
    }
}
