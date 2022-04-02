#region Imports

using CCC = Conforyon.Constant.Constants;
using CEECT = Conforyon.Enum.Enums.ColorType;
using SDC = System.Drawing.Color;
using SDCT = System.Drawing.ColorTranslator;

#endregion

namespace Conforyon.Color
{
    /// <summary>
    /// 
    /// </summary>
    public class HEX
    {
        #region HEX

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hex"></param>
        /// <param name="Type"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string RGB(string Hex, CEECT Type = CEECT.RGB1, string Error = CCC.ErrorMessage)
        {
            try
            {
                if ((Hex.Length == 6 && Cores.UseCheck(Hex)) || (Hex.Length == 7 && Hex.StartsWith("#") && Cores.UseCheck(Hex.Substring(1, Hex.Length - 1))))
                {
                    SDC HexColor;

                    if (Hex.StartsWith("#"))
                    {
                        HexColor = SDCT.FromHtml(Hex);
                    }
                    else
                    {
                        HexColor = SDCT.FromHtml("#" + Hex);
                    }

                    return Type switch
                    {
                        CEECT.RGB1 => HexColor.R + ", " + HexColor.G + ", " + HexColor.B,
                        CEECT.RGB2 => HexColor.R + " " + HexColor.G + " " + HexColor.B,
                        CEECT.RGB3 => HexColor.R + " - " + HexColor.G + " - " + HexColor.B,
                        CEECT.RRGGBB1 => "R: " + HexColor.R + ", G: " + HexColor.G + ", B: " + HexColor.B,
                        CEECT.RRGGBB2 => "R: " + HexColor.R + " G: " + HexColor.G + " B: " + HexColor.B,
                        CEECT.RRGGBB3 => "R: " + HexColor.R + " - G: " + HexColor.G + " - B: " + HexColor.B,
                        CEECT.RR => "R: " + HexColor.R,
                        CEECT.GG => "G: " + HexColor.G,
                        CEECT.BB => "B: " + HexColor.B,
                        CEECT.OnlyR => HexColor.R.ToString(),
                        CEECT.OnlyG => HexColor.G.ToString(),
                        CEECT.OnlyB => HexColor.B.ToString(),
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
                return Error + CCC.ErrorTitle + "CR-HEX1!)";
            }
        }

        #endregion
    }
}