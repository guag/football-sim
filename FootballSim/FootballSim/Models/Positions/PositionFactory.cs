using System;

namespace FootballSim.Models.Positions
{
    public class PositionFactory
    {
        #region IPositionFactory Members

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
                    break;
                case PositionType.DefensiveTackle:
                    break;
                case PositionType.OutsideLinebacker:
                    break;
                case PositionType.InsideLinebacker:
                    break;
                case PositionType.Cornerback:
                    break;
                case PositionType.FreeSafety:
                    break;
                case PositionType.StrongSafety:
                    break;
                case PositionType.Kicker:
                    break;
                case PositionType.Punter:
                    break;
                default:
                    throw new ArgumentOutOfRangeException("type");
            }
            throw new ArgumentOutOfRangeException("type");
        }

        #endregion
    }
}