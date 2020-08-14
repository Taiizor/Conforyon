#region Imports

using System;
using System.Text.RegularExpressions;

#endregion

// |---------DO-NOT-REMOVE---------|
//
//     Creator: Taiizor
//     Site   : www.Taiizor.com
//     Created: 04.Jul.2019
//     Changed: 14.Aug.2020
//     Version: 1.4.7.2
//
// |---------DO-NOT-REMOVE---------|

namespace Conforyon
{
    public static class Conforyon
    {
        #region Variables
        /// <summary>
        /// 
        /// </summary>
        public const string ErrorTitle = " (CN-";

        /// <summary>
        /// 
        /// </summary>
        public const string ErrorMessage = "Error!";

        /// <summary>
        /// 
        /// </summary>
        public const string EmptyMessage = "Empty!";

        /// <summary>
        /// 
        /// </summary>
        public const int VariableLength = 15;

        /// <summary>
        /// 
        /// </summary>
        public const int TextLength = 32767;
        #endregion

        #region Enums
        /// <summary>
        /// 
        /// </summary>
        public enum ColorType
        {
            RGB1,
            RGB2,
            RGB3,
            RRGGBB1,
            RRGGBB2,
            RRGGBB3,
            RR,
            GG,
            BB,
            OnlyR,
            OnlyG,
            OnlyB
        }

        /// <summary>
        /// 
        /// </summary>
        public enum HashType
        {
            MD5,
            SHA1,
            SHA256,
            SHA384,
            SHA512
        }

        /// <summary>
        /// 
        /// </summary>
        public enum LengthType
        {
            MM,
            CM,
            DM,
            M,
            DAM,
            HM,
            KM,
        }

        /// <summary>
        /// 
        /// </summary>
        public enum SpeedType
        {
            MPH,
            KMH
        }

        /// <summary>
        /// 
        /// </summary>
        public enum StorageType
        {
            Bit,
            Byte,
            KB,
            MB,
            GB,
            TB,
            PB,
            EB,
            ZB,
            YB
        }

        /// <summary>
        /// 
        /// </summary>
        public enum TimeType
        {
            Millisecond,
            Second,
            Minute,
            Hour,
            Day,
            Week
        }

        /// <summary>
        /// 
        /// </summary>
        public enum WeightType
        {
            Milligram,
            Gram,
            KG
        }

        /// <summary>
        /// 
        /// </summary>
        public enum IntType
        {
            Int16,
            Int32,
            Int64,
            UInt16,
            UInt32,
            UInt64
        }

        /// <summary>
        /// 
        /// </summary>
        public enum SearchType
        {
            Starts,
            Contains,
            Ends
        }
        #endregion

        #region Arrays
        /// <summary>
        /// 
        /// </summary>
        public static readonly string[] SymbolsMath = {
            "-",
            "+"
        };

        /// <summary>
        /// 
        /// </summary>
        public static readonly string[] SymbolsCalc = {
            "E",
            "B",
            "+",
            "-"
        };
        #endregion

        #region Cores
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="TypePass"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool NumberCheck(string Variable, bool TypePass = false, IntType Type = IntType.Int64)
        {
            try
            {
                if (Regex.IsMatch(Variable, "[^0-9]"))
                    return false;
                else
                {
                    if (TypePass)
                        return true;
                    else
                    {
                        switch (Type)
                        {
                            case IntType.Int16:
                                Convert.ToInt16(Variable);
                                break;
                            case IntType.Int32:
                                Convert.ToInt32(Variable);
                                break;
                            case IntType.Int64:
                                Convert.ToInt64(Variable);
                                break;
                            case IntType.UInt16:
                                Convert.ToUInt16(Variable);
                                break;
                            case IntType.UInt32:
                                Convert.ToUInt32(Variable);
                                break;
                            case IntType.UInt64:
                                Convert.ToUInt64(Variable);
                                break;
                            default:
                                return false;
                        }
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Words"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool Searching(string Text, string[] Words, SearchType Type = SearchType.Contains)
        {
            try
            {
                switch (Type)
                {
                    case SearchType.Starts:
                        if (Words.Length > 1)
                        {
                            foreach (string Letter in Words)
                                if (Text.StartsWith(Letter)) return true;
                        }
                        else if (Text.StartsWith(Words[0]))
                            return true;
                        break;
                    case SearchType.Contains:
                        if (Words.Length > 1)
                        {
                            foreach (string Letter in Words)
                                if (Text.Contains(Letter)) return true;
                        }
                        else if (Text.Contains(Words[0]))
                            return true;
                        break;
                    case SearchType.Ends:
                        if (Words.Length > 1)
                        {
                            foreach (string Letter in Words)
                                if (Text.EndsWith(Letter)) return true;
                        }
                        else if (Text.EndsWith(Words[0]))
                            return true;
                        break;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="InputVariable"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Comma"></param>
        /// <param name="Error"></param>
        /// <param name="Mod"></param>
        /// <param name="Mod2"></param>
        /// <returns></returns>
        public static string VariableFormat(string InputVariable, string Coefficient, bool Comma, string Error = ErrorMessage, bool Mod = false, bool Mod2 = false)
        {
            try
            {
                if (!Mod)
                {
                    if (NumberCheck(Coefficient.ToString()))
                    {
                        string Variable1, Variable2, Variable3;
                        if (Comma)
                        {
                            if (Mod2)
                            {
                                Variable2 = (Convert.ToInt64(InputVariable) / Convert.ToDouble(Coefficient)).ToString();
                                Variable3 = (Convert.ToInt64(InputVariable) / Convert.ToInt64(Coefficient)).ToString();
                            }
                            else
                            {
                                Variable2 = (Convert.ToInt64(InputVariable) * Convert.ToDouble(Coefficient)).ToString();
                                Variable3 = (Convert.ToInt64(InputVariable) * Convert.ToInt64(Coefficient)).ToString();
                            }

                            if (Searching(Variable2, SymbolsCalc, SearchType.Contains))
                            {
                                if (Searching(Variable3, SymbolsMath, SearchType.Starts))
                                    Variable1 = Variable2;
                                else
                                    Variable1 = Variable3;
                            }
                            else if (Searching(Variable3, SymbolsMath, SearchType.Starts))
                            {
                                if (Searching(Variable3, SymbolsMath, SearchType.Starts))
                                    Variable1 = Variable2;
                                else
                                    Variable1 = Variable3;
                            }
                            else
                                Variable1 = Variable2;
                        }
                        else
                        {
                            if (Mod2)
                            {
                                Variable2 = (Convert.ToInt64(InputVariable) / Convert.ToDouble(Coefficient)).ToString();
                                Variable3 = (Convert.ToInt64(InputVariable) / Convert.ToInt64(Coefficient)).ToString();
                            }
                            else
                            {
                                Variable2 = (Convert.ToInt64(InputVariable) * Convert.ToDouble(Coefficient)).ToString();
                                Variable3 = (Convert.ToInt64(InputVariable) * Convert.ToInt64(Coefficient)).ToString();
                            }

                            if (Searching(Variable2, SymbolsCalc, SearchType.Contains))
                            {
                                if (Searching(Variable3, SymbolsMath, SearchType.Starts))
                                    Variable1 = Variable2;
                                else
                                    Variable1 = Variable3;
                            }
                            else if (Searching(Variable3, SymbolsMath, SearchType.Starts))
                            {
                                if (Searching(Variable3, SymbolsMath, SearchType.Starts))
                                    Variable1 = Variable2;
                                else
                                    Variable1 = Variable3;
                            }
                            else
                                Variable1 = Variable3;
                        }
                        if (string.IsNullOrEmpty(Variable1) || string.IsNullOrWhiteSpace(Variable1))
                            return Error;
                        else
                            return Variable1;
                    }
                    else
                        return Error;
                }
                else
                {
                    if (Mod2)
                        return (Convert.ToInt64(InputVariable) / Convert.ToDouble(Coefficient)).ToString();
                    else
                        return (Convert.ToInt64(InputVariable) * Convert.ToDouble(Coefficient)).ToString();
                }
            }
            catch
            {
                return Error + ErrorTitle + "CN-VF1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string UseDecimal(string Variable, string Error = ErrorMessage)
        {
            try
            {
                if (Searching(Variable, SymbolsCalc))
                    return Variable;
                else
                {
                    if (Variable.Contains(","))
                    {
                        char[] Brackets = { ',', '.' };
                        string[] Variables = Variable.Split(Brackets);
                        string Result = string.Format("{0:0,0}", Convert.ToInt64(Variables[0]));
                        if (Result.Length == 2 && Result == "00")
                            Result = "0";
                        else if (Result.Length == 2 && Result.StartsWith("0") && !Result.EndsWith("0"))
                            Result.Replace("0", "");
                        return Result + "," + Variables[1];
                    }
                    else
                    {
                        if (Variable.Length > 2)
                        {
                            if (NumberCheck(Variable))
                                return string.Format("{0:0,0}", Convert.ToInt64(Variable));
                            else
                                return string.Format("{0:0,0}", Variable);
                        }
                        else
                            return Variable;
                    }
                }
            }
            catch
            {
                return Error + ErrorTitle + "CN-UD1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string UseDecimal2(string Variable, string Error = ErrorMessage)
        {
            try
            {
                if (Searching(Variable, SymbolsCalc))
                    return Variable;
                else
                {
                    if (Variable.Contains(","))
                    {
                        char[] Brackets = { ',' };
                        string[] Variables = Variable.Split(Brackets);
                        string Result = string.Format("{0:0,0}", Convert.ToInt64(Variables[0]));
                        if (Result.Length == 2 && Result == "00")
                            return "0";
                        else if (Result.Length == 2 && Result.StartsWith("0") && !Result.EndsWith("0"))
                            return Result.Replace("0", "");
                        else
                            return Result;
                    }
                    else
                    {
                        if (Variable.Length > 2)
                        {
                            if (NumberCheck(Variable))
                                return string.Format("{0:0,0}", Convert.ToInt64(Variable));
                            else
                                return string.Format("{0:0,0}", Variable);
                        }
                        else
                            return Variable;
                    }
                }
            }
            catch
            {
                return Error + ErrorTitle + "CN-UD2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string UseComma(string Variable, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Searching(Variable, SymbolsCalc))
                    return Variable;
                else
                {
                    if (Variable.Contains(",") && PostComma != 0)
                    {
                        char[] Brackets = { ',' };
                        string[] Variables = Variable.Split(Brackets);
                        if (PostComma <= Variables[1].Length)
                            return Variables[0] + "," + Variables[1].Substring(0, PostComma);
                        else
                        {
                            string Operation = Variables[0] + "," + Variables[1].Substring(0, Variables[1].Length);
                            int Operation2 = PostComma - Variables[1].Length;
                            for (int i = 0; i < Operation2; i++)
                                Operation += "0";
                            return Operation;
                        }
                    }
                    else
                    {
                        if (PostComma == 0)
                        {
                            char[] Brackets = { ',' };
                            string[] Variables = Variable.Split(Brackets);
                            return Variables[0];
                        }
                        else
                        {
                            string Operation = ",";
                            for (int i = 0; i < PostComma; i++)
                                Operation += "0";
                            return Variable + Operation;
                        }
                    }
                }
            }
            catch
            {
                return Error + ErrorTitle + "CN-UC1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string UseComma2(string Variable, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Searching(Variable, SymbolsCalc))
                    return Variable;
                else
                {
                    if (PostComma <= Variable.Length)
                    {
                        if (Variable == ",")
                            return Variable.Substring(0, PostComma) + "0";
                        else
                            return Variable.Substring(0, PostComma);
                    }
                    else
                    {
                        string Operation = Variable.Substring(0, Variable.Length);
                        int Operation2 = PostComma - Variable.Length;
                        if (Variable == ",")
                            for (int i = 0; i <= Operation2; i++) Operation += "0";
                        else
                            for (int i = 0; i < Operation2; i++) Operation += "0";
                        return Operation;
                    }
                }
            }
            catch
            {
                return Error + ErrorTitle + "CN-UC2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string DecimalComma(string Variable, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Searching(Variable, SymbolsCalc))
                    return Variable;
                else
                {
                    if (PostComma == 0)
                        return UseDecimal2(Variable);
                    else
                    {
                        if (Variable.Contains(","))
                        {
                            char[] Brackets = { ',' };
                            string[] Variables = Variable.Split(Brackets);
                            return UseDecimal2(Variables[0]) + "," + UseComma2(Variables[1], PostComma);
                        }
                        else
                            return UseDecimal2(Variable) + UseComma2(",", PostComma);
                    }
                }
            }
            catch
            {
                return Error + ErrorTitle + "CN-DC1!)";
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
        public static string LastCheck(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (!Decimal && !Comma)
                {
                    if (string.IsNullOrEmpty(Variable))
                        return Error;
                    else
                        return Variable;
                }
                else
                {
                    if (Decimal && !Comma)
                        return UseDecimal(Variable);
                    else if (!Decimal && Comma)
                        return UseComma(Variable, PostComma);
                    else
                        return DecimalComma(Variable, PostComma);
                }
            }
            catch
            {
                return Error + ErrorTitle + "CN-LC1!)";
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
        public static string LastCheck2(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (!Decimal && !Comma)
                {
                    if (string.IsNullOrEmpty(Variable))
                        return Error;
                    else
                        return LastCheck(Variable, false, true, 0, Error);
                }
                else
                {
                    if (Decimal && !Comma)
                        return LastCheck(Variable, true, true, 0, Error);
                    else if (!Decimal && Comma)
                        return LastCheck(Variable, false, true, PostComma, Error);
                    else
                        return DecimalComma(Variable, PostComma);
                }
            }
            catch
            {
                return Error + ErrorTitle + "CN-LC2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Spaces"></param>
        /// <returns></returns>
        public static bool UseCheck(string Variable, bool Spaces = false)
        {
            try
            {
                if (Variable != "" && !string.IsNullOrEmpty(Variable))
                {
                    if (Spaces)
                        return true;
                    else
                    {
                        if (Variable.Contains(" ") || string.IsNullOrWhiteSpace(Variable))
                            return false;
                        else
                            return true;
                    }
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}