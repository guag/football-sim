﻿namespace FootballSim.Models.Positions
{
    public struct WideReceiver : IPosition
    {
        public PositionType Type
        {
            get { return PositionType.WideReceiver; }
        }

        public string Name
        {
            get { return "Wide Receiver"; }
        }

        public Side Side
        {
            get { return Side.Offense; }
        }

        public double MinWeight
        {
            get { return 155; }
        }

        public double MaxWeight
        {
            get { return 265; }
        }

        public double MinHeight
        {
            get { return 65; }
        }

        public double MaxHeight
        {
            get { return 84; }
        }
    }
}