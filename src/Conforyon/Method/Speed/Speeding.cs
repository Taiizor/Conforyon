#region Imports

using Conforyon.Constant;
using Conforyon.Value;
using System;

#endregion

namespace Conforyon.Speed
{
    /// <summary>
    /// 
    /// </summary>
    public class Speeding
    {
        #region Speeding
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
        public static string MPHtoKPH(string Miles, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Miles.Length <= Constants.VariableLength && Cores.NumberControl(Miles) && !Miles.StartsWith("0") && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && Cores.TextControl(Miles))
                {
                    if (Text)
                    {
                        return Cores.LastCheck2((Convert.ToDouble(Miles) * Convert.ToDouble(Values.GetValue("Speed", "MPH", "KPH", Error))).ToString(), Decimal, Comma, PostComma, Error) + " KPH";
                    }
                    else
                    {
                        return Cores.LastCheck2((Convert.ToDouble(Miles) * Convert.ToDouble(Values.GetValue("Speed", "MPH", "KPH", Error))).ToString(), Decimal, Comma, PostComma, Error);
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "SD-MTK1!)";
            }
        }

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
        public static string KPHtoMPH(string Kilometers, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Kilometers.Length <= Constants.VariableLength && Cores.NumberControl(Kilometers) && !Kilometers.StartsWith("0") && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && Cores.TextControl(Kilometers))
                {
                    if (Text)
                    {
                        return Cores.LastCheck2((Convert.ToDouble(Kilometers) * Convert.ToDouble(Values.GetValue("Speed", "KPH", "MPH", Error))).ToString(), Decimal, Comma, PostComma, Error) + " MPH";
                    }
                    else
                    {
                        return Cores.LastCheck2((Convert.ToDouble(Kilometers) * Convert.ToDouble(Values.GetValue("Speed", "KPH", "MPH", Error))).ToString(), Decimal, Comma, PostComma, Error);
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "SD-KTM1!)";
            }
        }
        #endregion
    }
}