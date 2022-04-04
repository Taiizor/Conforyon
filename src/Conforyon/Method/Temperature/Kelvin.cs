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
    public class Kelvin
    {
        #region Kelvin

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Text"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string Celsius(int Kelvin, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = CCC.ErrorMessage)
        {
            return Celsius($"{Kelvin}", Decimal, Comma, PostComma, Text, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Text"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string Celsius(object Kelvin, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = CCC.ErrorMessage)
        {
            return Celsius($"{Kelvin}", Decimal, Comma, PostComma, Text, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Text"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string Celsius(string Kelvin, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (Kelvin.Length <= CCC.VariableLength && CC.NumberControl(Kelvin) && !Kelvin.StartsWith("0") && PostComma >= CCC.PostCommaMinimum && PostComma <= CCC.PostCommaMaximum && CC.TextControl(Kelvin))
                {
                    double Celsius = SC.ToDouble(Kelvin) - SC.ToDouble(CVV.GetValue(CEEMT.Temperature, "Kelvin", "Celsius", Error));

                    string Result = CC.ResultFormat(Celsius, Decimal, Comma, PostComma, Error);

                    if (Text)
                    {
                        Result = $"{Result} C";
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
                return Error + CCC.ErrorTitle + "TE-KC1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Text"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string Fahrenheit(int Kelvin, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = CCC.ErrorMessage)
        {
            return Fahrenheit($"{Kelvin}", Decimal, Comma, PostComma, Text, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Text"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string Fahrenheit(object Kelvin, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = CCC.ErrorMessage)
        {
            return Fahrenheit($"{Kelvin}", Decimal, Comma, PostComma, Text, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Text"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string Fahrenheit(string Kelvin, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (Kelvin.Length <= CCC.VariableLength && CC.NumberControl(Kelvin) && !Kelvin.StartsWith("0") && PostComma >= CCC.PostCommaMinimum && PostComma <= CCC.PostCommaMaximum && CC.TextControl(Kelvin))
                {
                    double Fahrenheit = (SC.ToDouble(Kelvin) - SC.ToDouble(CVV.GetValue(CEEMT.Temperature, "Kelvin", "Fahrenheit", Error))) * SC.ToDouble(CVV.GetValue(CEEMT.Temperature, "Fahrenheit", "Divide", Error)) / SC.ToDouble(CVV.GetValue(CEEMT.Temperature, "Fahrenheit", "Multiply", Error)) + SC.ToDouble(CVV.GetValue(CEEMT.Temperature, "Fahrenheit", "Deduct", Error));

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
                return Error + CCC.ErrorTitle + "TE-KF1!)";
            }
        }

        #endregion
    }
}