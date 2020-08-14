#region Imports

using System;
using static Conforyon.Conforyon;

#endregion

namespace Conforyon
{
    public static class Typography
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
        public static string INCHtoCM(string Inch, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Inch.Length <= VariableLength && NumberCheck(Inch) && !Inch.StartsWith("0") && PostComma >= PostCommaMinimum && PostComma <= PostCommaMaximum && UseCheck(Inch))
                    return LastCheck2((Convert.ToInt64(Inch) * 2.54).ToString(), Decimal, Comma, PostComma, Error);
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "TY-ITC1!)";
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
        public static string INCHtoPX(string Inch, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Inch.Length <= VariableLength && NumberCheck(Inch) && !Inch.StartsWith("0") && PostComma >= PostCommaMinimum && PostComma <= PostCommaMaximum && UseCheck(Inch))
                {
                    string Result = (Convert.ToInt64(Inch) * 2.54 * 37.79527559055118).ToString();
                    return LastCheck2(Result, Decimal, Comma, PostComma, Error);
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "TY-ITP1!)";
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
        public static string CMtoINCH(string Centimeter, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Centimeter.Length <= VariableLength && NumberCheck(Centimeter) && !Centimeter.StartsWith("0") && PostComma >= PostCommaMinimum && PostComma <= PostCommaMaximum && UseCheck(Centimeter))
                {
                    if (Convert.ToInt64(Centimeter) >= 3)
                        return LastCheck2((Convert.ToInt64(Centimeter) / 2.54).ToString(), Decimal, Comma, PostComma, Error);
                    else
                        return LastCheck2("0", Decimal, Comma, PostComma, Error);
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "TY-CTI1!)";
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
        public static string CMtoPX(string Centimeter, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Centimeter.Length <= VariableLength && NumberCheck(Centimeter) && !Centimeter.StartsWith("0") && PostComma >= PostCommaMinimum && PostComma <= PostCommaMaximum && UseCheck(Centimeter))
                    return LastCheck2((Convert.ToInt64(Centimeter) * 37.79527559055118).ToString(), Decimal, Comma, PostComma, Error);
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "TY-CTP1!)";
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
        public static string PXtoCM(string Pixel, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Pixel.Length <= VariableLength && NumberCheck(Pixel) && !Pixel.StartsWith("0") && PostComma >= PostCommaMinimum && PostComma <= PostCommaMaximum && UseCheck(Pixel))
                {
                    if (Convert.ToInt64(Pixel) >= 38)
                        return LastCheck2((Convert.ToInt64(Pixel) / 37.79527559055118).ToString(), Decimal, Comma, PostComma, Error);
                    else
                        return LastCheck2("0", Decimal, Comma, PostComma, Error);
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "TY-PTC1!)";
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
        public static string PXtoINCH(string Pixel, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Pixel.Length <= VariableLength && NumberCheck(Pixel) && !Pixel.StartsWith("0") && PostComma >= PostCommaMinimum && PostComma <= PostCommaMaximum && UseCheck(Pixel))
                {
                    if (Convert.ToInt64(Pixel) >= 96)
                        return LastCheck2((Convert.ToInt64(Pixel) / 37.79527559055118 / 2.54).ToString(), Decimal, Comma, PostComma, Error);
                    else
                        return LastCheck2("0", Decimal, Comma, PostComma, Error);
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "TY-PTI1!)";
            }
        }
    }
}