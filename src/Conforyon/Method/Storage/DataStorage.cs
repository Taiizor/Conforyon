#region Imports

using System.Text.RegularExpressions;

#endregion

namespace Conforyon.Storage
{
    /// <summary>
    /// 
    /// </summary>
    public class DataStorage
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
        public static string AutoDataConvert(string InputVariable, Enum.Enum.StorageType InputType, bool TypeText = false, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                if (InputVariable.Length <= Constant.Constant.VariableLength && InputType >= Enum.Enum.StorageType.Bit && InputType <= Enum.Enum.StorageType.YB && PostComma >= Constant.Constant.PostCommaMinimum && PostComma <= Constant.Constant.PostCommaMaximum && !Regex.IsMatch(InputVariable, "[^0-9]") && !InputVariable.StartsWith("0") && Core.UseCheck(InputVariable))
                {
                    Enum.Enum.StorageType Type = InputType;
                    if (InputType == Enum.Enum.StorageType.YB)
                    {
                        Type = Enum.Enum.StorageType.YB;
                    }
                    else
                    {
                        for (int i = (int)InputType; i <= (int)Enum.Enum.StorageType.YB; i++)
                        {
                            if (DataConvert(InputVariable, InputType, (Enum.Enum.StorageType)i, false, false, 0, Error) == "0")
                            {
                                Type = (Enum.Enum.StorageType)i - 1;
                                break;
                            }
                            else
                            {
                                if ((Enum.Enum.StorageType)i == Enum.Enum.StorageType.YB)
                                {
                                    Type = (Enum.Enum.StorageType)i;
                                }
                            }
                        }
                    }

                    if (InputType != Type)
                    {
                        string Result = DataConvert(InputVariable, InputType, Type, Decimal, Comma, PostComma, Error);
                        if (!TypeText || Result == Error)
                        {
                            return Result;
                        }
                        else
                        {
                            return Result + " " + Type;
                        }
                    }
                    else
                    {
                        string Result = null;
                        if (!Decimal && !Comma)
                        {
                            Result = InputVariable;
                        }
                        else
                        {
                            if (Decimal && !Comma)
                            {
                                Result = Core.UseDecimal(InputVariable);
                            }
                            else if (!Decimal && Comma)
                            {
                                Result = Core.UseComma(InputVariable, PostComma);
                            }
                            else
                            {
                                Result = Core.DecimalComma(InputVariable, PostComma);
                            }
                        }
                        if (!TypeText || Result == Error)
                        {
                            return Result;
                        }
                        else
                        {
                            return Result + " " + Type;
                        }
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constant.Constant.ErrorTitle + "SE-ADC1!)";
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
        public static string DataConvert(string InputVariable, Enum.Enum.StorageType InputType, Enum.Enum.StorageType TypeConvert, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                string Variable;
                if (InputVariable.Length <= Constant.Constant.VariableLength && InputType >= Enum.Enum.StorageType.Bit && InputType <= Enum.Enum.StorageType.YB && TypeConvert >= Enum.Enum.StorageType.Bit && TypeConvert <= Enum.Enum.StorageType.YB && PostComma >= Constant.Constant.PostCommaMinimum && PostComma <= Constant.Constant.PostCommaMaximum && !Regex.IsMatch(InputVariable, "[^0-9]") && !InputVariable.StartsWith("0") && Core.UseCheck(InputVariable))
                {
                    switch (InputType)
                    {
                        case Enum.Enum.StorageType.Bit:
                            switch (TypeConvert)
                            {
                                case Enum.Enum.StorageType.Bit:
                                    return Core.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enum.Enum.StorageType.Byte:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "Bit", "Byte", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.KB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "Bit", "KB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.MB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "Bit", "MB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.GB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "Bit", "GB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.TB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "Bit", "TB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.PB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "Bit", "PB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.EB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "Bit", "EB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.ZB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "Bit", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.YB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "Bit", "YB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case Enum.Enum.StorageType.Byte:
                            switch (TypeConvert)
                            {
                                case Enum.Enum.StorageType.Bit:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "Byte", "Bit", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.Byte:
                                    return Core.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enum.Enum.StorageType.KB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "Byte", "KB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.MB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "Byte", "MB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.GB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "Byte", "GB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.TB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "Byte", "TB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.PB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "Byte", "PB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.EB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "Byte", "EB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.ZB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "Byte", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.YB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "Byte", "YB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case Enum.Enum.StorageType.KB:
                            switch (TypeConvert)
                            {
                                case Enum.Enum.StorageType.Bit:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "KB", "Bit", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.Byte:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "KB", "Byte", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.KB:
                                    return Core.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enum.Enum.StorageType.MB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "KB", "MB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.GB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "KB", "GB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.TB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "KB", "TB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.PB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "KB", "PB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.EB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "KB", "EB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.ZB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "KB", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.YB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "KB", "YB", Error).ToString(), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case Enum.Enum.StorageType.MB:
                            switch (TypeConvert)
                            {
                                case Enum.Enum.StorageType.Bit:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "MB", "Bit", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.Byte:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "MB", "Byte", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.KB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "MB", "KB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.MB:
                                    return Core.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enum.Enum.StorageType.GB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "MB", "GB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.TB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "MB", "TB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.PB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "MB", "PB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.EB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "MB", "EB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.ZB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "MB", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.YB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "MB", "YB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case Enum.Enum.StorageType.GB:
                            switch (TypeConvert)
                            {
                                case Enum.Enum.StorageType.Bit:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "GB", "Bit", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.Byte:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "GB", "Byte", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.KB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "GB", "KB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.MB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "GB", "MB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.GB:
                                    return Core.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enum.Enum.StorageType.TB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "GB", "TB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.PB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "GB", "PB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.EB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "GB", "EB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.ZB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "GB", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.YB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "GB", "YB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case Enum.Enum.StorageType.TB:
                            switch (TypeConvert)
                            {
                                case Enum.Enum.StorageType.Bit:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "TB", "Bit", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.Byte:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "TB", "Byte", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.KB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "TB", "KB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.MB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "TB", "MB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.GB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "TB", "GB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.TB:
                                    return Core.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enum.Enum.StorageType.PB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "TB", "PB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.EB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "TB", "EB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.ZB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "TB", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.YB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "TB", "YB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case Enum.Enum.StorageType.PB:
                            switch (TypeConvert)
                            {
                                case Enum.Enum.StorageType.Bit:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "PB", "Bit", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.Byte:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "PB", "Byte", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.KB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "PB", "KB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.MB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "PB", "MB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.GB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "PB", "GB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.TB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "PB", "TB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.PB:
                                    return Core.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enum.Enum.StorageType.EB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "PB", "EB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.ZB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "PB", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.YB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "PB", "YB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case Enum.Enum.StorageType.EB:
                            switch (TypeConvert)
                            {
                                case Enum.Enum.StorageType.Bit:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "EB", "Bit", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.Byte:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "EB", "Byte", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.KB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "EB", "KB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.MB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "EB", "MB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.GB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "EB", "GB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.TB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "EB", "TB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.PB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "EB", "PB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.EB:
                                    return Core.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enum.Enum.StorageType.ZB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "EB", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.YB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "EB", "YB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case Enum.Enum.StorageType.ZB:
                            switch (TypeConvert)
                            {
                                case Enum.Enum.StorageType.Bit:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "ZB", "Bit", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.Byte:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "ZB", "Byte", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.KB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "ZB", "KB", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.MB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "ZB", "MB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.GB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "ZB", "GB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.TB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "ZB", "TB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.PB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "ZB", "PB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.EB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "ZB", "EB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.ZB:
                                    return Core.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enum.Enum.StorageType.YB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "ZB", "YB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case Enum.Enum.StorageType.YB:
                            switch (TypeConvert)
                            {
                                case Enum.Enum.StorageType.Bit:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "YB", "Bit", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.Byte:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "YB", "Byte", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.KB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "YB", "KB", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.MB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "YB", "MB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.GB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "YB", "GB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.TB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "YB", "TB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.PB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "YB", "PB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.EB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "YB", "EB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.ZB:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("DataStorage", "YB", "ZB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.StorageType.YB:
                                    return Core.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                default:
                                    return Error;
                            }
                            break;
                        default:
                            return Error;
                    }
                    return Core.LastCheck(Variable, Decimal, Comma, PostComma, Error);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constant.Constant.ErrorTitle + "SE-DC1!)";
            }
        }
    }
}