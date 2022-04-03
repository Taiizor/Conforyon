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
        public static string Celsius(int Fahrenheit, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = CCC.ErrorMessage)
        {
            return Celsius($"{Fahrenheit}", Decimal, Comma, PostComma, Text, Error);
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
        public static string Celsius(object Fahrenheit, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = CCC.ErrorMessage)
        {
            return Celsius($"{Fahrenheit}", Decimal, Comma, PostComma, Text, Error);
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
        public static string Celsius(string Fahrenheit, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (Fahrenheit.Length <= CCC.VariableLength && CC.NumberControl(Fahrenheit) && !Fahrenheit.StartsWith("0") && PostComma >= CCC.PostCommaMinimum && PostComma <= CCC.PostCommaMaximum && CC.TextControl(Fahrenheit))
                {
                    double Celsius = (SC.ToDouble(Fahrenheit) - SC.ToInt32(CVV.GetValue(CEEMT.Temperature, "Fahrenheit", "Deduct", Error))) * SC.ToInt32(CVV.GetValue(CEEMT.Temperature, "Fahrenheit", "Multiply", Error)) / SC.ToInt32(CVV.GetValue(CEEMT.Temperature, "Fahrenheit", "Divide", Error));

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
                return Error + CCC.ErrorTitle + "TE-C1!)";
            }
        }

        #endregion
    }
}