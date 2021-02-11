#region Imports

using System;
using static Conforyon.Conforyon;
using static Conforyon.Constant.Constant;

#endregion

namespace Conforyon
{
    /// <summary>
    /// 
    /// </summary>
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
        public static string CtoF(string Celsius, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = ErrorMessage)
        {
            try
            {
                if (Celsius.Length <= VariableLength && NumberCheck(Celsius) && !Celsius.StartsWith("0") && PostComma >= PostCommaMinimum && PostComma <= PostCommaMaximum && UseCheck(Celsius))
                {
                    if (Text)
                    {
                        return LastCheck2((Convert.ToDouble(Celsius) / Convert.ToInt32(GetValues("Temperature", "Celsius", "Divide", Error)) * Convert.ToInt32(GetValues("Temperature", "Celsius", "Multipy", Error)) + Convert.ToInt32(GetValues("Temperature", "Celsius", "Add", Error))).ToString(), Decimal, Comma, PostComma, Error) + " F";
                    }
                    else
                    {
                        return LastCheck2((Convert.ToDouble(Celsius) / Convert.ToInt32(GetValues("Temperature", "Celsius", "Divide", Error)) * Convert.ToInt32(GetValues("Temperature", "Celsius", "Multipy", Error)) + Convert.ToInt32(GetValues("Temperature", "Celsius", "Add", Error))).ToString(), Decimal, Comma, PostComma, Error);
                    }
                }
                else
                {
                    return Error;
                }
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
        public static string FtoC(string Fahrenheit, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = ErrorMessage)
        {
            try
            {
                if (Fahrenheit.Length <= VariableLength && NumberCheck(Fahrenheit) && !Fahrenheit.StartsWith("0") && PostComma >= PostCommaMinimum && PostComma <= PostCommaMaximum && UseCheck(Fahrenheit))
                {
                    if (Convert.ToInt64(Fahrenheit) >= 32)
                    {
                        if (Text)
                        {
                            return LastCheck2(((Convert.ToDouble(Fahrenheit) - Convert.ToInt32(GetValues("Temperature", "Fahrenheit", "Deduct", Error))) * Convert.ToInt32(GetValues("Temperature", "Fahrenheit", "Multipy", Error)) / Convert.ToInt32(GetValues("Temperature", "Fahrenheit", "Divide", Error))).ToString(), Decimal, Comma, PostComma, Error) + " C";
                        }
                        else
                        {
                            return LastCheck2(((Convert.ToDouble(Fahrenheit) - Convert.ToInt32(GetValues("Temperature", "Fahrenheit", "Deduct", Error))) * Convert.ToInt32(GetValues("Temperature", "Fahrenheit", "Multipy", Error)) / Convert.ToInt32(GetValues("Temperature", "Fahrenheit", "Divide", Error))).ToString(), Decimal, Comma, PostComma, Error);
                        }
                    }
                    else
                    {
                        if (Text)
                        {
                            return LastCheck2("0", Decimal, Comma, PostComma, Error) + " C";
                        }
                        else
                        {
                            return LastCheck2("0", Decimal, Comma, PostComma, Error);
                        }
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + ErrorTitle + "TE-FTC1!)";
            }
        }
    }
}