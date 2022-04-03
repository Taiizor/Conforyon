#region Imports

using Conforyon.Constant;
using Conforyon.Value;
using System;
using CC = Conforyon.Cores;
using CCC = Conforyon.Constant.Constants;
using CEEMT = Conforyon.Enum.Enums.MethodType;
using CVV = Conforyon.Value.Values;
using SC = System.Convert;

#endregion

namespace Conforyon.Speed
{
    /// <summary>
    /// 
    /// </summary>
    public class KPH
    {
        #region KPH

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kilometers"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Text"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string MPH(string Kilometers, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Kilometers.Length <= Constants.VariableLength && Cores.NumberControl(Kilometers) && !Kilometers.StartsWith("0") && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && Cores.TextControl(Kilometers))
                {
                    if (Text)
                    {
                        return Cores.ResultFormat((Convert.ToDouble(Kilometers) * Convert.ToDouble(Values.GetValue(CEEMT.Speed, "KPH", "MPH", Error))).ToString(), Decimal, Comma, PostComma, Error) + " MPH";
                    }
                    else
                    {
                        return Cores.ResultFormat((Convert.ToDouble(Kilometers) * Convert.ToDouble(Values.GetValue(CEEMT.Speed, "KPH", "MPH", Error))).ToString(), Decimal, Comma, PostComma, Error);
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "SD-MPH1!)";
            }
        }

        #endregion
    }
}