namespace FootballSim.Models.Positions
{
    public struct EmptyPosition : IPosition
    {
        #region IPosition Members

        public PositionType Type
        {
            get { return PositionType.None; }
        }

        public string Name
        {
            get { return "None"; }
        }

        public Side Side
        {
            get { return Side.None; }
        }

        public int MinWeight { get; set; }
        public int MaxWeight { get; set; }
        public int MinHeight { get; set; }
        public int MaxHeight { get; set; }

        #endregion
    }
}