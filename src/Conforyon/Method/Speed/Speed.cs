#region Imports

using System;

#endregion

namespace Conforyon.Speed
{
    /// <summary>
    /// 
    /// </summary>
    public class Speed
    {
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
        public static string MPHtoKPH(string Miles, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                if (Miles.Length <= Constant.Constant.VariableLength && Core.NumberCheck(Miles) && !Miles.StartsWith("0") && PostComma >= Constant.Constant.PostCommaMinimum && PostComma <= Constant.Constant.PostCommaMaximum && Core.UseCheck(Miles))
                {
                    if (Text)
                    {
                        return Core.LastCheck2((Convert.ToDouble(Miles) * Convert.ToDouble(Value.Value.GetValue("Speed", "MPH", "KPH", Error))).ToString(), Decimal, Comma, PostComma, Error) + " KPH";
                    }
                    else
                    {
                        return Core.LastCheck2((Convert.ToDouble(Miles) * Convert.ToDouble(Value.Value.GetValue("Speed", "MPH", "KPH", Error))).ToString(), Decimal, Comma, PostComma, Error);
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constant.Constant.ErrorTitle + "SD-MTK1!)";
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
        public static string KPHtoMPH(string Kilometers, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                if (Kilometers.Length <= Constant.Constant.VariableLength && Core.NumberCheck(Kilometers) && !Kilometers.StartsWith("0") && PostComma >= Constant.Constant.PostCommaMinimum && PostComma <= Constant.Constant.PostCommaMaximum && Core.UseCheck(Kilometers))
                {
                    if (Text)
                    {
                        return Core.LastCheck2((Convert.ToDouble(Kilometers) * Convert.ToDouble(Value.Value.GetValue("Speed", "KPH", "MPH", Error))).ToString(), Decimal, Comma, PostComma, Error) + " MPH";
                    }
                    else
                    {
                        return Core.LastCheck2((Convert.ToDouble(Kilometers) * Convert.ToDouble(Value.Value.GetValue("Speed", "KPH", "MPH", Error))).ToString(), Decimal, Comma, PostComma, Error);
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constant.Constant.ErrorTitle + "SD-KTM1!)";
            }
        }
    }
}