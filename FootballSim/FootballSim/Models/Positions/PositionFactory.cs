using System;

namespace FootballSim.Models.Positions
{
    public class PositionFactory
    {
        public static IPosition Create(PositionType type)
        {
            switch (type)
            {
                case PositionType.None:
                    return new EmptyPosition();
                case PositionType.Quarterback:
                    return new Quarterback();
                case PositionType.Halfback:
                    return new Halfback();
                case PositionType.WideReceiver:
                    return new WideReceiver();
                case PositionType.TightEnd:
                    return new TightEnd();
                case PositionType.Tackle:
                    return new Tackle();
                case PositionType.Guard:
                    return new Guard();
                case PositionType.Center:
                    return new Center();
                case PositionType.DefensiveEnd:
                    return new DefensiveEnd();
                case PositionType.DefensiveTackle:
                    return new DefensiveTackle();
                case PositionType.OutsideLinebacker:
                    return new OutsideLinebacker();
                case PositionType.InsideLinebacker:
                    return new InsideLinebacker();
                case PositionType.Cornerback:
                    return new Cornerback();
                case PositionType.FreeSafety:
                    return new FreeSafety();
                case PositionType.StrongSafety:
                    return new StrongSafety();
                case PositionType.Kicker:
                    return new Kicker();
                case PositionType.Punter:
                    return new Punter();
                default:
                    throw new ArgumentOutOfRangeException("type");
            }
        }
    }
}