#region Imports

using System;
using System.Drawing;

#endregion

namespace Conforyon.Color
{
    /// <summary>
    /// 
    /// </summary>
    public class Color
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hex"></param>
        /// <param name="Type"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string HEXtoRGB(string Hex, Enum.Enum.ColorType Type = Enum.Enum.ColorType.RGB1, string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                if ((Hex.Length == 6 && Core.UseCheck(Hex)) || (Hex.Length == 7 && Hex.StartsWith("#") && Core.UseCheck(Hex.Substring(1, Hex.Length - 1))))
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
                        Enum.Enum.ColorType.RGB1 => HexColor.R + ", " + HexColor.G + ", " + HexColor.B,
                        Enum.Enum.ColorType.RGB2 => HexColor.R + " " + HexColor.G + " " + HexColor.B,
                        Enum.Enum.ColorType.RGB3 => HexColor.R + " - " + HexColor.G + " - " + HexColor.B,
                        Enum.Enum.ColorType.RRGGBB1 => "R: " + HexColor.R + ", G: " + HexColor.G + ", B: " + HexColor.B,
                        Enum.Enum.ColorType.RRGGBB2 => "R: " + HexColor.R + " G: " + HexColor.G + " B: " + HexColor.B,
                        Enum.Enum.ColorType.RRGGBB3 => "R: " + HexColor.R + " - G: " + HexColor.G + " - B: " + HexColor.B,
                        Enum.Enum.ColorType.RR => "R: " + HexColor.R,
                        Enum.Enum.ColorType.GG => "G: " + HexColor.G,
                        Enum.Enum.ColorType.BB => "B: " + HexColor.B,
                        Enum.Enum.ColorType.OnlyR => HexColor.R.ToString(),
                        Enum.Enum.ColorType.OnlyG => HexColor.G.ToString(),
                        Enum.Enum.ColorType.OnlyB => HexColor.B.ToString(),
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
                return Error + Constant.Constant.ErrorTitle + "CR-HTR1!)";
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
        public static string RGBtoHEX(int R, int G, int B, bool Sharp = false, string Error = Constant.Constant.ErrorMessage)
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
                return Error + Constant.Constant.ErrorTitle + "CR-RTH1!)";
            }
        }
    }
}