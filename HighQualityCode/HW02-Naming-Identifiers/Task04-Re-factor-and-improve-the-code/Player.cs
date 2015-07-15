namespace Task04_Re_factor_and_improve_the_code
{
    public class Player
    {
        public Player()
        {
        }

        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public string Name { get; set; }

        public int Points { get; set; }
    }
}