#region Imports

using System;
using static Conforyon.Conforyon;

#endregion

namespace Conforyon
{
    public static class Temperature
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Celsius"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Text"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CtoF(int Celsius, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = ErrorMessage)
        {
            try
            {
                if (NumberCheck(Celsius.ToString(), false, IntType.Int32) && PostComma >= PostCommaMinimum && PostComma <= PostCommaMaximum)
                {
                    if (Text)
                        return LastCheck2((Convert.ToDouble(Celsius) * 9 / 5 + 32).ToString(), Decimal, Comma, PostComma, Error) + " F";
                    else
                        return LastCheck2((Convert.ToDouble(Celsius) * 9 / 5 + 32).ToString(), Decimal, Comma, PostComma, Error);
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "TE-CTF1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fahrenheit"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Text"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string FtoC(int Fahrenheit, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = ErrorMessage)
        {
            try
            {
                if (NumberCheck(Fahrenheit.ToString(), false, IntType.Int32) && PostComma >= PostCommaMinimum && PostComma <= PostCommaMaximum)
                {
                    if (Convert.ToInt64(Fahrenheit) >= 32)
                    {
                        if (Text)
                            return LastCheck2(((Convert.ToDouble(Fahrenheit) - 32) * 5 / 9).ToString(), Decimal, Comma, PostComma, Error) + " C";
                        else
                            return LastCheck2(((Convert.ToDouble(Fahrenheit) - 32) * 5 / 9).ToString(), Decimal, Comma, PostComma, Error);
                    }
                    else
                    {
                        if (Text)
                            return LastCheck2("0", Decimal, Comma, PostComma, Error) + " C";
                        else
                            return LastCheck2("0", Decimal, Comma, PostComma, Error);
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "TE-FTC1!)";
            }
        }
    }
}