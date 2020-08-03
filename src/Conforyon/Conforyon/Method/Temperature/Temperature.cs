#region Imports

using System;
using static Conforyon.Conforyon;

#endregion

namespace Conforyon
{
    public static class Temperature
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Text"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CtoF(string Variable, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= VariableLength && NumberCheck(Variable) == true && !Variable.StartsWith("0") && PostComma >= 0 && PostComma <= 99 && Check(Variable))
                {
                    if (Text == false)
                        return LastCheck2((Convert.ToDouble(Variable) * 9 / 5 + 32).ToString(), Decimal, Comma, PostComma, Error);
                    else
                        return LastCheck2((Convert.ToDouble(Variable) * 9 / 5 + 32).ToString(), Decimal, Comma, PostComma, Error) + " F";
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1C!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Text"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string FtoC(string Variable, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= VariableLength && NumberCheck(Variable) == true && !Variable.StartsWith("0") && PostComma >= 0 && PostComma <= 99 && Check(Variable))
                {
                    if (Convert.ToInt64(Variable) >= 32)
                    {
                        if (Text == false)
                            return LastCheck2(((Convert.ToDouble(Variable) - 32) * 5 / 9).ToString(), Decimal, Comma, PostComma, Error);
                        else
                            return LastCheck2(((Convert.ToDouble(Variable) - 32) * 5 / 9).ToString(), Decimal, Comma, PostComma, Error) + " C";
                    }
                    else
                    {
                        if (Text == false)
                            return LastCheck2("0", Decimal, Comma, PostComma, Error);
                        else
                            return LastCheck2("0", Decimal, Comma, PostComma, Error) + " C";
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1F!)";
            }
        }
    }
}