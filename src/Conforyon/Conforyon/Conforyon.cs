#region Imports

using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

#endregion

// |---------DO-NOT-REMOVE---------|
//
//     Creator: Taiizor
//     Site   : www.Taiizor.com
//     Created: 04.Jul.2019
//     Changed: 03.Aug.2020
//     Version: 1.3.8.9
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
        private const string ErrorTitle = " (CN-LY";

        /// <summary>
        /// 
        /// </summary>
        private const string ErrorMessage = "Error!";

        /// <summary>
        /// 
        /// </summary>
        private const int VariableLength = 15;
        #endregion

        #region Enums
        /// <summary>
        /// 
        /// </summary>
        public static readonly string[] SizeTypes = {
            "Bit",
            "Byte",
            "KB",
            "MB",
            "GB",
            "TB",
            "PB",
            "EB",
            "ZB",
            "YB"
        };

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

        #region Functions

        #region Publics
        /// <summary>
        /// 
        /// </summary>
        /// <param name="InputVariable"></param>
        /// <param name="InputType"></param>
        /// <param name="TypeText"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="CommaSonrası"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string OtoVariableÇevir(string InputVariable, string InputType, bool TypeText = false, bool Decimal = false, bool Comma = false, int CommaSonrası = 0, string Error = ErrorMessage)
        {
            try
            {
                if (InputVariable.Length <= VariableLength && Array.IndexOf(SizeTypes, InputType) >= 0 && CommaSonrası >= 0 && CommaSonrası <= 99 && !Regex.IsMatch(InputVariable, "[^0-9]") && !InputVariable.StartsWith("0") && Check(InputVariable) && Check(InputType))
                {
                    string Tür = null;
                    if (InputType == SizeTypes[SizeTypes.Length - 1])
                        Tür = SizeTypes[SizeTypes.Length - 1];
                    else
                    {
                        for (int i = Array.IndexOf(SizeTypes, InputType); i < SizeTypes.Length; i++)
                        {
                            if (VariableÇevir(InputVariable, InputType, SizeTypes[i], false, false, 0, Error) == "0")
                            {
                                Tür = SizeTypes[i - 1];
                                break;
                            }
                            else
                            {
                                if (SizeTypes[i] == SizeTypes[SizeTypes.Length - 1])
                                    Tür = SizeTypes[i];
                            }
                        }
                    }
                    if (string.IsNullOrEmpty(Tür))
                        return Error;
                    else
                    {
                        if (InputType != Tür)
                        {
                            string Sonuç = VariableÇevir(InputVariable, InputType, Tür, Decimal, Comma, CommaSonrası, Error);
                            if (TypeText == false || Sonuç == Error)
                                return Sonuç;
                            else
                                return Sonuç + " " + Tür;
                        }
                        else
                        {
                            string Sonuç = null;
                            if (Decimal == false && Comma == false)
                                Sonuç = InputVariable;
                            else
                            {
                                if (Decimal == true && Comma == false)
                                    Sonuç = Conforyon.Decimal(InputVariable);
                                else if (Decimal == false && Comma == true)
                                    Sonuç = Conforyon.Comma(InputVariable, CommaSonrası);
                                else
                                    Sonuç = DecimalComma(InputVariable, CommaSonrası);
                            }
                            if (TypeText == false)
                                return Sonuç;
                            else
                                return Sonuç + " " + Tür;
                        }
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1O!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="InputVariable"></param>
        /// <param name="InputType"></param>
        /// <param name="TypeConvert"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="CommaSonrası"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string VariableÇevir(string InputVariable, string InputType, string TypeConvert, bool Decimal = false, bool Comma = false, int CommaSonrası = 0, string Error = ErrorMessage)
        {
            try
            {
                string Variable;
                if (InputVariable.Length <= VariableLength && Array.IndexOf(SizeTypes, InputType) >= 0 && Array.IndexOf(SizeTypes, TypeConvert) >= 0 && CommaSonrası >= 0 && CommaSonrası <= 99 && !Regex.IsMatch(InputVariable, "[^0-9]") && !InputVariable.StartsWith("0") && Check(InputVariable) && Check(InputType) && Check(TypeConvert))
                {
                    if (InputType == "Bit")
                    {
                        if (TypeConvert == InputType)
                            return LastCheck(InputVariable, Decimal, Comma, CommaSonrası, Error);
                        else
                        {
                            if (TypeConvert == "Byte")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "8", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "KB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "8192", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "MB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "8388608", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "GB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "8589934592", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "TB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "8796093022208", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "PB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "9007199254740992", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "EB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, (8796093022208 * 2048).ToString(), Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "ZB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, (8796093022208 * 3072).ToString(), Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "YB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, (8796093022208 * 4096).ToString(), Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else
                                return Error;
                            return LastCheck(Variable, Decimal, Comma, CommaSonrası, Error);
                        }
                    }
                    else if (InputType == "Byte")
                    {
                        if (TypeConvert == InputType)
                            return LastCheck(InputVariable, Decimal, Comma, CommaSonrası, Error);
                        else
                        {
                            if (TypeConvert == "Bit")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "8", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "KB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1024", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "MB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1048576", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "GB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1073741824", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "TB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1099511627776", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "PB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1125899906842624", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "EB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1152921504606846976", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "ZB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, (1125899906842624 * 2048).ToString(), Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "YB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, (1125899906842624 * 3072).ToString(), Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else
                                return Error;
                            return LastCheck(Variable, Decimal, Comma, CommaSonrası, Error);
                        }
                    }
                    else if (InputType == "KB")
                    {
                        if (TypeConvert == InputType)
                            return LastCheck(InputVariable, Decimal, Comma, CommaSonrası, Error);
                        else
                        {
                            if (TypeConvert == "Bit")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "8192", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "Byte")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1024", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "MB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1024", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "GB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1048576", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "TB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1073741824", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "PB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1099511627776", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "EB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1125899906842624", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "ZB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1152921504606846976", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "YB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, (1125899906842624 * 2048).ToString(), Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else
                                return Error;
                            return LastCheck(Variable, Decimal, Comma, CommaSonrası, Error);
                        }
                    }
                    else if (InputType == "MB")
                    {
                        if (TypeConvert == InputType)
                            return LastCheck(InputVariable, Decimal, Comma, CommaSonrası, Error);
                        else
                        {
                            if (TypeConvert == "Bit")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "8388608", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "Byte")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1048576", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "KB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1024", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "GB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1024", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "TB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1048576", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "PB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1073741824", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "EB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1099511627776", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "ZB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1125899906842624", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "YB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1152921504606847000", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else
                                return Error;
                            return LastCheck(Variable, Decimal, Comma, CommaSonrası, Error);
                        }
                    }
                    else if (InputType == "GB")
                    {
                        if (TypeConvert == InputType)
                            return LastCheck(InputVariable, Decimal, Comma, CommaSonrası, Error);
                        else
                        {
                            if (TypeConvert == "Bit")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "8589934592", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "Byte")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1073741824", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "KB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1048576", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "MB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1024", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "TB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1024", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "PB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1048576", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "EB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1073741824", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "ZB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1099511627776", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "YB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1125899906842624", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else
                                return Error;
                            return LastCheck(Variable, Decimal, Comma, CommaSonrası, Error);
                        }
                    }
                    else if (InputType == "TB")
                    {
                        if (TypeConvert == InputType)
                            return LastCheck(InputVariable, Decimal, Comma, CommaSonrası, Error);
                        else
                        {
                            if (TypeConvert == "Bit")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "8796093022208", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "Byte")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1099511627776", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "KB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1073741824", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "MB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1048576", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "GB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1024", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "PB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1024", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "EB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1048576", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "ZB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1073741824", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "YB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1099511627776", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else
                                return Error;
                            return LastCheck(Variable, Decimal, Comma, CommaSonrası, Error);
                        }
                    }
                    else if (InputType == "PB")
                    {
                        if (TypeConvert == InputType)
                            return LastCheck(InputVariable, Decimal, Comma, CommaSonrası, Error);
                        else
                        {
                            if (TypeConvert == "Bit")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "9007199254740992", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "Byte")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1125899906842624", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "KB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1099511627776", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "MB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1073741824", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "GB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1048576", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "TB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1024", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "EB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1024", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "ZB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1048576", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "YB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1073741824", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else
                                return Error;
                            return LastCheck(Variable, Decimal, Comma, CommaSonrası, Error);
                        }
                    }
                    else if (InputType == "EB")
                    {
                        if (TypeConvert == InputType)
                            return LastCheck(InputVariable, Decimal, Comma, CommaSonrası, Error);
                        else
                        {
                            if (TypeConvert == "Bit")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "9223372036854775808", Comma, Error, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "Byte")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1152921504606846976", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "KB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1125899906842624", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "MB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1099511627776", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "GB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1073741824", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "TB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1048576", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "PB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1024", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "ZB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1024", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "YB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1048576", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else
                                return Error;
                            return LastCheck(Variable, Decimal, Comma, CommaSonrası, Error);
                        }
                    }
                    else if (InputType == "ZB")
                    {
                        if (TypeConvert == InputType)
                            return LastCheck(InputVariable, Decimal, Comma, CommaSonrası, Error);
                        else
                        {
                            if (TypeConvert == "Bit")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "9444732965739290427392", Comma, Error, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "Byte")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1180591620717411303424", Comma, Error, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "KB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1152921504606846976", Comma, Error, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "MB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1125899906842624", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "GB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1099511627776", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "TB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1073741824", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "PB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1048576", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "EB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1024", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "YB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1024", Comma, Error, false, true);
                                else
                                    return Error;
                            }
                            else
                                return Error;
                            return LastCheck(Variable, Decimal, Comma, CommaSonrası, Error);
                        }
                    }
                    else if (InputType == "YB")
                    {
                        if (TypeConvert == InputType)
                            return LastCheck(InputVariable, Decimal, Comma, CommaSonrası, Error);
                        else
                        {
                            if (TypeConvert == "Bit")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "9671406556917033397649408", Comma, Error, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "Byte")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1208925819614629174706176", Comma, Error, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "KB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1180591620717411303424", Comma, Error, true);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "MB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1152921504606846976", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "GB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1125899906842624", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "TB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1099511627776", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "PB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1073741824", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "EB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1048576", Comma, Error);
                                else
                                    return Error;
                            }
                            else if (TypeConvert == "ZB")
                            {
                                if (NumberCheck(InputVariable) == true)
                                    Variable = VariableFormat(InputVariable, "1024", Comma, Error);
                                else
                                    return Error;
                            }
                            else
                                return Error;
                            return LastCheck(Variable, Decimal, Comma, CommaSonrası, Error);
                        }
                    }
                    else
                        return Error;
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1V!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Mod"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="CommaSonrası"></param>
        /// <param name="Text"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string IsıÇevir(string Variable, string Mod, bool Decimal, bool Comma, int CommaSonrası = 0, bool Text = true, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= VariableLength && NumberCheck(Variable) == true && !Variable.StartsWith("0") && CommaSonrası >= 0 && CommaSonrası <= 99 && Check(Variable) && Check(Mod))
                {
                    if (Mod == "C=>F" || Mod == "F=>C")
                    {
                        if (Mod == "C=>F")
                        {
                            if (Text == false)
                                return LastCheck2((Convert.ToDouble(Variable) * 9 / 5 + 32).ToString(), Decimal, Comma, CommaSonrası, Error);
                            else
                                return LastCheck2((Convert.ToDouble(Variable) * 9 / 5 + 32).ToString(), Decimal, Comma, CommaSonrası, Error) + " F";
                        }
                        else
                        {
                            if (Convert.ToInt64(Variable) >= 32)
                            {
                                if (Text == false)
                                    return LastCheck2(((Convert.ToDouble(Variable) - 32) * 5 / 9).ToString(), Decimal, Comma, CommaSonrası, Error);
                                else
                                    return LastCheck2(((Convert.ToDouble(Variable) - 32) * 5 / 9).ToString(), Decimal, Comma, CommaSonrası, Error) + " C";
                            }
                            else
                            {
                                if (Text == false)
                                    return LastCheck2("0", Decimal, Comma, CommaSonrası, Error);
                                else
                                    return LastCheck2("0", Decimal, Comma, CommaSonrası, Error) + " C";
                            }
                        }
                    }
                    else
                        return Error;
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1I!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Mod"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string HEXtoRGB(string Variable, int Mod = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length == 6 && Mod >= 0 && Mod <= 10 && Check(Variable))
                {
                    Color HexColor = ColorTranslator.FromHtml("#" + Variable);
                    if (Mod == 0)
                        return HexColor.R + ", " + HexColor.G + ", " + HexColor.B;
                    else if (Mod == 1)
                        return HexColor.R + " " + HexColor.G + " " + HexColor.B;
                    else if (Mod == 2)
                        return HexColor.R + " - " + HexColor.G + " - " + HexColor.B;
                    else if (Mod == 3)
                        return "R: " + HexColor.R + " G: " + HexColor.G + " B: " + HexColor.B;
                    else if (Mod == 4)
                        return "R: " + HexColor.R + ", G: " + HexColor.G + ", B: " + HexColor.B;
                    else if (Mod == 5)
                        return "R: " + HexColor.R;
                    else if (Mod == 6)
                        return "G: " + HexColor.G;
                    else if (Mod == 7)
                        return "B: " + HexColor.B;
                    else if (Mod == 8)
                        return HexColor.R.ToString();
                    else if (Mod == 9)
                        return HexColor.G.ToString();
                    else if (Mod == 10)
                        return HexColor.B.ToString();
                    else
                        return Variable;
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1H!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        /// <param name="Mod"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string RGBtoHEX(string R, string G, string B, bool Mod = false, string Error = ErrorMessage)
        {
            try
            {
                if (R.Length <= 3 && R.Length >= 1 && G.Length <= 3 && G.Length >= 1 && B.Length <= 3 && B.Length >= 1 && NumberCheck(R, true) && NumberCheck(G, true) && NumberCheck(B, true))
                {
                    if ((R.Length >= 2 && R.StartsWith("0")) == true || (G.Length >= 2 && G.StartsWith("0")) == true || (B.Length >= 2 && B.StartsWith("0")) == true)
                        return Error;
                    else
                    {
                        if (Convert.ToInt32(R) >= 0 && Convert.ToInt32(R) <= 255 && Convert.ToInt32(G) >= 0 && Convert.ToInt32(G) <= 255 && Convert.ToInt32(B) >= 0 && Convert.ToInt32(B) <= 255)
                        {
                            Color RGBColor = Color.FromArgb(Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B));
                            if (Mod == true)
                                return "#" + RGBColor.R.ToString("X2") + RGBColor.G.ToString("X2") + RGBColor.B.ToString("X2");
                            else
                                return RGBColor.R.ToString("X2") + RGBColor.G.ToString("X2") + RGBColor.B.ToString("X2");
                        }
                        else
                            return Error;
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1R!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string TEXTtoASCII(string Variable, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= 32767 && Check(Variable, true))
                {
                    string Sonuç = "";
                    byte[] LetterByte;
                    for (int i = 0; i < Variable.Length; i++)
                    {
                        LetterByte = UTF8Encoding.UTF8.GetBytes(Variable.Substring(i, 1)); //Encoding.ASCII
                        if (i < Variable.Length - 1)
                            Sonuç += LetterByte[0] + ",";
                        else
                            Sonuç += LetterByte[0].ToString();
                    }
                    return Sonuç;
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1T!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string ASCIItoTEXT(string Variable, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= 32767 && Check(Variable))
                {
                    string Sonuç = "";
                    char[] Ayraçlar = { ',' };
                    string[] Letterler = Variable.Split(Ayraçlar);
                    for (int i = 0; i < Letterler.Length; i++)
                    {
                        if (NumberCheck(Letterler[i], true) == true && Letterler[i].Length >= 1 && Letterler[i].Length <= 3 && Convert.ToInt32(Letterler[i]) >= 0 && Convert.ToInt32(Letterler[i]) <= 255)
                            Sonuç += UTF8Encoding.UTF8.GetString(new byte[] { Convert.ToByte(Letterler[i]) }); //Encoding.ASCII
                        else
                            return Error;
                    }
                    return Sonuç;
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1A!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CHARtoBASE64(string Variable, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= 32767 && Check(Variable, true))
                    return Convert.ToBase64String(Encoding.UTF8.GetBytes(Variable));
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
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string BASE64toCHAR(string Variable, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= 32767 && Check(Variable))
                {
                    if (Variable.EndsWith("="))
                    {
                        try
                        {
                            return Encoding.UTF8.GetString(Convert.FromBase64String(Variable));
                        }
                        catch
                        {
                            try
                            {
                                return Encoding.UTF8.GetString(Convert.FromBase64String(Variable + "="));
                            }
                            catch
                            {
                                try
                                {
                                    return Encoding.UTF8.GetString(Convert.FromBase64String(Variable.Remove(Variable.Length - 1)));
                                }
                                catch
                                {
                                    return Encoding.UTF8.GetString(Convert.FromBase64String(Variable.Remove(Variable.Length - 2)));
                                }
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            return Encoding.UTF8.GetString(Convert.FromBase64String(Variable));
                        }
                        catch
                        {
                            try
                            {
                                return Encoding.UTF8.GetString(Convert.FromBase64String(Variable + "="));
                            }
                            catch
                            {
                                return Encoding.UTF8.GetString(Convert.FromBase64String(Variable + "=="));
                            }
                        }
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1B!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CHARtoMD5(string Variable, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= 32767 && Check(Variable, true))
                {
                    using (MD5 MD5 = MD5.Create())
                    {
                        MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Variable));
                        byte[] Sonuç = MD5.Hash;
                        StringBuilder Yapı = new StringBuilder();
                        for (int i = 0; i < Sonuç.Length; i++)
                            Yapı.Append(Sonuç[i].ToString("x2"));
                        return Yapı.ToString();
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1C2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Mod"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string FILEtoMD5(string Path, bool Mod = false, string Error = ErrorMessage)
        {
            try
            {
                if (File.Exists(Path))
                {
                    using (MD5 MD5 = new MD5CryptoServiceProvider())
                    {
                        using (var Stream = File.OpenRead(Path))
                        {
                            var Hash = MD5.ComputeHash(Stream);
                            return Mod == false ? BitConverter.ToString(Hash).Replace("-", "").ToLowerInvariant() : BitConverter.ToString(Hash).Replace("-", "").ToUpperInvariant();
                        }
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1F1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CHARtoSHA1(string Variable, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= 32767 && Check(Variable, true))
                {
                    using (SHA1 SHA1 = SHA1.Create())
                    {
                        byte[] Sonuç = SHA1.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Variable));
                        StringBuilder Yapı = new StringBuilder();
                        for (int i = 0; i < Sonuç.Length; i++)
                            Yapı.Append(Sonuç[i].ToString("x2"));
                        return Yapı.ToString();
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1C3!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Mod"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string FILEtoSHA1(string Path, bool Mod = false, string Error = ErrorMessage)
        {
            try
            {
                if (File.Exists(Path))
                {
                    using (SHA1 SHA1 = new SHA1CryptoServiceProvider())
                    {
                        using (var Stream = File.OpenRead(Path))
                        {
                            var Hash = SHA1.ComputeHash(Stream);
                            return Mod == false ? BitConverter.ToString(Hash).Replace("-", "").ToLowerInvariant() : BitConverter.ToString(Hash).Replace("-", "").ToUpperInvariant();
                        }
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1F2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CHARtoSHA256(string Variable, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= 32767 && Check(Variable, true))
                {
                    using (SHA256 SHA256 = SHA256.Create())
                    {
                        byte[] Sonuç = SHA256.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Variable));
                        StringBuilder Yapı = new StringBuilder();
                        for (int i = 0; i < Sonuç.Length; i++)
                            Yapı.Append(Sonuç[i].ToString("x2"));
                        return Yapı.ToString();
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1C4!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Mod"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string FILEtoSHA256(string Path, bool Mod = false, string Error = ErrorMessage)
        {
            try
            {
                if (File.Exists(Path))
                {
                    using (SHA256 SHA256 = new SHA256CryptoServiceProvider())
                    {
                        using (var Stream = File.OpenRead(Path))
                        {
                            var Hash = SHA256.ComputeHash(Stream);
                            return Mod == false ? BitConverter.ToString(Hash).Replace("-", "").ToLowerInvariant() : BitConverter.ToString(Hash).Replace("-", "").ToUpperInvariant();
                        }
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1F3!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CHARtoSHA384(string Variable, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= 32767 && Check(Variable, true))
                {
                    using (SHA384 SHA384 = SHA384.Create())
                    {
                        byte[] Sonuç = SHA384.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Variable));
                        StringBuilder Yapı = new StringBuilder();
                        for (int i = 0; i < Sonuç.Length; i++)
                            Yapı.Append(Sonuç[i].ToString("x2"));
                        return Yapı.ToString();
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1C5!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Mod"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string FILEtoSHA384(string Path, bool Mod = false, string Error = ErrorMessage)
        {
            try
            {
                if (File.Exists(Path))
                {
                    using (SHA384 SHA384 = new SHA384CryptoServiceProvider())
                    {
                        using (var Stream = File.OpenRead(Path))
                        {
                            var Hash = SHA384.ComputeHash(Stream);
                            return Mod == false ? BitConverter.ToString(Hash).Replace("-", "").ToLowerInvariant() : BitConverter.ToString(Hash).Replace("-", "").ToUpperInvariant();
                        }
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1F4!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CHARtoSHA512(string Variable, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= 32767 && Check(Variable, true))
                {
                    using (SHA512 SHA512 = SHA512.Create())
                    {
                        byte[] Sonuç = SHA512.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Variable));
                        StringBuilder Yapı = new StringBuilder();
                        for (int i = 0; i < Sonuç.Length; i++)
                            Yapı.Append(Sonuç[i].ToString("x2"));
                        return Yapı.ToString();
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1C6!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Mod"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string FILEtoSHA512(string Path, bool Mod = false, string Error = ErrorMessage)
        {
            try
            {
                if (File.Exists(Path))
                {
                    using (SHA512 SHA512 = new SHA512CryptoServiceProvider())
                    {
                        using (var Stream = File.OpenRead(Path))
                        {
                            var Hash = SHA512.ComputeHash(Stream);
                            return Mod == false ? BitConverter.ToString(Hash).Replace("-", "").ToLowerInvariant() : BitConverter.ToString(Hash).Replace("-", "").ToUpperInvariant();
                        }
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1F5!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="CommaSonrası"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string INCHtoCM(string Variable, bool Decimal, bool Comma, int CommaSonrası = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= VariableLength && NumberCheck(Variable) == true && !Variable.StartsWith("0") && CommaSonrası >= 0 && CommaSonrası <= 99 && Check(Variable))
                    return LastCheck2((Convert.ToInt64(Variable) * 2.54).ToString(), Decimal, Comma, CommaSonrası, Error);
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
        /// <param name="CommaSonrası"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string INCHtoPX(string Variable, bool Decimal, bool Comma, int CommaSonrası = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= VariableLength && NumberCheck(Variable) == true && !Variable.StartsWith("0") && CommaSonrası >= 0 && CommaSonrası <= 99 && Check(Variable))
                {
                    string Sonuç = (Convert.ToInt64(Variable) * 2.54 * 37.79527559055118).ToString();
                    return LastCheck2(Sonuç, Decimal, Comma, CommaSonrası, Error);
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
        /// <param name="CommaSonrası"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CMtoINCH(string Variable, bool Decimal, bool Comma, int CommaSonrası = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= VariableLength && NumberCheck(Variable) == true && !Variable.StartsWith("0") && CommaSonrası >= 0 && CommaSonrası <= 99 && Check(Variable))
                {
                    if (Convert.ToInt64(Variable) >= 3)
                        return LastCheck2((Convert.ToInt64(Variable) / 2.54).ToString(), Decimal, Comma, CommaSonrası, Error);
                    else
                        return LastCheck2("0", Decimal, Comma, CommaSonrası, Error);
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
        /// <param name="CommaSonrası"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CMtoPX(string Variable, bool Decimal, bool Comma, int CommaSonrası = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= VariableLength && NumberCheck(Variable) == true && !Variable.StartsWith("0") && CommaSonrası >= 0 && CommaSonrası <= 99 && Check(Variable))
                    return LastCheck2((Convert.ToInt64(Variable) * 37.79527559055118).ToString(), Decimal, Comma, CommaSonrası, Error);
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
        /// <param name="CommaSonrası"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string PXtoCM(string Variable, bool Decimal, bool Comma, int CommaSonrası = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= VariableLength && NumberCheck(Variable) == true && !Variable.StartsWith("0") && CommaSonrası >= 0 && CommaSonrası <= 99 && Check(Variable))
                {
                    if (Convert.ToInt64(Variable) >= 38)
                        return LastCheck2((Convert.ToInt64(Variable) / 37.79527559055118).ToString(), Decimal, Comma, CommaSonrası, Error);
                    else
                        return LastCheck2("0", Decimal, Comma, CommaSonrası, Error);
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
        /// <param name="CommaSonrası"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string PXtoINCH(string Variable, bool Decimal, bool Comma, int CommaSonrası = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= VariableLength && NumberCheck(Variable) == true && !Variable.StartsWith("0") && CommaSonrası >= 0 && CommaSonrası <= 99 && Check(Variable))
                {
                    if (Convert.ToInt64(Variable) >= 96)
                        return LastCheck2((Convert.ToInt64(Variable) / 37.79527559055118 / 2.54).ToString(), Decimal, Comma, CommaSonrası, Error);
                    else
                        return LastCheck2("0", Decimal, Comma, CommaSonrası, Error);
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1P2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Mod"></param>
        /// <param name="Mod2"></param>
        /// <returns></returns>
        public static bool NumberCheck(string Variable, bool Mod = false, bool Mod2 = false)
        {
            try
            {
                if (Regex.IsMatch(Variable, "[^0-9]"))
                    return false;
                else
                {
                    if (Mod2 == false)
                    {
                        if (Mod == false)
                        {
                            Convert.ToInt64(Variable);
                            return true;
                        }
                        else
                        {
                            Convert.ToInt32(Variable);
                            return true;
                        }
                    }
                    else
                        return true;
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Privates
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable1"></param>
        /// <param name="Variable2"></param>
        /// <param name="Mod"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        private static string Arama(string Variable1, string[] Variable2, int Mod = 1, string Error = ErrorMessage)
        {
            try
            {
                if (Mod >= 1 && Mod <= 3)
                {
                    string Status = "N";
                    if (Mod == 1)
                    {
                        if (Variable2.Length > 1)
                        {
                            foreach (string Letter in Variable2)
                            {
                                if (Variable1.Contains(Letter))
                                {
                                    Status = "Y";
                                    break;
                                }
                            }
                        }
                        else if (Variable1.Contains(Variable2[0]))
                            Status = "Y";
                    }
                    else if (Mod == 2)
                    {
                        if (Variable2.Length > 1)
                        {
                            foreach (string Letter in Variable2)
                            {
                                if (Variable1.StartsWith(Letter))
                                {
                                    Status = "Y";
                                    break;
                                }
                            }
                        }
                        else if (Variable1.StartsWith(Variable2[0]))
                            Status = "Y";
                    }
                    else if (Mod == 3)
                    {
                        if (Variable2.Length > 1)
                        {
                            foreach (string Letter in Variable2)
                            {
                                if (Variable1.EndsWith(Letter))
                                {
                                    Status = "Y";
                                    break;
                                }
                            }
                        }
                        else if (Variable1.EndsWith(Variable2[0]))
                            Status = "Y";
                    }
                    if (Status == "N")
                        return "N";
                    else
                        return "Y";
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1A2!)";
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
        private static string VariableFormat(string InputVariable, string Coefficient, bool Comma, string Error = ErrorMessage, bool Mod = false, bool Mod2 = false)
        {
            try
            {
                if (Mod == false)
                {
                    if (NumberCheck(Coefficient.ToString()) == true)
                    {
                        string Variable1, Variable2, Variable3;
                        if (Comma == true)
                        {
                            if (Mod2 == false)
                            {
                                Variable2 = (Convert.ToInt64(InputVariable) * Convert.ToDouble(Coefficient)).ToString();
                                Variable3 = (Convert.ToInt64(InputVariable) * Convert.ToInt64(Coefficient)).ToString();
                            }
                            else
                            {
                                Variable2 = (Convert.ToInt64(InputVariable) / Convert.ToDouble(Coefficient)).ToString();
                                Variable3 = (Convert.ToInt64(InputVariable) / Convert.ToInt64(Coefficient)).ToString();
                            }
                            if (Arama(Variable2, SymbolsCalc, 1, Error) == "Y")
                            {
                                if (Arama(Variable3, SymbolsMath, 2, Error) == "Y")
                                    Variable1 = Variable2;
                                else
                                    Variable1 = Variable3;
                            }
                            else if (Arama(Variable3, SymbolsMath, 2, Error) == "Y")
                                if (Arama(Variable3, SymbolsMath, 2, Error) == "Y")
                                    Variable1 = Variable2;
                                else
                                    Variable1 = Variable3;
                            else
                                Variable1 = Variable2;
                        }
                        else
                        {
                            if (Mod2 == false)
                            {
                                Variable2 = (Convert.ToInt64(InputVariable) * Convert.ToDouble(Coefficient)).ToString();
                                Variable3 = (Convert.ToInt64(InputVariable) * Convert.ToInt64(Coefficient)).ToString();
                            }
                            else
                            {
                                Variable2 = (Convert.ToInt64(InputVariable) / Convert.ToDouble(Coefficient)).ToString();
                                Variable3 = (Convert.ToInt64(InputVariable) / Convert.ToInt64(Coefficient)).ToString();
                            }
                            if (Arama(Variable2, SymbolsCalc, 1, Error) == "Y")
                            {
                                if (Arama(Variable3, SymbolsMath, 2, Error) == "Y")
                                    Variable1 = Variable2;
                                else
                                    Variable1 = Variable3;
                            }
                            else if (Arama(Variable3, SymbolsMath, 2, Error) == "Y")
                                if (Arama(Variable3, SymbolsMath, 2, Error) == "Y")
                                    Variable1 = Variable2;
                                else
                                    Variable1 = Variable3;
                            else
                                Variable1 = Variable3;
                        }
                        if (string.IsNullOrEmpty(Variable1))
                            return Error;
                        else
                            return Variable1;
                    }
                    else
                        return Error;
                }
                else
                {
                    if (Mod2 == false)
                        return (Convert.ToInt64(InputVariable) * Convert.ToDouble(Coefficient)).ToString();
                    else
                        return (Convert.ToInt64(InputVariable) / Convert.ToDouble(Coefficient)).ToString();
                }
            }
            catch
            {
                return Error + ErrorTitle + "1V2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <returns></returns>
        private static string Decimal(string Variable)
        {
            try
            {
                if (Variable.Contains("E") || Variable.Contains("B") || Variable.Contains("+") || Variable.Contains("-"))
                    return Variable;
                else
                {
                    if (Variable.Contains(","))
                    {
                        char[] Ayraçlar = { ',', '.' };
                        string[] Variableler = Variable.Split(Ayraçlar);
                        string Sonuç = string.Format("{0:0,0}", Convert.ToInt64(Variableler[0]));
                        if (Sonuç.Length == 2 && Sonuç == "00")
                            Sonuç = "0";
                        else if (Sonuç.Length == 2 && Sonuç.StartsWith("0") && !Sonuç.EndsWith("0"))
                            Sonuç.Replace("0", "");
                        return Sonuç + "," + Variableler[1];
                    }
                    else
                    {
                        if (Variable.Length > 2)
                        {
                            if (NumberCheck(Variable) == true)
                                return string.Format("{0:0,0}", Convert.ToInt64(Variable));
                            else
                                return string.Format("{0:0,0}", Variable);
                        }
                        else
                            return Variable;
                    }
                }
            }
            catch (Exception Error)
            {
                return Error + ErrorTitle + "1O2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <returns></returns>
        private static string Decimal2(string Variable)
        {
            try
            {
                if (Variable.Contains("E") || Variable.Contains("B") || Variable.Contains("+") || Variable.Contains("-"))
                    return Variable;
                else
                {
                    if (Variable.Contains(","))
                    {
                        char[] Ayraçlar = { ',' };
                        string[] Variableler = Variable.Split(Ayraçlar);
                        string Sonuç = string.Format("{0:0,0}", Convert.ToInt64(Variableler[0]));
                        if (Sonuç.Length == 2 && Sonuç == "00")
                            return "0";
                        else if (Sonuç.Length == 2 && Sonuç.StartsWith("0") && !Sonuç.EndsWith("0"))
                            return Sonuç.Replace("0", "");
                        else
                            return Sonuç;
                    }
                    else
                    {
                        if (Variable.Length > 2)
                        {
                            if (NumberCheck(Variable) == true)
                                return string.Format("{0:0,0}", Convert.ToInt64(Variable));
                            else
                                return string.Format("{0:0,0}", Variable);
                        }
                        else
                            return Variable;
                    }
                }
            }
            catch (Exception Error)
            {
                return Error + ErrorTitle + "1O3!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="CommaSonrası"></param>
        /// <returns></returns>
        private static string Comma(string Variable, int CommaSonrası = 0)
        {
            try
            {
                if (Variable.Contains("E") || Variable.Contains("B") || Variable.Contains("+") || Variable.Contains("-"))
                    return Variable;
                else
                {
                    if (Variable.Contains(",") && CommaSonrası != 0)
                    {
                        char[] Ayraçlar = { ',' };
                        string[] Variableler = Variable.Split(Ayraçlar);
                        if (CommaSonrası <= Variableler[1].Length)
                            return Variableler[0] + "," + Variableler[1].Substring(0, CommaSonrası);
                        else
                        {
                            string Işlem = Variableler[0] + "," + Variableler[1].Substring(0, Variableler[1].Length);
                            int Işlem2 = CommaSonrası - Variableler[1].Length;
                            for (int i = 0; i < Işlem2; i++)
                                Işlem += "0";
                            return Işlem;
                        }
                    }
                    else
                    {
                        if (CommaSonrası == 0)
                        {
                            char[] Ayraçlar = { ',' };
                            string[] Variableler = Variable.Split(Ayraçlar);
                            return Variableler[0];
                        }
                        else
                        {
                            string Işlem = ",";
                            for (int i = 0; i < CommaSonrası; i++)
                                Işlem += "0";
                            return Variable + Işlem;
                        }
                    }
                }
            }
            catch (Exception Error)
            {
                return Error + ErrorTitle + "1V3!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="CommaSonrası"></param>
        /// <returns></returns>
        private static string Comma2(string Variable, int CommaSonrası = 0)
        {
            try
            {
                if (Variable.Contains("E") || Variable.Contains("B") || Variable.Contains("+") || Variable.Contains("-"))
                    return Variable;
                else
                {
                    if (CommaSonrası <= Variable.Length)
                        if (Variable == ",")
                            return Variable.Substring(0, CommaSonrası) + "0";
                        else
                            return Variable.Substring(0, CommaSonrası);
                    else
                    {
                        string Işlem = Variable.Substring(0, Variable.Length);
                        int Işlem2 = CommaSonrası - Variable.Length;
                        if (Variable == ",")
                        {
                            for (int i = 0; i <= Işlem2; i++)
                                Işlem += "0";
                        }
                        else
                        {
                            for (int i = 0; i < Işlem2; i++)
                                Işlem += "0";
                        }
                        return Işlem;
                    }
                }
            }
            catch (Exception Error)
            {
                return Error + ErrorTitle + "1v4!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="CommaSonrası"></param>
        /// <returns></returns>
        private static string DecimalComma(string Variable, int CommaSonrası = 0)
        {
            try
            {
                if (Variable.Contains("E") || Variable.Contains("B") || Variable.Contains("+") || Variable.Contains("-"))
                    return Variable;
                else
                {
                    if (CommaSonrası == 0)
                        return Decimal2(Variable);
                    else
                    {
                        if (Variable.Contains(","))
                        {
                            char[] Ayraçlar = { ',' };
                            string[] Variableler = Variable.Split(Ayraçlar);
                            return Decimal2(Variableler[0]) + "," + Comma2(Variableler[1], CommaSonrası);
                        }
                        else
                            return Decimal2(Variable) + Comma2(",", CommaSonrası);
                    }
                }
            }
            catch (Exception Error)
            {
                return Error + ErrorTitle + "1O4!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="CommaSonrası"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        private static string LastCheck(string Variable, bool Decimal, bool Comma, int CommaSonrası = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Decimal == false && Comma == false)
                {
                    if (string.IsNullOrEmpty(Variable))
                        return Error;
                    else
                        return Variable;
                }
                else
                {
                    if (Decimal == true && Comma == false)
                        return Conforyon.Decimal(Variable);
                    else if (Decimal == false && Comma == true)
                        return Conforyon.Comma(Variable, CommaSonrası);
                    else
                        return DecimalComma(Variable, CommaSonrası);
                }
            }
            catch
            {
                return Error + ErrorTitle + "1S!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="CommaSonrası"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        private static string LastCheck2(string Variable, bool Decimal, bool Comma, int CommaSonrası = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Decimal == false && Comma == false)
                {
                    if (string.IsNullOrEmpty(Variable))
                        return Error;
                    else
                        return LastCheck(Variable, false, true, 0, Error);
                }
                else
                {
                    if (Decimal == true && Comma == false)
                        return LastCheck(Variable, true, true, 0, Error);
                    else if (Decimal == false && Comma == true)
                        return LastCheck(Variable, false, true, CommaSonrası, Error);
                    else
                        return DecimalComma(Variable, CommaSonrası);
                }
            }
            catch
            {
                return Error + ErrorTitle + "1S2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Mod"></param>
        /// <returns></returns>
        private static bool Check(string Variable, bool Mod = false)
        {
            try
            {
                if (Mod == false)
                {
                    if (Variable != "" && !string.IsNullOrEmpty(Variable) && !string.IsNullOrWhiteSpace(Variable) && !Variable.Contains(" "))
                        return true;
                    else
                        return false;
                }
                else
                {
                    if (Variable != "" && !string.IsNullOrEmpty(Variable) && !string.IsNullOrWhiteSpace(Variable))
                        return true;
                    else
                        return false;
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #endregion
    }
}