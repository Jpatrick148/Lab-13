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

        public string PickRoshambo()
        {
            Console.WriteLine("Please enter 0, 1 or 2 (Rock Paper or Scissors). ");
            string uNumb = Console.ReadLine();
            int uN = int.Parse(uNumb);

            string result = "Hello " + u.Username + "You have picked " + u.UserPicks(uN);

            return result;
        }

        
        
    }
}