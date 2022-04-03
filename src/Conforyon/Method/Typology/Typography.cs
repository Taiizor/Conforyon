#region Imports

using Conforyon.Constant;
using Conforyon.Value;
using System;
using CEEMT = Conforyon.Enum.Enums.MethodType;

#endregion

namespace Conforyon.Typology
{
    /// <summary>
    /// 
    /// </summary>
    public class Typography
    {
        #region Typography
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Inch"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string INCHtoCM(string Inch, bool Decimal, bool Comma, int PostComma = 0, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Inch.Length <= Constants.VariableLength && Cores.NumberControl(Inch) && !Inch.StartsWith("0") && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && Cores.TextControl(Inch))
                {
                    return Cores.LastCheck2((Convert.ToInt64(Inch) * Convert.ToDouble(Values.GetValue(CEEMT.Typography, "INCH", "CM", Error))).ToString(), Decimal, Comma, PostComma, Error);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "TY-ITC1!)";
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
        public static string INCHtoPX(string Inch, bool Decimal, bool Comma, int PostComma = 0, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Inch.Length <= Constants.VariableLength && Cores.NumberControl(Inch) && !Inch.StartsWith("0") && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && Cores.TextControl(Inch))
                {
                    string Result = (Convert.ToInt64(Inch) * Convert.ToDouble(Values.GetValue(CEEMT.Typography, "INCH", "PX", Error))).ToString();
                    return Cores.LastCheck2(Result, Decimal, Comma, PostComma, Error);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "TY-ITP1!)";
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
        public static string CMtoINCH(string Centimeter, bool Decimal, bool Comma, int PostComma = 0, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Centimeter.Length <= Constants.VariableLength && Cores.NumberControl(Centimeter) && !Centimeter.StartsWith("0") && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && Cores.TextControl(Centimeter))
                {
                    if (Convert.ToInt64(Centimeter) >= 3)
                    {
                        return Cores.LastCheck2((Convert.ToInt64(Centimeter) * Convert.ToDouble(Values.GetValue(CEEMT.Typography, "CM", "INCH", Error))).ToString(), Decimal, Comma, PostComma, Error);
                    }
                    else
                    {
                        return Cores.LastCheck2("0", Decimal, Comma, PostComma, Error);
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "TY-CTI1!)";
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
        public static string CMtoPX(string Centimeter, bool Decimal, bool Comma, int PostComma = 0, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Centimeter.Length <= Constants.VariableLength && Cores.NumberControl(Centimeter) && !Centimeter.StartsWith("0") && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && Cores.TextControl(Centimeter))
                {
                    return Cores.LastCheck2((Convert.ToInt64(Centimeter) * Convert.ToDouble(Values.GetValue(CEEMT.Typography, "CM", "PX", Error))).ToString(), Decimal, Comma, PostComma, Error);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "TY-CTP1!)";
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
        public static string PXtoCM(string Pixel, bool Decimal, bool Comma, int PostComma = 0, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Pixel.Length <= Constants.VariableLength && Cores.NumberControl(Pixel) && !Pixel.StartsWith("0") && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && Cores.TextControl(Pixel))
                {
                    if (Convert.ToInt64(Pixel) >= 38)
                    {
                        return Cores.LastCheck2((Convert.ToInt64(Pixel) * Convert.ToDouble(Values.GetValue(CEEMT.Typography, "PX", "CM", Error))).ToString(), Decimal, Comma, PostComma, Error);
                    }
                    else
                    {
                        return Cores.LastCheck2("0", Decimal, Comma, PostComma, Error);
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "TY-PTC1!)";
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
        public static string PXtoINCH(string Pixel, bool Decimal, bool Comma, int PostComma = 0, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Pixel.Length <= Constants.VariableLength && Cores.NumberControl(Pixel) && !Pixel.StartsWith("0") && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && Cores.TextControl(Pixel))
                {
                    if (Convert.ToInt64(Pixel) >= 96)
                    {
                        return Cores.LastCheck2((Convert.ToInt64(Pixel) * Convert.ToDouble(Values.GetValue(CEEMT.Typography, "PX", "INCH", Error))).ToString(), Decimal, Comma, PostComma, Error);
                    }
                    else
                    {
                        return Cores.LastCheck2("0", Decimal, Comma, PostComma, Error);
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "TY-PTI1!)";
            }
        }
        #endregion
    }
}