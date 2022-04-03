#region Imports

using CC = Conforyon.Cores;
using CCC = Conforyon.Constant.Constants;
using CEEMT = Conforyon.Enum.Enums.MethodType;
using CVV = Conforyon.Value.Values;
using SC = System.Convert;

#endregion

namespace Conforyon.Typology
{
    /// <summary>
    /// 
    /// </summary>
    public class PX
    {
        #region PX

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pixel"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CM(int Pixel, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            return CM($"{Pixel}", Decimal, Comma, PostComma, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pixel"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CM(string Pixel, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (Pixel.Length <= CCC.VariableLength && CC.NumberControl(Pixel) && !Pixel.StartsWith("0") && PostComma >= CCC.PostCommaMinimum && PostComma <= CCC.PostCommaMaximum && CC.TextControl(Pixel))
                {
                    double Result = SC.ToInt64(Pixel) * SC.ToDouble(CVV.GetValue(CEEMT.Typography, "PX", "CM", Error));

                    return CC.ResultFormat(Result, Decimal, Comma, PostComma, Error);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "TY-PXC!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pixel"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string INCH(int Pixel, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            return INCH($"{Pixel}", Decimal, Comma, PostComma, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pixel"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string INCH(string Pixel, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (Pixel.Length <= CCC.VariableLength && CC.NumberControl(Pixel) && !Pixel.StartsWith("0") && PostComma >= CCC.PostCommaMinimum && PostComma <= CCC.PostCommaMaximum && CC.TextControl(Pixel))
                {
                    double Result = SC.ToInt64(Pixel) * SC.ToDouble(CVV.GetValue(CEEMT.Typography, "PX", "INCH", Error));

                    return CC.ResultFormat(Result, Decimal, Comma, PostComma, Error);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "TY-PXI!)";
            }
        }

        #endregion
    }
}