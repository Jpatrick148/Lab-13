using System;

namespace Lab_13
{
    public class RoshamboApp
    {
        public RoshamboApp()
        {
            
        }



        public User CreatingNewUser()
        {
            Console.WriteLine("Please enter your name.");
            string uName = Console.ReadLine();

            User u = new User(uName);
            return u;
        } 

        public Player Opponent()
        {
            Console.WriteLine("Who would you like to play against? Rocky or Randy?");
            string opp = Console.ReadLine().ToLower();

            if (opp == "rocky")
            {
                Player rock = new Rocky();
                return rock;
            }
            else if (opp == "randy")
            {
                Random r = new Random();
                Player rand = new Randy(r);
                return rand;
            }
            else
            {
                Console.WriteLine("Please enter either Rocky or Randy.");
            }
            //add loop to make sure user creates an oppenent.
            return new Player("Fake stuff");
        }

        public string PickRoshambo(User Name)
        {
            bool checkParse;
            int uN;
            do
            {
                
                Console.WriteLine("Please enter 0, 1 or 2 (Rock Paper or Scissors). ");
                string uNumb = Console.ReadLine();
                checkParse = int.TryParse(uNumb, out  uN);
            } while (!checkParse);



            string result =  Name.UserPicks(uN);

            return result;
        }

        public int GameLogic(string a, string b)
        {
            int x;

            if (a == RPS.Rock && b == RPS.Rock)
            {
                return x = 0;
            }

            else if (a == RPS.Paper && b == RPS.Paper)
            {
                return x = 0;
            }

            else if (a == RPS.Scissors && b == RPS.Scissors)
            {
                return x = 0;
            }

            else if (a == RPS.Rock && b == RPS.Paper)
            {
                return x = -1;
            }
            else if (a == RPS.Rock && b  == RPS.Scissors)
            {
                return x = 1;
            }

            else if (a == RPS.Paper && b == RPS.Rock)
            {
                return x = 1;
            }

            else if (a == RPS.Paper && b == RPS.Scissors)
            {
                return x = -1;
            }

            else if (a == RPS.Scissors && b == RPS.Rock)
            {
                return x = -1;
            }

            else if (a == RPS.Scissors && b == RPS.Paper)
            {
                return x = 1;
            }

            return 0;
        }

        public string Result(int a)
        {

            int outcome = a;
            

            if (outcome == -1)
            {
                
                return "You Lose.";
            }

            if (outcome == 0)
            {
                
                return "Tie";
            }

            if (outcome == 1)
            {
                
                return "You Win.";
            }

            return null;
        }

        //public string Totals(int i)
        //{
        //    int loss = 0;
        //    int win = 0;
        //    int tie = 0;

        //    if (i == -1)
        //    {
        //        loss++;
        //    }

        //    if (i == 0)
        //    {
        //        tie++;
        //    }

        //    if (i == 1)
        //    {
        //        win++;
        //    }

        //    return "Wins: " + win + "Loses: " + loss + "Ties: " + tie;
        //}
    }
}