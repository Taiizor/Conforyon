#region Imports

using CC = Conforyon.Cores;
using CCC = Conforyon.Constant.Constants;
using CEEIT = Conforyon.Enum.Enums.IntType;
using SC = System.Convert;
using SDC = System.Drawing.Color;

#endregion

namespace Conforyon.Color
{
    /// <summary>
    /// 
    /// </summary>
    public class RGB
    {
        #region RGB

        /// <summary>
        /// 
        /// </summary>
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        /// <param name="Sharp"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string HEX(string R, string G, string B, bool Sharp = false, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (CC.NumberControl(R, false, CEEIT.Int32) && CC.NumberControl(G, false, CEEIT.Int32) && CC.NumberControl(B, false, CEEIT.Int32))
                {
                    return HEX(SC.ToInt32(R), SC.ToInt32(G), SC.ToInt32(B), Sharp, Error);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        /// <param name="Sharp"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string HEX(int R, int G, int B, bool Sharp = false, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (R <= 255 && R >= 0 && G <= 255 && G >= 0 && B <= 255 && B >= 0)
                {
                    SDC RGBColor = SDC.FromArgb(SC.ToInt32(R), SC.ToInt32(G), SC.ToInt32(B));

                    string Result = $"{RGBColor.R:X2}{RGBColor.G:X2}{RGBColor.B:X2}";

                    if (Sharp)
                    {
                        Result = $"#{Result}";
                    }

                    return Result;
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "CR-HEX2!)";
            }
        }

        #endregion
    }
}