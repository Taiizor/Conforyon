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
    public class MPH
    {
        #region MPH

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Miles"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Text"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string KPH(string Miles, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Miles.Length <= Constants.VariableLength && Cores.NumberControl(Miles) && !Miles.StartsWith("0") && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && Cores.TextControl(Miles))
                {
                    if (Text)
                    {
                        return Cores.ResultFormat((Convert.ToDouble(Miles) * Convert.ToDouble(Values.GetValue(CEEMT.Speed, "MPH", "KPH", Error))).ToString(), Decimal, Comma, PostComma, Error) + " KPH";
                    }
                    else
                    {
                        return Cores.ResultFormat((Convert.ToDouble(Miles) * Convert.ToDouble(Values.GetValue(CEEMT.Speed, "MPH", "KPH", Error))).ToString(), Decimal, Comma, PostComma, Error);
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "SD-KPH1!)";
            }
        }

        #endregion
    }
}