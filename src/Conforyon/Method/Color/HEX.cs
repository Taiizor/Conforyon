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
        /// <param name="HEX"></param>
        /// <param name="Type"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string RGB(string HEX, CEECT Type = CEECT.RGB1, string Error = CCC.ErrorMessage)
        {
            try
            {
                if ((HEX.Length == 6 && Cores.TextControl(HEX)) || (HEX.Length == 7 && HEX.StartsWith("#") && Cores.TextControl(HEX.Substring(1, HEX.Length - 1))))
                {
                    SDC HexColor;

                    if (HEX.StartsWith("#"))
                    {
                        HexColor = SDCT.FromHtml(HEX);
                    }
                    else
                    {
                        HexColor = SDCT.FromHtml("#" + HEX);
                    }

                    return Type switch
                    {
                        CEECT.RGB1 => $"{HexColor.R}, {HexColor.G}, {HexColor.B}",
                        CEECT.RGB2 => $"{HexColor.R} {HexColor.G} {HexColor.B}",
                        CEECT.RGB3 => $"{HexColor.R} - {HexColor.G} - {HexColor.B}",
                        CEECT.RRGGBB1 => $"R: {HexColor.R}, G: {HexColor.G}, B: {HexColor.B}",
                        CEECT.RRGGBB2 => $"R: {HexColor.R} G: {HexColor.G} B: {HexColor.B}",
                        CEECT.RRGGBB3 => $"R: {HexColor.R} - G: {HexColor.G} - B: {HexColor.B}",
                        CEECT.RR => $"R: {HexColor.R}",
                        CEECT.GG => $"G: {HexColor.G}",
                        CEECT.BB => $"B: {HexColor.B}",
                        CEECT.OnlyR => $"{HexColor.R}",
                        CEECT.OnlyG => $"{HexColor.G}",
                        CEECT.OnlyB => $"{HexColor.B}",
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
                return Error + CCC.ErrorTitle + "CR-RGB1!)";
            }
        }

        #endregion
    }
}