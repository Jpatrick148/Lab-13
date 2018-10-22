using System;

namespace Lab_13
{
    public class User : Player
    {
        private string userName;
        public string Username { get { return userName;} }

        
        
        public User(string userName) : base(userName)
        {
            this.userName = userName;
        }

        public string UserPicks(int rpsUser)
        {
            int pick = rpsUser;
            string prompt = "Please enter 0, 1 or 2 (Rock, Paper or Scissors)";

                switch (pick)
                {
                    case 0:
                        
                        return RPS.Rock;
                        break;
                    case 1:
                        
                        return RPS.Paper;
                        break;
                    case 2:
                        
                        return RPS.Scissors;
                        break;
                    default:
                        return prompt;
                        break;
                }           
        }

        
    }
}