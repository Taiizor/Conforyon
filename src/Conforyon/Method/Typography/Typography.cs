#region Imports

using System;

#endregion

namespace Conforyon.Typography
{
    /// <summary>
    /// 
    /// </summary>
    public class Typography
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Inch"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string INCHtoCM(string Inch, bool Decimal, bool Comma, int PostComma = 0, string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                if (Inch.Length <= Constant.Constant.VariableLength && Core.NumberCheck(Inch) && !Inch.StartsWith("0") && PostComma >= Constant.Constant.PostCommaMinimum && PostComma <= Constant.Constant.PostCommaMaximum && Core.UseCheck(Inch))
                {
                    return Core.LastCheck2((Convert.ToInt64(Inch) * Convert.ToDouble(Value.Value.GetValue("Typography", "INCH", "CM", Error))).ToString(), Decimal, Comma, PostComma, Error);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constant.Constant.ErrorTitle + "TY-ITC1!)";
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
        public static string INCHtoPX(string Inch, bool Decimal, bool Comma, int PostComma = 0, string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                if (Inch.Length <= Constant.Constant.VariableLength && Core.NumberCheck(Inch) && !Inch.StartsWith("0") && PostComma >= Constant.Constant.PostCommaMinimum && PostComma <= Constant.Constant.PostCommaMaximum && Core.UseCheck(Inch))
                {
                    string Result = (Convert.ToInt64(Inch) * Convert.ToDouble(Value.Value.GetValue("Typography", "INCH", "PX", Error))).ToString();
                    return Core.LastCheck2(Result, Decimal, Comma, PostComma, Error);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constant.Constant.ErrorTitle + "TY-ITP1!)";
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
        public static string CMtoINCH(string Centimeter, bool Decimal, bool Comma, int PostComma = 0, string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                if (Centimeter.Length <= Constant.Constant.VariableLength && Core.NumberCheck(Centimeter) && !Centimeter.StartsWith("0") && PostComma >= Constant.Constant.PostCommaMinimum && PostComma <= Constant.Constant.PostCommaMaximum && Core.UseCheck(Centimeter))
                {
                    if (Convert.ToInt64(Centimeter) >= 3)
                    {
                        return Core.LastCheck2((Convert.ToInt64(Centimeter) * Convert.ToDouble(Value.Value.GetValue("Typography", "CM", "INCH", Error))).ToString(), Decimal, Comma, PostComma, Error);
                    }
                    else
                    {
                        return Core.LastCheck2("0", Decimal, Comma, PostComma, Error);
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constant.Constant.ErrorTitle + "TY-CTI1!)";
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
        public static string CMtoPX(string Centimeter, bool Decimal, bool Comma, int PostComma = 0, string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                if (Centimeter.Length <= Constant.Constant.VariableLength && Core.NumberCheck(Centimeter) && !Centimeter.StartsWith("0") && PostComma >= Constant.Constant.PostCommaMinimum && PostComma <= Constant.Constant.PostCommaMaximum && Core.UseCheck(Centimeter))
                {
                    return Core.LastCheck2((Convert.ToInt64(Centimeter) * Convert.ToDouble(Value.Value.GetValue("Typography", "CM", "PX", Error))).ToString(), Decimal, Comma, PostComma, Error);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constant.Constant.ErrorTitle + "TY-CTP1!)";
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
        public static string PXtoCM(string Pixel, bool Decimal, bool Comma, int PostComma = 0, string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                if (Pixel.Length <= Constant.Constant.VariableLength && Core.NumberCheck(Pixel) && !Pixel.StartsWith("0") && PostComma >= Constant.Constant.PostCommaMinimum && PostComma <= Constant.Constant.PostCommaMaximum && Core.UseCheck(Pixel))
                {
                    if (Convert.ToInt64(Pixel) >= 38)
                    {
                        return Core.LastCheck2((Convert.ToInt64(Pixel) * Convert.ToDouble(Value.Value.GetValue("Typography", "PX", "CM", Error))).ToString(), Decimal, Comma, PostComma, Error);
                    }
                    else
                    {
                        return Core.LastCheck2("0", Decimal, Comma, PostComma, Error);
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constant.Constant.ErrorTitle + "TY-PTC1!)";
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
        public static string PXtoINCH(string Pixel, bool Decimal, bool Comma, int PostComma = 0, string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                if (Pixel.Length <= Constant.Constant.VariableLength && Core.NumberCheck(Pixel) && !Pixel.StartsWith("0") && PostComma >= Constant.Constant.PostCommaMinimum && PostComma <= Constant.Constant.PostCommaMaximum && Core.UseCheck(Pixel))
                {
                    if (Convert.ToInt64(Pixel) >= 96)
                    {
                        return Core.LastCheck2((Convert.ToInt64(Pixel) * Convert.ToDouble(Value.Value.GetValue("Typography", "PX", "INCH", Error))).ToString(), Decimal, Comma, PostComma, Error);
                    }
                    else
                    {
                        return Core.LastCheck2("0", Decimal, Comma, PostComma, Error);
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constant.Constant.ErrorTitle + "TY-PTI1!)";
            }
        }
    }
}