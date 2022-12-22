#region Imports

using CAA = Conforyon.Array.Arrays;
using CCC = Conforyon.Constant.Constants;
using CEEDT = Conforyon.Enum.Enums.DetectType;
using CEEIT = Conforyon.Enum.Enums.IntType;
using CEEST = Conforyon.Enum.Enums.SearchType;
using CHD = Conforyon.Helper.Detect;
using SC = System.Convert;
using SIOMS = System.IO.MemoryStream;
using SLE = System.Linq.Enumerable;
using SRSJDCJS = System.Runtime.Serialization.Json.DataContractJsonSerializer;
using SRSJDCJSS = System.Runtime.Serialization.Json.DataContractJsonSerializerSettings;
using STE = System.Text.Encoding;
using STRER = System.Text.RegularExpressions.Regex;

#endregion

// |---------DO-NOT-REMOVE---------|
//
//     Creator: Taiizor
//     Website: www.Vegalya.com
//     Created: 04.Jul.2019
//     Changed: 23.Dec.2022
//     Version: 2.0.0.4
//
// |---------DO-NOT-REMOVE---------|

namespace Conforyon
{
    #region Core

    /// <summary>
    /// 
    /// </summary>
    internal class Cores
    {
        #region Cores

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Spaces"></param>
        /// <returns></returns>
        public static bool TextControl(int Text, bool Spaces = false)
        {
            return TextControl($"{Text}", Spaces);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Spaces"></param>
        /// <returns></returns>
        public static bool TextControl(long Text, bool Spaces = false)
        {
            return TextControl($"{Text}", Spaces);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Spaces"></param>
        /// <returns></returns>
        public static bool TextControl(double Text, bool Spaces = false)
        {
            return TextControl($"{Text}", Spaces);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Spaces"></param>
        /// <returns></returns>
        public static bool TextControl(float Text, bool Spaces = false)
        {
            return TextControl($"{Text}", Spaces);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Spaces"></param>
        /// <returns></returns>
        public static bool TextControl(object Text, bool Spaces = false)
        {
            return TextControl($"{Text}", Spaces);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Spaces"></param>
        /// <returns></returns>
        public static bool TextControl(string Text, bool Spaces = false)
        {
            try
            {
                if (Text != "" && !string.IsNullOrEmpty(Text))
                {
                    if (Spaces)
                    {
                        return true;
                    }
                    else
                    {
                        if (Text.Contains(" ") || string.IsNullOrWhiteSpace(Text))
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    return false;
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
        /// <param name="Number"></param>
        /// <param name="Pass"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool NumberControl(int Number, bool Pass = false, CEEIT Type = CEEIT.Int64)
        {
            return NumberControl($"{Number}", Pass, Type);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Number"></param>
        /// <param name="Pass"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool NumberControl(long Number, bool Pass = false, CEEIT Type = CEEIT.Int64)
        {
            return NumberControl($"{Number}", Pass, Type);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Number"></param>
        /// <param name="Pass"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool NumberControl(double Number, bool Pass = false, CEEIT Type = CEEIT.Int64)
        {
            return NumberControl($"{Number}", Pass, Type);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Number"></param>
        /// <param name="Pass"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool NumberControl(float Number, bool Pass = false, CEEIT Type = CEEIT.Int64)
        {
            return NumberControl($"{Number}", Pass, Type);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Number"></param>
        /// <param name="Pass"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool NumberControl(object Number, bool Pass = false, CEEIT Type = CEEIT.Int64)
        {
            return NumberControl($"{Number}", Pass, Type);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Number"></param>
        /// <param name="Pass"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool NumberControl(string Number, bool Pass = false, CEEIT Type = CEEIT.Int64)
        {
            try
            {
                if (STRER.IsMatch(Number, "[^0-9]"))
                {
                    return false;
                }
                else
                {
                    if (Pass)
                    {
                        return true;
                    }
                    else
                    {
                        switch (Type)
                        {
                            case CEEIT.Int16:
                                SC.ToInt16(Number);
                                break;
                            case CEEIT.Int32:
                                SC.ToInt32(Number);
                                break;
                            case CEEIT.Int64:
                                SC.ToInt64(Number);
                                break;
                            case CEEIT.UInt16:
                                SC.ToUInt16(Number);
                                break;
                            case CEEIT.UInt32:
                                SC.ToUInt32(Number);
                                break;
                            case CEEIT.UInt64:
                                SC.ToUInt64(Number);
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
        /// <param name="Result"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string ResultFormat(int Result, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            return ResultFormat($"{Result}", Decimal, Comma, PostComma, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string ResultFormat(long Result, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            return ResultFormat($"{Result}", Decimal, Comma, PostComma, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string ResultFormat(double Result, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            return ResultFormat($"{Result}", Decimal, Comma, PostComma, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string ResultFormat(float Result, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            return ResultFormat($"{Result}", Decimal, Comma, PostComma, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string ResultFormat(object Result, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            return ResultFormat($"{Result}", Decimal, Comma, PostComma, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string ResultFormat(string Result, bool Decimal, bool Comma, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (string.IsNullOrEmpty(Result))
                {
                    return Error;
                }
                else
                {
                    if (SearchResult(Result, CAA.SymbolsCalc, CEEST.Contains))
                    {
                        if (SearchResult(Result, CAA.SymbolsMath, CEEST.Starts) && !SearchResult(Result, CAA.SymbolsDiff, CEEST.Contains))
                        {
                            string First = Result.Substring(0, 1);
                            string Last = Result.Substring(1, Result.Length - 1);

                            return $"{First}{ResultFormat(Last, Decimal, Comma, PostComma, Error)}";
                        }
                        else
                        {
                            return Result;
                        }
                    }
                    else
                    {
                        if (!Decimal && !Comma)
                        {
                            return RemoveResult(Result);
                        }
                        else if ((Decimal && !Comma) || (Decimal && Comma && PostComma <= 0))
                        {
                            Result = RemoveResult(Result);

                            if (Result.Length > 3)
                            {
                                return FormatResult(Result);
                            }
                            else
                            {
                                return Result;
                            }
                        }
                        else if (!Decimal && Comma && PostComma > 0)
                        {
                            string First = string.Empty;
                            string Second = string.Empty;

                            if (Result.Contains(CHD.String))
                            {
                                First = SLE.First(Result.Split(CHD.Char));
                                Second = SLE.Last(Result.Split(CHD.Char));
                            }
                            else
                            {
                                First = Result;
                            }

                            if (Second.Length < PostComma)
                            {
                                for (int Count = Second.Length; Count < PostComma; Count++)
                                {
                                    Second += "0";
                                }
                            }
                            else if (Second.Length > PostComma)
                            {
                                Second = Second.Substring(0, PostComma);
                            }

                            return $"{First}{CHD.Char}{Second}";
                        }
                        else if (!Decimal && Comma && PostComma <= 0)
                        {
                            return RemoveResult(Result);
                        }
                        else
                        {
                            string First = string.Empty;
                            string Second = string.Empty;

                            if (Result.Contains(CHD.String))
                            {
                                First = SLE.First(Result.Split(CHD.Char));
                                Second = SLE.Last(Result.Split(CHD.Char));
                            }
                            else
                            {
                                First = Result;
                            }

                            if (First.Length > 3)
                            {
                                First = FormatResult(First);
                            }

                            if (Second.Length < PostComma)
                            {
                                for (int Count = Second.Length; Count < PostComma; Count++)
                                {
                                    Second += "0";
                                }
                            }
                            else if (Second.Length > PostComma)
                            {
                                Second = Second.Substring(0, PostComma);
                            }

                            return $"{First}{CHD.Char}{Second}";
                        }
                    }
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "CN-RF1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <returns></returns>
        public static string RemoveResult(int Result)
        {
            return RemoveResult($"{Result}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <returns></returns>
        public static string RemoveResult(long Result)
        {
            return RemoveResult($"{Result}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <returns></returns>
        public static string RemoveResult(double Result)
        {
            return RemoveResult($"{Result}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <returns></returns>
        public static string RemoveResult(float Result)
        {
            return RemoveResult($"{Result}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <returns></returns>
        public static string RemoveResult(object Result)
        {
            return RemoveResult($"{Result}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <returns></returns>
        public static string RemoveResult(string Result)
        {
            return CHD.Enum switch
            {
                CEEDT.Dot or CEEDT.Comma => SLE.First(Result.Split(CHD.Char)),
                _ => Result,
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <returns></returns>
        public static string FormatResult(int Result)
        {
            return FormatResult($"{Result}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <returns></returns>
        public static string FormatResult(long Result)
        {
            return FormatResult($"{Result}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <returns></returns>
        public static string FormatResult(double Result)
        {
            return FormatResult($"{Result}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <returns></returns>
        public static string FormatResult(float Result)
        {
            return FormatResult($"{Result}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <returns></returns>
        public static string FormatResult(object Result)
        {
            return FormatResult($"{Result}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <returns></returns>
        public static string FormatResult(string Result)
        {
            string Temp = string.Empty;

            for (int Count = 0; Count < Result.Length; Count++)
            {
                if (Result.Substring(Count, Result.Length - Count - 1).Length % 3 == 0)
                {
                    if (CHD.Enum == CEEDT.Dot)
                    {
                        Temp += $"{Result.Substring(Count, 1)},";
                    }
                    else
                    {
                        Temp += $"{Result.Substring(Count, 1)}.";
                    }
                }
                else
                {
                    Temp += Result.Substring(Count, 1);
                }
            }

            return Temp.Substring(0, Temp.Length - 1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Words"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool SearchResult(int Text, string[] Words, CEEST Type = CEEST.Contains)
        {
            return SearchResult($"{Text}", Words, Type);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Words"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool SearchResult(long Text, string[] Words, CEEST Type = CEEST.Contains)
        {
            return SearchResult($"{Text}", Words, Type);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Words"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool SearchResult(double Text, string[] Words, CEEST Type = CEEST.Contains)
        {
            return SearchResult($"{Text}", Words, Type);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Words"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool SearchResult(float Text, string[] Words, CEEST Type = CEEST.Contains)
        {
            return SearchResult($"{Text}", Words, Type);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Words"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool SearchResult(object Text, string[] Words, CEEST Type = CEEST.Contains)
        {
            return SearchResult($"{Text}", Words, Type);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Words"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool SearchResult(string Text, string[] Words, CEEST Type = CEEST.Contains)
        {
            try
            {
                switch (Type)
                {
                    case CEEST.Starts:
                        if (Words.Length > 1)
                        {
                            foreach (string Letter in Words)
                            {
                                if (Text.StartsWith(Letter))
                                {
                                    return true;
                                }
                            }
                        }
                        else if (Text.StartsWith(Words[0]))
                        {
                            return true;
                        }

                        break;
                    case CEEST.Contains:
                        if (Words.Length > 1)
                        {
                            foreach (string Letter in Words)
                            {
                                if (Text.Contains(Letter))
                                {
                                    return true;
                                }
                            }
                        }
                        else if (Text.Contains(Words[0]))
                        {
                            return true;
                        }

                        break;
                    case CEEST.Ends:
                        if (Words.Length > 1)
                        {
                            foreach (string Letter in Words)
                            {
                                if (Text.EndsWith(Letter))
                                {
                                    return true;
                                }
                            }
                        }
                        else if (Text.EndsWith(Words[0]))
                        {
                            return true;
                        }

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
        /// <typeparam name="T"></typeparam>
        /// <param name="Data"></param>
        /// <returns></returns>
        public static string DataToJson<T>(T Data)
        {
            SIOMS MemoryStream = new();

            SRSJDCJS Serializer = new
            (
                Data.GetType(),
                new SRSJDCJSS()
                {
                    UseSimpleDictionaryFormat = true
                }
            );

            Serializer.WriteObject(MemoryStream, Data);

            return STE.UTF8.GetString(MemoryStream.ToArray());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="InputVariable"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Comma"></param>
        /// <param name="Mod"></param>
        /// <param name="Mod2"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string VariableFormat(int InputVariable, string Coefficient, bool Comma, bool Mod = false, bool Mod2 = false, string Error = CCC.ErrorMessage)
        {
            return VariableFormat($"{InputVariable}", Coefficient, Comma, Mod, Mod2, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="InputVariable"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Comma"></param>
        /// <param name="Mod"></param>
        /// <param name="Mod2"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string VariableFormat(long InputVariable, string Coefficient, bool Comma, bool Mod = false, bool Mod2 = false, string Error = CCC.ErrorMessage)
        {
            return VariableFormat($"{InputVariable}", Coefficient, Comma, Mod, Mod2, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="InputVariable"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Comma"></param>
        /// <param name="Mod"></param>
        /// <param name="Mod2"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string VariableFormat(double InputVariable, string Coefficient, bool Comma, bool Mod = false, bool Mod2 = false, string Error = CCC.ErrorMessage)
        {
            return VariableFormat($"{InputVariable}", Coefficient, Comma, Mod, Mod2, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="InputVariable"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Comma"></param>
        /// <param name="Mod"></param>
        /// <param name="Mod2"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string VariableFormat(float InputVariable, string Coefficient, bool Comma, bool Mod = false, bool Mod2 = false, string Error = CCC.ErrorMessage)
        {
            return VariableFormat($"{InputVariable}", Coefficient, Comma, Mod, Mod2, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="InputVariable"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Comma"></param>
        /// <param name="Mod"></param>
        /// <param name="Mod2"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string VariableFormat(object InputVariable, string Coefficient, bool Comma, bool Mod = false, bool Mod2 = false, string Error = CCC.ErrorMessage)
        {
            return VariableFormat($"{InputVariable}", Coefficient, Comma, Mod, Mod2, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="InputVariable"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Comma"></param>
        /// <param name="Mod"></param>
        /// <param name="Mod2"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string VariableFormat(string InputVariable, string Coefficient, bool Comma, bool Mod = false, bool Mod2 = false, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (Mod)
                {
                    if (Mod2)
                    {
                        return $"{SC.ToInt64(InputVariable) / SC.ToDouble(Coefficient)}";
                    }
                    else
                    {
                        return $"{SC.ToInt64(InputVariable) * SC.ToDouble(Coefficient)}";
                    }
                }
                else
                {
                    if (NumberControl(Coefficient))
                    {
                        string Variable1, Variable2, Variable3;

                        if (Comma)
                        {
                            if (Mod2)
                            {
                                Variable2 = $"{SC.ToInt64(InputVariable) / SC.ToDouble(Coefficient)}";
                                Variable3 = $"{SC.ToInt64(InputVariable) / SC.ToInt64(Coefficient)}";
                            }
                            else
                            {
                                Variable2 = $"{SC.ToInt64(InputVariable) * SC.ToDouble(Coefficient)}";
                                Variable3 = $"{SC.ToInt64(InputVariable) * SC.ToInt64(Coefficient)}";
                            }

                            if (SearchResult(Variable2, CAA.SymbolsCalc, CEEST.Contains))
                            {
                                if (SearchResult(Variable3, CAA.SymbolsMath, CEEST.Starts))
                                {
                                    Variable1 = Variable2;
                                }
                                else
                                {
                                    Variable1 = Variable3;
                                }
                            }
                            else if (SearchResult(Variable3, CAA.SymbolsMath, CEEST.Starts))
                            {
                                if (SearchResult(Variable2, CAA.SymbolsMath, CEEST.Starts))
                                {
                                    Variable1 = Variable3;
                                }
                                else
                                {
                                    Variable1 = Variable2;
                                }
                            }
                            else
                            {
                                Variable1 = Variable2;
                            }
                        }
                        else
                        {
                            if (Mod2)
                            {
                                Variable2 = $"{SC.ToInt64(InputVariable) / SC.ToDouble(Coefficient)}";
                                Variable3 = $"{SC.ToInt64(InputVariable) / SC.ToInt64(Coefficient)}";
                            }
                            else
                            {
                                Variable2 = $"{SC.ToInt64(InputVariable) * SC.ToDouble(Coefficient)}";
                                Variable3 = $"{SC.ToInt64(InputVariable) * SC.ToInt64(Coefficient)}";
                            }

                            if (SearchResult(Variable2, CAA.SymbolsCalc, CEEST.Contains))
                            {
                                if (SearchResult(Variable3, CAA.SymbolsMath, CEEST.Starts))
                                {
                                    Variable1 = Variable2;
                                }
                                else
                                {
                                    Variable1 = Variable3;
                                }
                            }
                            else if (SearchResult(Variable3, CAA.SymbolsMath, CEEST.Starts))
                            {
                                if (SearchResult(Variable3, CAA.SymbolsMath, CEEST.Starts))
                                {
                                    Variable1 = Variable2;
                                }
                                else
                                {
                                    Variable1 = Variable3;
                                }
                            }
                            else
                            {
                                Variable1 = Variable3;
                            }
                        }

                        if (string.IsNullOrEmpty(Variable1) || string.IsNullOrWhiteSpace(Variable1))
                        {
                            return Error;
                        }
                        else
                        {
                            return Variable1;
                        }
                    }
                    else
                    {
                        return Error;
                    }
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "CN-VF1!)";
            }
        }

        #endregion
    }

    #endregion
}