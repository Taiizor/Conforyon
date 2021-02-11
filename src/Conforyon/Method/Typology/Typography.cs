#region Imports

using System;
using Conforyon.Value;
using Conforyon.Constant;

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
                if (Inch.Length <= Constants.VariableLength && Cores.NumberCheck(Inch) && !Inch.StartsWith("0") && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && Cores.UseCheck(Inch))
                {
                    return Cores.LastCheck2((Convert.ToInt64(Inch) * Convert.ToDouble(Values.GetValue("Typography", "INCH", "CM", Error))).ToString(), Decimal, Comma, PostComma, Error);
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
                if (Inch.Length <= Constants.VariableLength && Cores.NumberCheck(Inch) && !Inch.StartsWith("0") && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && Cores.UseCheck(Inch))
                {
                    string Result = (Convert.ToInt64(Inch) * Convert.ToDouble(Values.GetValue("Typography", "INCH", "PX", Error))).ToString();
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
                if (Centimeter.Length <= Constants.VariableLength && Cores.NumberCheck(Centimeter) && !Centimeter.StartsWith("0") && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && Cores.UseCheck(Centimeter))
                {
                    if (Convert.ToInt64(Centimeter) >= 3)
                    {
                        return Cores.LastCheck2((Convert.ToInt64(Centimeter) * Convert.ToDouble(Values.GetValue("Typography", "CM", "INCH", Error))).ToString(), Decimal, Comma, PostComma, Error);
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
                if (Centimeter.Length <= Constants.VariableLength && Cores.NumberCheck(Centimeter) && !Centimeter.StartsWith("0") && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && Cores.UseCheck(Centimeter))
                {
                    return Cores.LastCheck2((Convert.ToInt64(Centimeter) * Convert.ToDouble(Values.GetValue("Typography", "CM", "PX", Error))).ToString(), Decimal, Comma, PostComma, Error);
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
                if (Pixel.Length <= Constants.VariableLength && Cores.NumberCheck(Pixel) && !Pixel.StartsWith("0") && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && Cores.UseCheck(Pixel))
                {
                    if (Convert.ToInt64(Pixel) >= 38)
                    {
                        return Cores.LastCheck2((Convert.ToInt64(Pixel) * Convert.ToDouble(Values.GetValue("Typography", "PX", "CM", Error))).ToString(), Decimal, Comma, PostComma, Error);
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
                if (Pixel.Length <= Constants.VariableLength && Cores.NumberCheck(Pixel) && !Pixel.StartsWith("0") && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && Cores.UseCheck(Pixel))
                {
                    if (Convert.ToInt64(Pixel) >= 96)
                    {
                        return Cores.LastCheck2((Convert.ToInt64(Pixel) * Convert.ToDouble(Values.GetValue("Typography", "PX", "INCH", Error))).ToString(), Decimal, Comma, PostComma, Error);
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