﻿#region Imports

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
        public static string INCH(long Centimeter, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
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
        public static string INCH(object Centimeter, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
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
                if (Centimeter.Length <= CCC.VariableLength && CC.NumberControl(Centimeter) && !Centimeter.StartsWith("0") && PostComma >= CCC.PostCommaMinimum && PostComma <= CCC.PostCommaMaximum && CC.TextControl(Centimeter))
                {
                    double Result = SC.ToInt64(Centimeter) * SC.ToDouble(CVV.GetValue(CEEMT.Typography, "CM", "INCH", Error));

                    return CC.ResultFormat(Result, Decimal, Comma, PostComma, Error);
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
        public static string PX(long Centimeter, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
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
        public static string PX(object Centimeter, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
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
                if (Centimeter.Length <= CCC.VariableLength && CC.NumberControl(Centimeter) && !Centimeter.StartsWith("0") && PostComma >= CCC.PostCommaMinimum && PostComma <= CCC.PostCommaMaximum && CC.TextControl(Centimeter))
                {
                    double Result = SC.ToInt64(Centimeter) * SC.ToDouble(CVV.GetValue(CEEMT.Typography, "CM", "PX", Error));

                    return CC.ResultFormat(Result, Decimal, Comma, PostComma, Error);
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