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
                if (InputVariable.Length <= VariableLength && InputType >= StorageType.Bit && InputType <= StorageType.YB && PostComma >= PostCommaMinimum && PostComma <= PostCommaMaximum && !Regex.IsMatch(InputVariable, "[^0-9]") && !InputVariable.StartsWith("0") && UseCheck(InputVariable))
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
                if (InputVariable.Length <= VariableLength && InputType >= StorageType.Bit && InputType <= StorageType.YB && TypeConvert >= StorageType.Bit && TypeConvert <= StorageType.YB && PostComma >= PostCommaMinimum && PostComma <= PostCommaMaximum && !Regex.IsMatch(InputVariable, "[^0-9]") && !InputVariable.StartsWith("0") && UseCheck(InputVariable))
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
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "Bit", "Byte", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.KB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "Bit", "KB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.MB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "Bit", "MB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.GB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "Bit", "GB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.TB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "Bit", "TB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.PB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "Bit", "PB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.EB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "Bit", "EB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.ZB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "Bit", "ZB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.YB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "Bit", "YB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case StorageType.Byte:
                            switch (TypeConvert)
                            {
                                case StorageType.Bit:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "Byte", "Bit", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.Byte:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case StorageType.KB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "Byte", "KB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.MB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "Byte", "MB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.GB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "Byte", "GB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.TB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "Byte", "TB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.PB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "Byte", "PB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.EB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "Byte", "EB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.ZB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "Byte", "ZB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.YB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "Byte", "YB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case StorageType.KB:
                            switch (TypeConvert)
                            {
                                case StorageType.Bit:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "KB", "Bit", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.Byte:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "KB", "Byte", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.KB:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case StorageType.MB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "KB", "MB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.GB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "KB", "GB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.TB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "KB", "TB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.PB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "KB", "PB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.EB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "KB", "EB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.ZB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "KB", "ZB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.YB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "KB", "YB", Error).ToString(), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case StorageType.MB:
                            switch (TypeConvert)
                            {
                                case StorageType.Bit:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "MB", "Bit", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.Byte:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "MB", "Byte", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.KB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "MB", "KB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.MB:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case StorageType.GB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "MB", "GB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.TB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "MB", "TB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.PB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "MB", "PB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.EB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "MB", "EB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.ZB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "MB", "ZB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.YB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "MB", "YB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case StorageType.GB:
                            switch (TypeConvert)
                            {
                                case StorageType.Bit:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "GB", "Bit", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.Byte:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "GB", "Byte", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.KB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "GB", "KB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.MB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "GB", "MB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.GB:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case StorageType.TB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "GB", "TB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.PB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "GB", "PB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.EB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "GB", "EB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.ZB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "GB", "ZB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.YB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "GB", "YB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case StorageType.TB:
                            switch (TypeConvert)
                            {
                                case StorageType.Bit:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "TB", "Bit", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.Byte:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "TB", "Byte", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.KB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "TB", "KB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.MB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "TB", "MB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.GB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "TB", "GB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.TB:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case StorageType.PB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "TB", "PB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.EB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "TB", "EB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.ZB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "TB", "ZB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.YB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "TB", "YB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case StorageType.PB:
                            switch (TypeConvert)
                            {
                                case StorageType.Bit:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "PB", "Bit", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.Byte:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "PB", "Byte", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.KB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "PB", "KB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.MB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "PB", "MB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.GB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "PB", "GB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.TB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "PB", "TB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.PB:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case StorageType.EB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "PB", "EB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.ZB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "PB", "ZB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.YB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "PB", "YB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case StorageType.EB:
                            switch (TypeConvert)
                            {
                                case StorageType.Bit:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "EB", "Bit", Error), Comma, Error, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.Byte:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "EB", "Byte", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.KB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "EB", "KB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.MB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "EB", "MB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.GB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "EB", "GB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.TB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "EB", "TB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.PB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "EB", "PB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.EB:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case StorageType.ZB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "EB", "ZB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.YB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "EB", "YB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case StorageType.ZB:
                            switch (TypeConvert)
                            {
                                case StorageType.Bit:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "ZB", "Bit", Error), Comma, Error, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.Byte:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "ZB", "Byte", Error), Comma, Error, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.KB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "ZB", "KB", Error), Comma, Error, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.MB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "ZB", "MB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.GB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "ZB", "GB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.TB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "ZB", "TB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.PB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "ZB", "PB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.EB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "ZB", "EB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.ZB:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case StorageType.YB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "ZB", "YB", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case StorageType.YB:
                            switch (TypeConvert)
                            {
                                case StorageType.Bit:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "YB", "Bit", Error), Comma, Error, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.Byte:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "YB", "Byte", Error), Comma, Error, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.KB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "YB", "KB", Error), Comma, Error, true);
                                    else
                                        return Error;
                                    break;
                                case StorageType.MB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "YB", "MB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.GB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "YB", "GB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.TB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "YB", "TB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.PB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "YB", "PB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.EB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "YB", "EB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.ZB:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("DataStorage", "YB", "ZB", Error), Comma, Error);
                                    else
                                        return Error;
                                    break;
                                case StorageType.YB:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                default:
                                    return Error;
                            }
                            break;
                        default:
                            return Error;
                    }
                    return LastCheck(Variable, Decimal, Comma, PostComma, Error);
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