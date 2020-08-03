#region Imports

using System;

#endregion

namespace Conforyon
{
    public class Typography : Conforyon
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public string INCHtoCM(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= VariableLength && NumberCheck(Variable) == true && !Variable.StartsWith("0") && PostComma >= 0 && PostComma <= 99 && UseCheck(Variable))
                    return LastCheck2((Convert.ToInt64(Variable) * 2.54).ToString(), Decimal, Comma, PostComma, Error);
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1I2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public string INCHtoPX(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= VariableLength && NumberCheck(Variable) == true && !Variable.StartsWith("0") && PostComma >= 0 && PostComma <= 99 && UseCheck(Variable))
                {
                    string Sonuç = (Convert.ToInt64(Variable) * 2.54 * 37.79527559055118).ToString();
                    return LastCheck2(Sonuç, Decimal, Comma, PostComma, Error);
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1I3!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public string CMtoINCH(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= VariableLength && NumberCheck(Variable) == true && !Variable.StartsWith("0") && PostComma >= 0 && PostComma <= 99 && UseCheck(Variable))
                {
                    if (Convert.ToInt64(Variable) >= 3)
                        return LastCheck2((Convert.ToInt64(Variable) / 2.54).ToString(), Decimal, Comma, PostComma, Error);
                    else
                        return LastCheck2("0", Decimal, Comma, PostComma, Error);
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1C7!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public string CMtoPX(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= VariableLength && NumberCheck(Variable) == true && !Variable.StartsWith("0") && PostComma >= 0 && PostComma <= 99 && UseCheck(Variable))
                    return LastCheck2((Convert.ToInt64(Variable) * 37.79527559055118).ToString(), Decimal, Comma, PostComma, Error);
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1C8!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public string PXtoCM(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= VariableLength && NumberCheck(Variable) == true && !Variable.StartsWith("0") && PostComma >= 0 && PostComma <= 99 && UseCheck(Variable))
                {
                    if (Convert.ToInt64(Variable) >= 38)
                        return LastCheck2((Convert.ToInt64(Variable) / 37.79527559055118).ToString(), Decimal, Comma, PostComma, Error);
                    else
                        return LastCheck2("0", Decimal, Comma, PostComma, Error);
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1P!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public string PXtoINCH(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= VariableLength && NumberCheck(Variable) == true && !Variable.StartsWith("0") && PostComma >= 0 && PostComma <= 99 && UseCheck(Variable))
                {
                    if (Convert.ToInt64(Variable) >= 96)
                        return LastCheck2((Convert.ToInt64(Variable) / 37.79527559055118 / 2.54).ToString(), Decimal, Comma, PostComma, Error);
                    else
                        return LastCheck2("0", Decimal, Comma, PostComma, Error);
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1P2!)";
            }
        }
    }
}