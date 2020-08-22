#region Imports

using System;
using static Conforyon.Conforyon;

#endregion

namespace Conforyon
{
    public static class Speed
    {
        public static string MPHtoKPH(string Mile, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = ErrorMessage)
        {
            try
            {
                if (Mile.Length <= VariableLength && NumberCheck(Mile) && !Mile.StartsWith("0") && PostComma >= PostCommaMinimum && PostComma <= PostCommaMaximum && UseCheck(Mile))
                {
                    if (Text)
                        return LastCheck2((Convert.ToDouble(Mile) * 1.609344).ToString(), Decimal, Comma, PostComma, Error) + " KPH";
                    else
                        return LastCheck2((Convert.ToDouble(Mile) * 1.609344).ToString(), Decimal, Comma, PostComma, Error);
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "SD-MTK1!)";
            }
        }

        public static string KPHtoMPH(string Kilometer, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = ErrorMessage)
        {
            try
            {
                if (Kilometer.Length <= VariableLength && NumberCheck(Kilometer) && !Kilometer.StartsWith("0") && PostComma >= PostCommaMinimum && PostComma <= PostCommaMaximum && UseCheck(Kilometer))
                {
                    if (Text)
                        return LastCheck2((Convert.ToDouble(Kilometer) * 0.621371192).ToString(), Decimal, Comma, PostComma, Error) + " MPH";
                    else
                        return LastCheck2((Convert.ToDouble(Kilometer) * 0.621371192).ToString(), Decimal, Comma, PostComma, Error);
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