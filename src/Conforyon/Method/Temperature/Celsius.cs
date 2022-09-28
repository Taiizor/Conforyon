#region Imports

using CC = Conforyon.Cores;
using CCC = Conforyon.Constant.Constants;
using CEEMT = Conforyon.Enum.Enums.MethodType;
using CVV = Conforyon.Value.Values;
using SC = System.Convert;

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
        public static string Kelvin(int Celsius, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = CCC.ErrorMessage)
        {
            return Kelvin($"{Celsius}", Decimal, Comma, PostComma, Text, Error);
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
        public static string Kelvin(long Celsius, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = CCC.ErrorMessage)
        {
            return Kelvin($"{Celsius}", Decimal, Comma, PostComma, Text, Error);
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
        public static string Kelvin(object Celsius, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = CCC.ErrorMessage)
        {
            return Kelvin($"{Celsius}", Decimal, Comma, PostComma, Text, Error);
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
        public static string Kelvin(string Celsius, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (Celsius.Length <= CCC.VariableLength && CC.NumberControl(Celsius) && !Celsius.StartsWith("0") && PostComma >= CCC.PostCommaMinimum && PostComma <= CCC.PostCommaMaximum && CC.TextControl(Celsius))
                {
                    double Kelvin = SC.ToDouble(Celsius) + SC.ToDouble(CVV.GetValue(CEEMT.Temperature, "Celsius", "Kelvin", Error));

                    string Result = CC.ResultFormat(Kelvin, Decimal, Comma, PostComma, Error);

                    if (Text)
                    {
                        Result = $"{Result} K";
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
                return Error + CCC.ErrorTitle + "TE-CK1!)";
            }
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
        public static string Fahrenheit(long Celsius, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = CCC.ErrorMessage)
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
        public static string Fahrenheit(object Celsius, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = CCC.ErrorMessage)
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
                if (Celsius.Length <= CCC.VariableLength && CC.NumberControl(Celsius) && !Celsius.StartsWith("0") && PostComma >= CCC.PostCommaMinimum && PostComma <= CCC.PostCommaMaximum && CC.TextControl(Celsius))
                {
                    double Fahrenheit = (SC.ToDouble(Celsius) * SC.ToInt32(CVV.GetValue(CEEMT.Temperature, "Celsius", "Multiply", Error)) / SC.ToInt32(CVV.GetValue(CEEMT.Temperature, "Celsius", "Divide", Error))) + SC.ToInt32(CVV.GetValue(CEEMT.Temperature, "Celsius", "Add", Error));

                    string Result = CC.ResultFormat(Fahrenheit, Decimal, Comma, PostComma, Error);

                    if (Text)
                    {
                        Result = $"{Result} F";
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
                return Error + CCC.ErrorTitle + "TE-CF1!)";
            }
        }

        #endregion
    }
}