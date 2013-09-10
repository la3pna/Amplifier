using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amplifier
{
  public static class notation
    {
        public static string ToEngineeringNotation(this double d)
        {
            double exponent = Math.Log10(Math.Abs(d));
            if (Math.Abs(d) >= 1)
            {
                switch ((int)Math.Floor(exponent))
                {
                    case 0:
                    case 1:
                    case 2:
                        return (Math.Round(d,2)).ToString();
                    case 3:
                    case 4:
                    case 5:
                        return (Math.Round(d / 1e3,2)).ToString() + "k";
                    case 6:
                    case 7:
                    case 8:
                        return (Math.Round(d / 1e6,2)).ToString() + "M";
                    case 9:
                    case 10:
                    case 11:
                        return (Math.Round(d / 1e9,2)).ToString() + "G";
                    case 12:
                    case 13:
                    case 14:
                        return (Math.Round(d / 1e12,2)).ToString() + "T";
                    case 15:
                    case 16:
                    case 17:
                        return (Math.Round(d / 1e15,2)).ToString() + "P";
                    case 18:
                    case 19:
                    case 20:
                        return (Math.Round(d / 1e18,2)).ToString() + "E";
                    case 21:
                    case 22:
                    case 23:
                        return (Math.Round(d / 1e21,2)).ToString() + "Z";
                    default:
                        return (Math.Round(d / 1e24,2)).ToString() + "Y";
                }
            }
            else if (Math.Abs(d) > 0)
            {
                switch ((int)Math.Floor(exponent))
                {
                    case -1:
                    case -2:
                    case -3:
                        return (Math.Round(d * 1e3,3)).ToString() + "m";
                    case -4:
                    case -5:
                    case -6:
                        return (Math.Round(d * 1e6,3)).ToString() + "μ";
                    case -7:
                    case -8:
                    case -9:
                        return (Math.Round(d * 1e9,3)).ToString() + "n";
                    case -10:
                    case -11:
                    case -12:
                        return (Math.Round(d * 1e12,3)).ToString() + "p";
                    case -13:
                    case -14:
                    case -15:
                        return (Math.Round(d * 1e15,3)).ToString() + "f";
                    case -16:
                    case -17:
                    case -18:
                        return (Math.Round(d * 1e15,3)).ToString() + "a";
                    case -19:
                    case -20:
                    case -21:
                        return (Math.Round(d * 1e15,3)).ToString() + "z";
                    default:
                        return (Math.Round(d * 1e15)).ToString() + "y";
                }
            }
            else
            {
                return "0";
            }
        }
    }
}
