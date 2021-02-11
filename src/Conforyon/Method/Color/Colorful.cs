#region Imports

using System;
using Conforyon.Enum;
using System.Drawing;
using Conforyon.Constant;

#endregion

namespace Conforyon.Color
{
    /// <summary>
    /// 
    /// </summary>
    public class Colorful
    {
        #region Colorful
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hex"></param>
        /// <param name="Type"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string HEXtoRGB(string Hex, Enums.ColorType Type = Enums.ColorType.RGB1, string Error = Constants.ErrorMessage)
        {
            try
            {
                if ((Hex.Length == 6 && Cores.UseCheck(Hex)) || (Hex.Length == 7 && Hex.StartsWith("#") && Cores.UseCheck(Hex.Substring(1, Hex.Length - 1))))
                {
                    System.Drawing.Color HexColor;
                    if (Hex.StartsWith("#"))
                    {
                        HexColor = ColorTranslator.FromHtml(Hex);
                    }
                    else
                    {
                        HexColor = ColorTranslator.FromHtml("#" + Hex);
                    }

                    return Type switch
                    {
                        Enums.ColorType.RGB1 => HexColor.R + ", " + HexColor.G + ", " + HexColor.B,
                        Enums.ColorType.RGB2 => HexColor.R + " " + HexColor.G + " " + HexColor.B,
                        Enums.ColorType.RGB3 => HexColor.R + " - " + HexColor.G + " - " + HexColor.B,
                        Enums.ColorType.RRGGBB1 => "R: " + HexColor.R + ", G: " + HexColor.G + ", B: " + HexColor.B,
                        Enums.ColorType.RRGGBB2 => "R: " + HexColor.R + " G: " + HexColor.G + " B: " + HexColor.B,
                        Enums.ColorType.RRGGBB3 => "R: " + HexColor.R + " - G: " + HexColor.G + " - B: " + HexColor.B,
                        Enums.ColorType.RR => "R: " + HexColor.R,
                        Enums.ColorType.GG => "G: " + HexColor.G,
                        Enums.ColorType.BB => "B: " + HexColor.B,
                        Enums.ColorType.OnlyR => HexColor.R.ToString(),
                        Enums.ColorType.OnlyG => HexColor.G.ToString(),
                        Enums.ColorType.OnlyB => HexColor.B.ToString(),
                        _ => Error,
                    };
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "CR-HTR1!)";
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
        public static string RGBtoHEX(int R, int G, int B, bool Sharp = false, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (R <= 255 && R >= 0 && G <= 255 && G >= 0 && B <= 255 && B >= 0)
                {
                    System.Drawing.Color RGBColor = System.Drawing.Color.FromArgb(Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B));
                    if (Sharp)
                    {
                        return "#" + RGBColor.R.ToString("X2") + RGBColor.G.ToString("X2") + RGBColor.B.ToString("X2");
                    }
                    else
                    {
                        return RGBColor.R.ToString("X2") + RGBColor.G.ToString("X2") + RGBColor.B.ToString("X2");
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "CR-RTH1!)";
            }
        }
        #endregion
    }
}