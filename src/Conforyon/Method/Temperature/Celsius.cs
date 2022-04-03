#region Imports

using System;
using CCC = Conforyon.Constant.Constants;
using CVV = Conforyon.Value.Values;
using CEEMT = Conforyon.Enum.Enums.MethodType;

#endregion

namespace Conforyon.Temperature
{
    /// <summary>
    /// 
    /// </summary>
    public class Celsius
    {
        #region Celsius

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
        public static string Fahrenheit(int Celsius, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = CCC.ErrorMessage)
        {
            return Fahrenheit($"{Celsius}", Decimal, Comma, PostComma, Text, Error);
        }

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
        public static string Fahrenheit(string Celsius, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (Celsius.Length <= CCC.VariableLength && Cores.NumberControl(Celsius) && !Celsius.StartsWith("0") && PostComma >= CCC.PostCommaMinimum && PostComma <= CCC.PostCommaMaximum && Cores.TextControl(Celsius))
                {
                    double Fahrenheit = ((Convert.ToDouble(Celsius) * Convert.ToInt32(CVV.GetValue(CEEMT.Temperature, "Celsius", "Multiply", Error))) / Convert.ToInt32(CVV.GetValue(CEEMT.Temperature, "Celsius", "Divide", Error))) + Convert.ToInt32(CVV.GetValue(CEEMT.Temperature, "Celsius", "Add", Error));

                    string Result = Cores.ResultFormat($"{Fahrenheit}", Decimal, Comma, PostComma, Error);

                    if (Text)
                    {
                        Result = $"{Fahrenheit} F";
                    }

                    return Result;
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "TE-F1!)";
            }
        }

        #endregion
    }
}