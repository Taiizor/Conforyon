#region Imports

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
        public static string AutoDataConvert(string InputVariable, StorageType InputType, bool TypeText = false, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (InputVariable.Length <= VariableLength && InputType >= StorageType.Bit && InputType <= StorageType.YB && PostComma >= 0 && PostComma <= 99 && !Regex.IsMatch(InputVariable, "[^0-9]") && !InputVariable.StartsWith("0") && UseCheck(InputVariable))
                {
                    StorageType Type = InputType;
                    if (InputType == StorageType.YB)
                        Type = StorageType.YB;
                    else
                    {
                        for (int i = (int)InputType; i <= (int)StorageType.YB; i++)
                        {
                            if (DataConvert(InputVariable, InputType, (StorageType)i, false, false, 0, Error) == "0")
                            {
                                Type = (StorageType)i - 1;
                                break;
                            }
                            else
                            {
                                if ((StorageType)i == StorageType.YB)
                                    Type = (StorageType)i;
                            }
                        }
                    }

                    if (InputType != Type)
                    {
                        string Result = DataConvert(InputVariable, InputType, Type, Decimal, Comma, PostComma, Error);
                        if (!TypeText || Result == Error)
                            return Result;
                        else
                            return Result + " " + Type;
                    }
                    else
                    {
                        string Result = null;
                        if (!Decimal && !Comma)
                            Result = InputVariable;
                        else
                        {
                            if (Decimal && !Comma)
                                Result = UseDecimal(InputVariable);
                            else if (!Decimal && Comma)
                                Result = UseComma(InputVariable, PostComma);
                            else
                                Result = DecimalComma(InputVariable, PostComma);
                        }
                        if (!TypeText || Result == Error)
                            return Result;
                        else
                            return Result + " " + Type;
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "SE-ADC1!)";
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
                if (InputVariable.Length <= VariableLength && InputType >= StorageType.Bit && InputType <= StorageType.YB && TypeConvert >= StorageType.Bit && TypeConvert <= StorageType.YB && PostComma >= 0 && PostComma <= 99 && !Regex.IsMatch(InputVariable, "[^0-9]") && !InputVariable.StartsWith("0") && UseCheck(InputVariable))
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
                return Error + ErrorTitle + "SE-DC1!)";
            }
        }
    }
}