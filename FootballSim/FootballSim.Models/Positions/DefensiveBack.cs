namespace FootballSim.Models.Positions
{
    public abstract class DefensiveBack : Defenseman
    {
        public override int MinWeight
        {
            get { return 175; }
        }

        public override int MaxWeight
        {
            get { return 230; }
        }

        public override int MinHeight
        {
            get { return 69; }
        }

        public override int MaxHeight
        {
            get { return 76; }
        }
    }
}