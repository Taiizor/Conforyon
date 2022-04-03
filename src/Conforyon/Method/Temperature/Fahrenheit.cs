#region Imports

using Conforyon.Constant;
using Conforyon.Value;
using System;
using CEEMT = Conforyon.Enum.Enums.MethodType;

#endregion

namespace Conforyon.Temperature
{
    /// <summary>
    /// 
    /// </summary>
    public class Fahrenheit
    {
        #region Fahrenheit

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
        public static string Celsius(string Fahrenheit, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Fahrenheit.Length <= Constants.VariableLength && Cores.NumberControl(Fahrenheit) && !Fahrenheit.StartsWith("0") && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && Cores.TextControl(Fahrenheit))
                {
                    if (Convert.ToInt64(Fahrenheit) >= 32)
                    {
                        if (Text)
                        {
                            return Cores.LastCheck2(((Convert.ToDouble(Fahrenheit) - Convert.ToInt32(Values.GetValue(CEEMT.Temperature, "Fahrenheit", "Deduct", Error))) * Convert.ToInt32(Values.GetValue(CEEMT.Temperature, "Fahrenheit", "Multiply", Error)) / Convert.ToInt32(Values.GetValue(CEEMT.Temperature, "Fahrenheit", "Divide", Error))).ToString(), Decimal, Comma, PostComma, Error) + " C";
                        }
                        else
                        {
                            return Cores.LastCheck2(((Convert.ToDouble(Fahrenheit) - Convert.ToInt32(Values.GetValue(CEEMT.Temperature, "Fahrenheit", "Deduct", Error))) * Convert.ToInt32(Values.GetValue(CEEMT.Temperature, "Fahrenheit", "Multiply", Error)) / Convert.ToInt32(Values.GetValue(CEEMT.Temperature, "Fahrenheit", "Divide", Error))).ToString(), Decimal, Comma, PostComma, Error);
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
                return Error + Constants.ErrorTitle + "TE-C1!)";
            }
        }

        #endregion
    }
}