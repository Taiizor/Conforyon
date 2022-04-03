﻿#region Imports

using Conforyon.Array;
using Conforyon.Constant;
using Conforyon.Enum;
using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using CCC = Conforyon.Constant.Constants;
using CEEDT = Conforyon.Enum.Enums.DetectType;
using CHD = Conforyon.Helper.Detect;

#endregion

// |---------DO-NOT-REMOVE---------|
//
//     Creator: Taiizor
//     Website: www.Vegalya.com
//     Created: 04.Jul.2019
//     Changed: 03.Apr.2022
//     Version: 2.0.0.0
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
        public static bool NumberControl(int Number, bool Pass = false, Enums.IntType Type = Enums.IntType.Int64)
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
        public static bool NumberControl(string Number, bool Pass = false, Enums.IntType Type = Enums.IntType.Int64)
        {
            try
            {
                if (Regex.IsMatch(Number, "[^0-9]"))
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
                            case Enums.IntType.Int16:
                                Convert.ToInt16(Number);
                                break;
                            case Enums.IntType.Int32:
                                Convert.ToInt32(Number);
                                break;
                            case Enums.IntType.Int64:
                                Convert.ToInt64(Number);
                                break;
                            case Enums.IntType.UInt16:
                                Convert.ToUInt16(Number);
                                break;
                            case Enums.IntType.UInt32:
                                Convert.ToUInt32(Number);
                                break;
                            case Enums.IntType.UInt64:
                                Convert.ToUInt64(Number);
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
        public static string ResultFormat(double Result, bool Decimal, bool Comma, int PostComma = 0, string Error = Constants.ErrorMessage)
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
        public static string ResultFormat(float Result, bool Decimal, bool Comma, int PostComma = 0, string Error = Constants.ErrorMessage)
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
        public static string ResultFormat(int Result, bool Decimal, bool Comma, int PostComma = 0, string Error = Constants.ErrorMessage)
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
        public static string ResultFormat(string Result, bool Decimal, bool Comma, int PostComma = 0, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (string.IsNullOrEmpty(Result))
                {
                    return Error;
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

                        switch (CHD.Enum)
                        {
                            case CEEDT.Dot or CEEDT.Comma:
                                First = Result.Split(CHD.Char).First();
                                Second = Result.Split(CHD.Char).Last();
                                break;
                            default:
                                First = Result;
                                break;
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

                        switch (CHD.Enum)
                        {
                            case CEEDT.Dot or CEEDT.Comma:
                                First = Result.Split(CHD.Char).First();
                                Second = Result.Split(CHD.Char).Last();
                                break;
                            default:
                                First = Result;
                                break;
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
        public static string RemoveResult(string Result)
        {
            return CHD.Enum switch
            {
                CEEDT.Dot or CEEDT.Comma => Result.Split(CHD.Char).First(),
                _ => Result,
            };
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
                        Temp += Result.Substring(Count, 1) + ",";
                    }
                    else
                    {
                        Temp += Result.Substring(Count, 1) + ".";
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
        /// <typeparam name="T"></typeparam>
        /// <param name="Data"></param>
        /// <returns></returns>
        public static string DataToJson<T>(T Data)
        {
            MemoryStream MemoryStream = new();

            DataContractJsonSerializer Serializer = new
            (
                Data.GetType(),
                new DataContractJsonSerializerSettings()
                {
                    UseSimpleDictionaryFormat = true
                }
            );

            Serializer.WriteObject(MemoryStream, Data);

            return Encoding.UTF8.GetString(MemoryStream.ToArray());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Words"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool Searching(string Text, string[] Words, Enums.SearchType Type = Enums.SearchType.Contains)
        {
            try
            {
                switch (Type)
                {
                    case Enums.SearchType.Starts:
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
                    case Enums.SearchType.Contains:
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
                    case Enums.SearchType.Ends:
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
        /// <param name="InputVariable"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Comma"></param>
        /// <param name="Mod"></param>
        /// <param name="Mod2"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string VariableFormat(string InputVariable, string Coefficient, bool Comma, bool Mod = false, bool Mod2 = false, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Mod)
                {
                    if (Mod2)
                    {
                        return (Convert.ToInt64(InputVariable) / Convert.ToDouble(Coefficient)).ToString();
                    }
                    else
                    {
                        return (Convert.ToInt64(InputVariable) * Convert.ToDouble(Coefficient)).ToString();
                    }
                }
                else
                {
                    if (NumberControl(Coefficient.ToString()))
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

                            if (Searching(Variable2, Arrays.SymbolsCalc, Enums.SearchType.Contains))
                            {
                                if (Searching(Variable3, Arrays.SymbolsMath, Enums.SearchType.Starts))
                                {
                                    Variable1 = Variable2;
                                }
                                else
                                {
                                    Variable1 = Variable3;
                                }
                            }
                            else if (Searching(Variable3, Arrays.SymbolsMath, Enums.SearchType.Starts))
                            {
                                if (Searching(Variable2, Arrays.SymbolsMath, Enums.SearchType.Starts))
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
                                Variable2 = (Convert.ToInt64(InputVariable) / Convert.ToDouble(Coefficient)).ToString();
                                Variable3 = (Convert.ToInt64(InputVariable) / Convert.ToInt64(Coefficient)).ToString();
                            }
                            else
                            {
                                Variable2 = (Convert.ToInt64(InputVariable) * Convert.ToDouble(Coefficient)).ToString();
                                Variable3 = (Convert.ToInt64(InputVariable) * Convert.ToInt64(Coefficient)).ToString();
                            }

                            if (Searching(Variable2, Arrays.SymbolsCalc, Enums.SearchType.Contains))
                            {
                                if (Searching(Variable3, Arrays.SymbolsMath, Enums.SearchType.Starts))
                                {
                                    Variable1 = Variable2;
                                }
                                else
                                {
                                    Variable1 = Variable3;
                                }
                            }
                            else if (Searching(Variable3, Arrays.SymbolsMath, Enums.SearchType.Starts))
                            {
                                if (Searching(Variable3, Arrays.SymbolsMath, Enums.SearchType.Starts))
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
                return Error + Constants.ErrorTitle + "CN-VF1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string UseDecimal(string Variable, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Searching(Variable, Arrays.SymbolsCalc))
                {
                    return Variable;
                }
                else
                {
                    if (Variable.Contains(","))
                    {
                        char[] Brackets = { ',', '.' };
                        string[] Variables = Variable.Split(Brackets);
                        string Result = string.Format("{0:0,0}", Convert.ToInt64(Variables[0]));
                        if (Result.Length == 2 && Result == "00")
                        {
                            Result = "0";
                        }
                        else if (Result.Length == 2 && Result.StartsWith("0") && !Result.EndsWith("0"))
                        {
                            Result = Result.Replace("0", "");
                        }

                        return Result + "," + Variables[1];
                    }
                    else
                    {
                        if (Variable.Length > 2)
                        {
                            if (NumberControl(Variable))
                            {
                                return string.Format("{0:0,0}", Convert.ToInt64(Variable));
                            }
                            else
                            {
                                return string.Format("{0:0,0}", Variable);
                            }
                        }
                        else
                        {
                            return Variable;
                        }
                    }
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "CN-UD1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string UseDecimal2(string Variable, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Searching(Variable, Arrays.SymbolsCalc))
                {
                    return Variable;
                }
                else
                {
                    if (Variable.Contains(","))
                    {
                        char[] Brackets = { ',' };
                        string[] Variables = Variable.Split(Brackets);
                        string Result = string.Format("{0:0,0}", Convert.ToInt64(Variables[0]));
                        if (Result.Length == 2 && Result == "00")
                        {
                            return "0";
                        }
                        else if (Result.Length == 2 && Result.StartsWith("0") && !Result.EndsWith("0"))
                        {
                            return Result.Replace("0", "");
                        }
                        else
                        {
                            return Result;
                        }
                    }
                    else
                    {
                        if (Variable.Length > 2)
                        {
                            if (NumberControl(Variable))
                            {
                                return string.Format("{0:0,0}", Convert.ToInt64(Variable));
                            }
                            else
                            {
                                return string.Format("{0:0,0}", Variable);
                            }
                        }
                        else
                        {
                            return Variable;
                        }
                    }
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "CN-UD2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string UseComma(string Variable, int PostComma = 0, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Searching(Variable, Arrays.SymbolsCalc))
                {
                    return Variable;
                }
                else
                {
                    if (Variable.Contains(",") && PostComma != 0)
                    {
                        char[] Brackets = { ',' };
                        string[] Variables = Variable.Split(Brackets);
                        if (PostComma <= Variables[1].Length)
                        {
                            return Variables[0] + "," + Variables[1].Substring(0, PostComma);
                        }
                        else
                        {
                            string Operation = Variables[0] + "," + Variables[1].Substring(0, Variables[1].Length);
                            int Operation2 = PostComma - Variables[1].Length;
                            for (int i = 0; i < Operation2; i++)
                            {
                                Operation += "0";
                            }

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
                            {
                                Operation += "0";
                            }

                            return Variable + Operation;
                        }
                    }
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "CN-UC1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string UseComma2(string Variable, int PostComma = 0, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Searching(Variable, Arrays.SymbolsCalc))
                {
                    return Variable;
                }
                else
                {
                    if (PostComma <= Variable.Length)
                    {
                        if (Variable == ",")
                        {
                            return Variable.Substring(0, PostComma) + "0";
                        }
                        else
                        {
                            return Variable.Substring(0, PostComma);
                        }
                    }
                    else
                    {
                        string Operation = Variable.Substring(0, Variable.Length);
                        int Operation2 = PostComma - Variable.Length;
                        if (Variable == ",")
                        {
                            for (int i = 0; i <= Operation2; i++)
                            {
                                Operation += "0";
                            }
                        }
                        else
                        {
                            for (int i = 0; i < Operation2; i++)
                            {
                                Operation += "0";
                            }
                        }

                        return Operation;
                    }
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "CN-UC2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string DecimalComma(string Variable, int PostComma = 0, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Searching(Variable, Arrays.SymbolsCalc))
                {
                    return Variable;
                }
                else
                {
                    if (PostComma == 0)
                    {
                        return UseDecimal2(Variable);
                    }
                    else
                    {
                        if (Variable.Contains(","))
                        {
                            char[] Brackets = { ',' };
                            string[] Variables = Variable.Split(Brackets);
                            return UseDecimal2(Variables[0]) + "," + UseComma2(Variables[1], PostComma);
                        }
                        else
                        {
                            return UseDecimal2(Variable) + UseComma2(",", PostComma);
                        }
                    }
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "CN-DC1!)";
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
        public static string LastCheck(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (!Decimal && !Comma)
                {
                    if (string.IsNullOrEmpty(Variable))
                    {
                        return Error;
                    }
                    else
                    {
                        return Variable;
                    }
                }
                else
                {
                    if (Decimal && !Comma)
                    {
                        return UseDecimal(Variable);
                    }
                    else if (!Decimal && Comma)
                    {
                        return UseComma(Variable, PostComma);
                    }
                    else
                    {
                        return DecimalComma(Variable, PostComma);
                    }
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "CN-LC1!)";
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
        public static string LastCheck2(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (!Decimal && !Comma)
                {
                    if (string.IsNullOrEmpty(Variable))
                    {
                        return Error;
                    }
                    else
                    {
                        return LastCheck(Variable, false, true, 0, Error);
                    }
                }
                else
                {
                    if (Decimal && !Comma)
                    {
                        return LastCheck(Variable, true, true, 0, Error);
                    }
                    else if (!Decimal && Comma)
                    {
                        return LastCheck(Variable, false, true, PostComma, Error);
                    }
                    else
                    {
                        return DecimalComma(Variable, PostComma);
                    }
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "CN-LC2!)";
            }
        }

        #endregion
    }

    #endregion
}