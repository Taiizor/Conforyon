#region Imports

using System;

#endregion

namespace Conforyon.Temperature
{
    /// <summary>
    /// 
    /// </summary>
    public class Temperature
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
        public static string CtoF(string Celsius, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                if (Celsius.Length <= Constant.Constant.VariableLength && Core.NumberCheck(Celsius) && !Celsius.StartsWith("0") && PostComma >= Constant.Constant.PostCommaMinimum && PostComma <= Constant.Constant.PostCommaMaximum && Core.UseCheck(Celsius))
                {
                    if (Text)
                    {
                        return Core.LastCheck2((Convert.ToDouble(Celsius) / Convert.ToInt32(Value.Value.GetValue("Temperature", "Celsius", "Divide", Error)) * Convert.ToInt32(Value.Value.GetValue("Temperature", "Celsius", "Multipy", Error)) + Convert.ToInt32(Value.Value.GetValue("Temperature", "Celsius", "Add", Error))).ToString(), Decimal, Comma, PostComma, Error) + " F";
                    }
                    else
                    {
                        return Core.LastCheck2((Convert.ToDouble(Celsius) / Convert.ToInt32(Value.Value.GetValue("Temperature", "Celsius", "Divide", Error)) * Convert.ToInt32(Value.Value.GetValue("Temperature", "Celsius", "Multipy", Error)) + Convert.ToInt32(Value.Value.GetValue("Temperature", "Celsius", "Add", Error))).ToString(), Decimal, Comma, PostComma, Error);
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constant.Constant.ErrorTitle + "TE-CTF1!)";
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
        public static string FtoC(string Fahrenheit, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                if (Fahrenheit.Length <= Constant.Constant.VariableLength && Core.NumberCheck(Fahrenheit) && !Fahrenheit.StartsWith("0") && PostComma >= Constant.Constant.PostCommaMinimum && PostComma <= Constant.Constant.PostCommaMaximum && Core.UseCheck(Fahrenheit))
                {
                    if (Convert.ToInt64(Fahrenheit) >= 32)
                    {
                        if (Text)
                        {
                            return Core.LastCheck2(((Convert.ToDouble(Fahrenheit) - Convert.ToInt32(Value.Value.GetValue("Temperature", "Fahrenheit", "Deduct", Error))) * Convert.ToInt32(Value.Value.GetValue("Temperature", "Fahrenheit", "Multipy", Error)) / Convert.ToInt32(Value.Value.GetValue("Temperature", "Fahrenheit", "Divide", Error))).ToString(), Decimal, Comma, PostComma, Error) + " C";
                        }
                        else
                        {
                            return Core.LastCheck2(((Convert.ToDouble(Fahrenheit) - Convert.ToInt32(Value.Value.GetValue("Temperature", "Fahrenheit", "Deduct", Error))) * Convert.ToInt32(Value.Value.GetValue("Temperature", "Fahrenheit", "Multipy", Error)) / Convert.ToInt32(Value.Value.GetValue("Temperature", "Fahrenheit", "Divide", Error))).ToString(), Decimal, Comma, PostComma, Error);
                        }
                    }
                    else
                    {
                        if (Text)
                        {
                            return Core.LastCheck2("0", Decimal, Comma, PostComma, Error) + " C";
                        }
                        else
                        {
                            return Core.LastCheck2("0", Decimal, Comma, PostComma, Error);
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
                return Error + Constant.Constant.ErrorTitle + "TE-FTC1!)";
            }
        }
    }
}