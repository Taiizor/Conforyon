#region Imports

using CCC = Conforyon.Constant.Constants;
using CVV = Conforyon.Value.Values;
using SC = System.Convert;
using CEEMT = Conforyon.Enum.Enums.MethodType;

#endregion

namespace Conforyon.Typology
{
    /// <summary>
    /// 
    /// </summary>
    public class CM
    {
        #region CM

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Centimeter"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string INCH(int Centimeter, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            return INCH($"{Centimeter}", Decimal, Comma, PostComma, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Centimeter"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string INCH(string Centimeter, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (Centimeter.Length <= CCC.VariableLength && Cores.NumberControl(Centimeter) && !Centimeter.StartsWith("0") && PostComma >= CCC.PostCommaMinimum && PostComma <= CCC.PostCommaMaximum && Cores.TextControl(Centimeter))
                {
                    return Cores.ResultFormat(SC.ToInt64(Centimeter) * SC.ToDouble(CVV.GetValue(CEEMT.Typography, "CM", "INCH", Error)), Decimal, Comma, PostComma, Error);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "TY-CMI!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Centimeter"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string PX(int Centimeter, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            return PX($"{Centimeter}", Decimal, Comma, PostComma, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Centimeter"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string PX(string Centimeter, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (Centimeter.Length <= CCC.VariableLength && Cores.NumberControl(Centimeter) && !Centimeter.StartsWith("0") && PostComma >= CCC.PostCommaMinimum && PostComma <= CCC.PostCommaMaximum && Cores.TextControl(Centimeter))
                {
                    return Cores.ResultFormat(SC.ToInt64(Centimeter) * SC.ToDouble(CVV.GetValue(CEEMT.Typography, "CM", "PX", Error)), Decimal, Comma, PostComma, Error);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "TY-CMP1!)";
            }
        }

        #endregion
    }
}