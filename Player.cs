namespace Lab_13
{
    class Player
    {
        private string name;
        private string rpsValue;

        public Player(string name)
        {
            this.name = name;
        }

        public virtual string GenRPS()
        {
            return RPS.Rock;
        }
    }


}