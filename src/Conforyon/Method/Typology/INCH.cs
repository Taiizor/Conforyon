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
    public class INCH
    {
        #region INCH

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Inch"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CM(int Inch, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            return CM($"{Inch}", Decimal, Comma, PostComma, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Inch"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CM(object Inch, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            return CM($"{Inch}", Decimal, Comma, PostComma, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Inch"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CM(string Inch, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (Inch.Length <= CCC.VariableLength && CC.NumberControl(Inch) && !Inch.StartsWith("0") && PostComma >= CCC.PostCommaMinimum && PostComma <= CCC.PostCommaMaximum && CC.TextControl(Inch))
                {
                    double Result = SC.ToInt64(Inch) * SC.ToDouble(CVV.GetValue(CEEMT.Typography, "INCH", "CM", Error));

                    return CC.ResultFormat(Result, Decimal, Comma, PostComma, Error);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "TY-INCHC1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Inch"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string PX(int Inch, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            return PX($"{Inch}", Decimal, Comma, PostComma, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Inch"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string PX(object Inch, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            return PX($"{Inch}", Decimal, Comma, PostComma, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Inch"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string PX(string Inch, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (Inch.Length <= CCC.VariableLength && CC.NumberControl(Inch) && !Inch.StartsWith("0") && PostComma >= CCC.PostCommaMinimum && PostComma <= CCC.PostCommaMaximum && CC.TextControl(Inch))
                {
                    double Result = SC.ToInt64(Inch) * SC.ToDouble(CVV.GetValue(CEEMT.Typography, "INCH", "PX", Error));

                    return CC.ResultFormat(Result, Decimal, Comma, PostComma, Error);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "TY-INCHP1!)";
            }
        }

        #endregion
    }
}