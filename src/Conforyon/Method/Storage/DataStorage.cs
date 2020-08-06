#region Imports

using System;
using static Conforyon.Conforyon;
using System.Text.RegularExpressions;

#endregion

namespace Conforyon
{
    public static class DataStorage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="InputVariable"></param>
        /// <param name="InputType"></param>
        /// <param name="TypeText"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string AutoDataConvert(string InputVariable, string InputType, bool TypeText = false, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (InputVariable.Length <= VariableLength && Array.IndexOf(StorageTypes, InputType) >= 0 && PostComma >= 0 && PostComma <= 99 && !Regex.IsMatch(InputVariable, "[^0-9]") && !InputVariable.StartsWith("0") && UseCheck(InputVariable) && UseCheck(InputType))
                {
                    string Type = null;
                    if (InputType == StorageTypes[StorageTypes.Length - 1])
                        Type = StorageTypes[StorageTypes.Length - 1];
                    else
                    {
                        for (int i = Array.IndexOf(StorageTypes, InputType); i < StorageTypes.Length; i++)
                        {
                            if (DataConvert(InputVariable, InputType, StorageTypes[i], false, false, 0, Error) == "0")
                            {
                                Type = StorageTypes[i - 1];
                                break;
                            }
                            else
                            {
                                if (StorageTypes[i] == StorageTypes[StorageTypes.Length - 1])
                                    Type = StorageTypes[i];
                            }
                        }
                    }
                    if (string.IsNullOrEmpty(Type))
                        return Error;
                    else
                    {
                        if (InputType != Type)
                        {
                            string Sonuç = DataConvert(InputVariable, InputType, Type, Decimal, Comma, PostComma, Error);
                            if (TypeText == false || Sonuç == Error)
                                return Sonuç;
                            else
                                return Sonuç + " " + Type;
                        }
                        else
                        {
                            string Sonuç = null;
                            if (!Decimal && !Comma)
                                Sonuç = InputVariable;
                            else
                            {
                                if (Decimal && !Comma)
                                    Sonuç = UseDecimal(InputVariable);
                                else if (!Decimal && Comma)
                                    Sonuç = UseComma(InputVariable, PostComma);
                                else
                                    Sonuç = DecimalComma(InputVariable, PostComma);
                            }
                            if (TypeText)
                                return Sonuç + " " + Type;
                            else
                                return Sonuç;
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
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string DataConvert(string InputVariable, StorageType InputType, StorageType TypeConvert, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                string Variable;
                if (InputVariable.Length <= VariableLength && PostComma >= 0 && PostComma <= 99 && !Regex.IsMatch(InputVariable, "[^0-9]") && !InputVariable.StartsWith("0") && UseCheck(InputVariable))
                {
                    switch (InputType)
                    {
                        case StorageType.Bit:
                            switch (TypeConvert)
                            {
                                case StorageType.Bit:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case StorageType.Byte:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "8", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.KB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "8192", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.MB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "8388608", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.GB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "8589934592", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.TB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "8796093022208", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.PB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "9007199254740992", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.EB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, (8796093022208 * 2048).ToString(), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.ZB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, (8796093022208 * 3072).ToString(), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.YB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, (8796093022208 * 4096).ToString(), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            return LastCheck(Variable, Decimal, Comma, PostComma, Error);
                        case StorageType.Byte:
                            switch (TypeConvert)
                            {
                                case StorageType.Bit:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "8", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.Byte:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case StorageType.KB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1024", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.MB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1048576", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.GB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1073741824", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.TB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1099511627776", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.PB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1125899906842624", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.EB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1152921504606846976", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.ZB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, (1125899906842624 * 2048).ToString(), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.YB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, (1125899906842624 * 3072).ToString(), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            return LastCheck(Variable, Decimal, Comma, PostComma, Error);
                        case StorageType.KB:
                            switch (TypeConvert)
                            {
                                case StorageType.Bit:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "8192", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.Byte:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1024", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.KB:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case StorageType.MB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1024", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.GB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1048576", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.TB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1073741824", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.PB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1099511627776", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.EB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1125899906842624", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.ZB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1152921504606846976", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.YB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, (1125899906842624 * 2048).ToString(), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            return LastCheck(Variable, Decimal, Comma, PostComma, Error);
                        case StorageType.MB:
                            switch (TypeConvert)
                            {
                                case StorageType.Bit:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "8388608", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.Byte:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1048576", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.KB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1024", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.MB:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case StorageType.GB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1024", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.TB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1048576", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.PB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1073741824", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.EB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1099511627776", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.ZB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1125899906842624", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.YB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1152921504606847000", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            return LastCheck(Variable, Decimal, Comma, PostComma, Error);
                        case StorageType.GB:
                            switch (TypeConvert)
                            {
                                case StorageType.Bit:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "8589934592", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.Byte:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1073741824", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.KB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1048576", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.MB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1024", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.GB:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case StorageType.TB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1024", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.PB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1048576", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.EB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1073741824", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.ZB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1099511627776", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.YB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1125899906842624", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            return LastCheck(Variable, Decimal, Comma, PostComma, Error);
                        case StorageType.TB:
                            switch (TypeConvert)
                            {
                                case StorageType.Bit:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "8796093022208", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.Byte:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1099511627776", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.KB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1073741824", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.MB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1048576", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.GB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1024", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.TB:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case StorageType.PB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1024", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.EB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1048576", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.ZB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1073741824", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.YB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1099511627776", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            return LastCheck(Variable, Decimal, Comma, PostComma, Error);
                        case StorageType.PB:
                            switch (TypeConvert)
                            {
                                case StorageType.Bit:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "9007199254740992", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.Byte:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1125899906842624", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.KB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1099511627776", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.MB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1073741824", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.GB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1048576", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.TB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1024", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.PB:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case StorageType.EB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1024", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.ZB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1048576", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.YB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1073741824", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            return LastCheck(Variable, Decimal, Comma, PostComma, Error);
                        case StorageType.EB:
                            switch (TypeConvert)
                            {
                                case StorageType.Bit:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "9223372036854775808", Comma, Error, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.Byte:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1152921504606846976", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.KB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1125899906842624", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.MB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1099511627776", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.GB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1073741824", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.TB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1048576", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.PB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1024", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.EB:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case StorageType.ZB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1024", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.YB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1048576", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            return LastCheck(Variable, Decimal, Comma, PostComma, Error);
                        case StorageType.ZB:
                            switch (TypeConvert)
                            {
                                case StorageType.Bit:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "9444732965739290427392", Comma, Error, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.Byte:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1180591620717411303424", Comma, Error, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.KB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1152921504606846976", Comma, Error, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.MB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1125899906842624", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.GB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1099511627776", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.TB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1073741824", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.PB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1048576", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.EB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1024", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.ZB:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case StorageType.YB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1024", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            return LastCheck(Variable, Decimal, Comma, PostComma, Error);
                        case StorageType.YB:
                            switch (TypeConvert)
                            {
                                case StorageType.Bit:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "9671406556917033397649408", Comma, Error, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.Byte:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1208925819614629174706176", Comma, Error, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.KB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1180591620717411303424", Comma, Error, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.MB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1152921504606846976", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.GB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1125899906842624", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.TB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1099511627776", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.PB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1073741824", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.EB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1048576", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.ZB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1024", Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.YB:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                default:
                                    return Error;
                            }
                            return LastCheck(Variable, Decimal, Comma, PostComma, Error);
                        default:
                            return Error;
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1V!)";
            }
        }
    }
}