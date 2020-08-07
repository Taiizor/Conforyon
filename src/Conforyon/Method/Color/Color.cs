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
        /// <param name="Mod"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string HEXtoRGB(string Variable, int Mod = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length == 6 && Mod >= 0 && Mod <= 10 && UseCheck(Variable))
                {
                    System.Drawing.Color HexColor = ColorTranslator.FromHtml("#" + Variable);
                    if (Mod == 0)
                        return HexColor.R + ", " + HexColor.G + ", " + HexColor.B;
                    else if (Mod == 1)
                        return HexColor.R + " " + HexColor.G + " " + HexColor.B;
                    else if (Mod == 2)
                        return HexColor.R + " - " + HexColor.G + " - " + HexColor.B;
                    else if (Mod == 3)
                        return "R: " + HexColor.R + " G: " + HexColor.G + " B: " + HexColor.B;
                    else if (Mod == 4)
                        return "R: " + HexColor.R + ", G: " + HexColor.G + ", B: " + HexColor.B;
                    else if (Mod == 5)
                        return "R: " + HexColor.R;
                    else if (Mod == 6)
                        return "G: " + HexColor.G;
                    else if (Mod == 7)
                        return "B: " + HexColor.B;
                    else if (Mod == 8)
                        return HexColor.R.ToString();
                    else if (Mod == 9)
                        return HexColor.G.ToString();
                    else if (Mod == 10)
                        return HexColor.B.ToString();
                    else
                        return Variable;
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
        /// <param name="Mod"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string RGBtoHEX(string R, string G, string B, bool Mod = false, string Error = ErrorMessage)
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
                            if (Mod == true)
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