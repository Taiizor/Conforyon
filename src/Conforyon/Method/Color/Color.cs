#region Imports

using System;
using System.Drawing;
using static Conforyon.Conforyon;

#endregion

namespace Conforyon
{
    public static class Color
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Type"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string HEXtoRGB(string Variable, ColorType Type = ColorType.RGB1, string Error = ErrorMessage)
        {
            try
            {
                if ((Variable.Length == 6 && UseCheck(Variable)) || (Variable.Length == 7 && Variable.StartsWith("#") && UseCheck(Variable.Substring(1, Variable.Length - 1))))
                {
                    System.Drawing.Color HexColor;
                    if (Variable.StartsWith("#"))
                        HexColor = ColorTranslator.FromHtml(Variable);
                    else
                        HexColor = ColorTranslator.FromHtml("#" + Variable);
                    switch (Type)
                    {
                        case ColorType.RGB1:
                            return HexColor.R + ", " + HexColor.G + ", " + HexColor.B;
                        case ColorType.RGB2:
                            return HexColor.R + " " + HexColor.G + " " + HexColor.B;
                        case ColorType.RGB3:
                            return HexColor.R + " - " + HexColor.G + " - " + HexColor.B;
                        case ColorType.RRGGBB1:
                            return "R: " + HexColor.R + ", G: " + HexColor.G + ", B: " + HexColor.B;
                        case ColorType.RRGGBB2:
                            return "R: " + HexColor.R + " G: " + HexColor.G + " B: " + HexColor.B;
                        case ColorType.RRGGBB3:
                            return "R: " + HexColor.R + " - G: " + HexColor.G + " - B: " + HexColor.B;
                        case ColorType.RR:
                            return "R: " + HexColor.R;
                        case ColorType.GG:
                            return "G: " + HexColor.G;
                        case ColorType.BB:
                            return "B: " + HexColor.B;
                        case ColorType.OnlyR:
                            return HexColor.R.ToString();
                        case ColorType.OnlyG:
                            return HexColor.G.ToString();
                        case ColorType.OnlyB:
                            return HexColor.B.ToString();
                        default:
                            return Error;
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "CR-HTR1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        /// <param name="Sharp"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string RGBtoHEX(string R, string G, string B, bool Sharp = false, string Error = ErrorMessage)
        {
            try
            {
                if (R.Length <= 3 && R.Length >= 1 && G.Length <= 3 && G.Length >= 1 && B.Length <= 3 && B.Length >= 1 && NumberCheck(R, false, IntType.Int32) && NumberCheck(G, false, IntType.Int32) && NumberCheck(B, false, IntType.Int32))
                {
                    if ((R.Length >= 2 && R.StartsWith("0")) == true || (G.Length >= 2 && G.StartsWith("0")) == true || (B.Length >= 2 && B.StartsWith("0")) == true)
                        return Error;
                    else
                    {
                        if (Convert.ToInt32(R) >= 0 && Convert.ToInt32(R) <= 255 && Convert.ToInt32(G) >= 0 && Convert.ToInt32(G) <= 255 && Convert.ToInt32(B) >= 0 && Convert.ToInt32(B) <= 255)
                        {
                            System.Drawing.Color RGBColor = System.Drawing.Color.FromArgb(Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B));
                            if (Sharp)
                                return "#" + RGBColor.R.ToString("X2") + RGBColor.G.ToString("X2") + RGBColor.B.ToString("X2");
                            else
                                return RGBColor.R.ToString("X2") + RGBColor.G.ToString("X2") + RGBColor.B.ToString("X2");
                        }
                        else
                            return Error;
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "CR-RTH1!)";
            }
        }
    }
}