#region Imports

using CC = Conforyon.Cores;
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
        public static string RGB(object HEX, CEECT Type = CEECT.RGB1, string Error = CCC.ErrorMessage)
        {
            return RGB($"{HEX}", Type, Error);
        }

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
                if ((HEX.Length == 6 && CC.TextControl(HEX)) || (HEX.Length == 7 && HEX.StartsWith("#") && CC.TextControl(HEX.Substring(1, HEX.Length - 1))))
                {
                    SDC Color;

                    if (HEX.StartsWith("#"))
                    {
                        Color = SDCT.FromHtml(HEX);
                    }
                    else
                    {
                        Color = SDCT.FromHtml("#" + HEX);
                    }

                    return Type switch
                    {
                        CEECT.RGB1 => $"{Color.R}, {Color.G}, {Color.B}",
                        CEECT.RGB2 => $"{Color.R} {Color.G} {Color.B}",
                        CEECT.RGB3 => $"{Color.R} - {Color.G} - {Color.B}",
                        CEECT.RRGGBB1 => $"R: {Color.R}, G: {Color.G}, B: {Color.B}",
                        CEECT.RRGGBB2 => $"R: {Color.R} G: {Color.G} B: {Color.B}",
                        CEECT.RRGGBB3 => $"R: {Color.R} - G: {Color.G} - B: {Color.B}",
                        CEECT.RR => $"R: {Color.R}",
                        CEECT.GG => $"G: {Color.G}",
                        CEECT.BB => $"B: {Color.B}",
                        CEECT.OnlyR => $"{Color.R}",
                        CEECT.OnlyG => $"{Color.G}",
                        CEECT.OnlyB => $"{Color.B}",
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