#region Imports

using System;
using static Conforyon.Conforyon;

#endregion

namespace Conforyon
{
    public static class Speed
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
        public static string MPHtoKPH(string Miles, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = ErrorMessage)
        {
            try
            {
                if (Miles.Length <= VariableLength && NumberCheck(Miles) && !Miles.StartsWith("0") && PostComma >= PostCommaMinimum && PostComma <= PostCommaMaximum && UseCheck(Miles))
                {
                    if (Text)
                        return LastCheck2((Convert.ToDouble(Miles) * 1.609344).ToString(), Decimal, Comma, PostComma, Error) + " KPH";
                    else
                        return LastCheck2((Convert.ToDouble(Miles) * 1.609344).ToString(), Decimal, Comma, PostComma, Error);
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "SD-MTK1!)";
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
        public static string KPHtoMPH(string Kilometers, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = ErrorMessage)
        {
            try
            {
                if (Kilometers.Length <= VariableLength && NumberCheck(Kilometers) && !Kilometers.StartsWith("0") && PostComma >= PostCommaMinimum && PostComma <= PostCommaMaximum && UseCheck(Kilometers))
                {
                    if (Text)
                        return LastCheck2((Convert.ToDouble(Kilometers) * 0.621371192).ToString(), Decimal, Comma, PostComma, Error) + " MPH";
                    else
                        return LastCheck2((Convert.ToDouble(Kilometers) * 0.621371192).ToString(), Decimal, Comma, PostComma, Error);
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "SD-KTM1!)";
            }
        }
    }
}