#region Imports

using System;
using Conforyon.Value;
using Conforyon.Constant;

#endregion

namespace Conforyon.Temperature
{
    /// <summary>
    /// 
    /// </summary>
    public class Temperatures
    {
        #region Temperatures
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
        public static string CtoF(string Celsius, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Celsius.Length <= Constants.VariableLength && Cores.NumberCheck(Celsius) && !Celsius.StartsWith("0") && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && Cores.UseCheck(Celsius))
                {
                    if (Text)
                    {
                        return Cores.LastCheck2((Convert.ToDouble(Celsius) / Convert.ToInt32(Values.GetValue("Temperature", "Celsius", "Divide", Error)) * Convert.ToInt32(Values.GetValue("Temperature", "Celsius", "Multipy", Error)) + Convert.ToInt32(Values.GetValue("Temperature", "Celsius", "Add", Error))).ToString(), Decimal, Comma, PostComma, Error) + " F";
                    }
                    else
                    {
                        return Cores.LastCheck2((Convert.ToDouble(Celsius) / Convert.ToInt32(Values.GetValue("Temperature", "Celsius", "Divide", Error)) * Convert.ToInt32(Values.GetValue("Temperature", "Celsius", "Multipy", Error)) + Convert.ToInt32(Values.GetValue("Temperature", "Celsius", "Add", Error))).ToString(), Decimal, Comma, PostComma, Error);
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "TE-CTF1!)";
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
        public static string FtoC(string Fahrenheit, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Fahrenheit.Length <= Constants.VariableLength && Cores.NumberCheck(Fahrenheit) && !Fahrenheit.StartsWith("0") && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && Cores.UseCheck(Fahrenheit))
                {
                    if (Convert.ToInt64(Fahrenheit) >= 32)
                    {
                        if (Text)
                        {
                            return Cores.LastCheck2(((Convert.ToDouble(Fahrenheit) - Convert.ToInt32(Values.GetValue("Temperature", "Fahrenheit", "Deduct", Error))) * Convert.ToInt32(Values.GetValue("Temperature", "Fahrenheit", "Multipy", Error)) / Convert.ToInt32(Values.GetValue("Temperature", "Fahrenheit", "Divide", Error))).ToString(), Decimal, Comma, PostComma, Error) + " C";
                        }
                        else
                        {
                            return Cores.LastCheck2(((Convert.ToDouble(Fahrenheit) - Convert.ToInt32(Values.GetValue("Temperature", "Fahrenheit", "Deduct", Error))) * Convert.ToInt32(Values.GetValue("Temperature", "Fahrenheit", "Multipy", Error)) / Convert.ToInt32(Values.GetValue("Temperature", "Fahrenheit", "Divide", Error))).ToString(), Decimal, Comma, PostComma, Error);
                        }
                    }
                    else
                    {
                        if (Text)
                        {
                            return Cores.LastCheck2("0", Decimal, Comma, PostComma, Error) + " C";
                        }
                        else
                        {
                            return Cores.LastCheck2("0", Decimal, Comma, PostComma, Error);
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
                return Error + Constants.ErrorTitle + "TE-FTC1!)";
            }
        }
        #endregion
    }
}