#region Imports

using Conforyon.Constant;
using Conforyon.Enum;
using Conforyon.Value;
using System.Text.RegularExpressions;
using CEEMT = Conforyon.Enum.Enums.MethodType;

#endregion

namespace Conforyon.Storage
{
    /// <summary>
    /// 
    /// </summary>
    public class DataStorage
    {
        #region DataStorage
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
        public static string AutoDataConvert(string InputVariable, Enums.StorageType InputType, bool TypeText = false, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (InputVariable.Length <= Constants.VariableLength && InputType >= Enums.StorageType.Bit && InputType <= Enums.StorageType.YB && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && !Regex.IsMatch(InputVariable, "[^0-9]") && !InputVariable.StartsWith("0") && Cores.TextControl(InputVariable))
                {
                    Enums.StorageType Type = InputType;
                    if (InputType == Enums.StorageType.YB)
                    {
                        Type = Enums.StorageType.YB;
                    }
                    else
                    {
                        for (int i = (int)InputType; i <= (int)Enums.StorageType.YB; i++)
                        {
                            if (DataConvert(InputVariable, InputType, (Enums.StorageType)i, false, false, 0, Error) == "0")
                            {
                                Type = (Enums.StorageType)i - 1;
                                break;
                            }
                            else
                            {
                                if ((Enums.StorageType)i == Enums.StorageType.YB)
                                {
                                    Type = (Enums.StorageType)i;
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
                                Result = Cores.UseDecimal(InputVariable);
                            }
                            else if (!Decimal && Comma)
                            {
                                Result = Cores.UseComma(InputVariable, PostComma);
                            }
                            else
                            {
                                Result = Cores.DecimalComma(InputVariable, PostComma);
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
                return Error + Constants.ErrorTitle + "SE-ADC1!)";
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
        public static string DataConvert(string InputVariable, Enums.StorageType InputType, Enums.StorageType TypeConvert, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = Constants.ErrorMessage)
        {
            try
            {
                string Variable;
                if (InputVariable.Length <= Constants.VariableLength && InputType >= Enums.StorageType.Bit && InputType <= Enums.StorageType.YB && TypeConvert >= Enums.StorageType.Bit && TypeConvert <= Enums.StorageType.YB && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && !Regex.IsMatch(InputVariable, "[^0-9]") && !InputVariable.StartsWith("0") && Cores.TextControl(InputVariable))
                {
                    switch (InputType)
                    {
                        case Enums.StorageType.Bit:
                            switch (TypeConvert)
                            {
                                case Enums.StorageType.Bit:
                                    return Cores.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enums.StorageType.Byte:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "Bit", "Byte", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.KB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "Bit", "KB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.MB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "Bit", "MB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.GB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "Bit", "GB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.TB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "Bit", "TB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.PB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "Bit", "PB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.EB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "Bit", "EB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.ZB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "Bit", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.YB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "Bit", "YB", Error), Comma, false, true, Error);
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
                        case Enums.StorageType.Byte:
                            switch (TypeConvert)
                            {
                                case Enums.StorageType.Bit:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "Byte", "Bit", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.Byte:
                                    return Cores.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enums.StorageType.KB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "Byte", "KB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.MB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "Byte", "MB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.GB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "Byte", "GB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.TB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "Byte", "TB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.PB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "Byte", "PB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.EB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "Byte", "EB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.ZB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "Byte", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.YB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "Byte", "YB", Error), Comma, false, true, Error);
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
                        case Enums.StorageType.KB:
                            switch (TypeConvert)
                            {
                                case Enums.StorageType.Bit:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "KB", "Bit", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.Byte:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "KB", "Byte", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.KB:
                                    return Cores.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enums.StorageType.MB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "KB", "MB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.GB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "KB", "GB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.TB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "KB", "TB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.PB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "KB", "PB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.EB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "KB", "EB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.ZB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "KB", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.YB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "KB", "YB", Error).ToString(), Comma, false, true, Error);
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
                        case Enums.StorageType.MB:
                            switch (TypeConvert)
                            {
                                case Enums.StorageType.Bit:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "MB", "Bit", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.Byte:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "MB", "Byte", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.KB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "MB", "KB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.MB:
                                    return Cores.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enums.StorageType.GB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "MB", "GB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.TB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "MB", "TB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.PB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "MB", "PB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.EB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "MB", "EB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.ZB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "MB", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.YB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "MB", "YB", Error), Comma, false, true, Error);
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
                        case Enums.StorageType.GB:
                            switch (TypeConvert)
                            {
                                case Enums.StorageType.Bit:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "GB", "Bit", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.Byte:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "GB", "Byte", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.KB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "GB", "KB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.MB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "GB", "MB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.GB:
                                    return Cores.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enums.StorageType.TB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "GB", "TB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.PB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "GB", "PB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.EB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "GB", "EB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.ZB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "GB", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.YB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "GB", "YB", Error), Comma, false, true, Error);
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
                        case Enums.StorageType.TB:
                            switch (TypeConvert)
                            {
                                case Enums.StorageType.Bit:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "TB", "Bit", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.Byte:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "TB", "Byte", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.KB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "TB", "KB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.MB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "TB", "MB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.GB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "TB", "GB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.TB:
                                    return Cores.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enums.StorageType.PB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "TB", "PB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.EB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "TB", "EB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.ZB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "TB", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.YB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "TB", "YB", Error), Comma, false, true, Error);
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
                        case Enums.StorageType.PB:
                            switch (TypeConvert)
                            {
                                case Enums.StorageType.Bit:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "PB", "Bit", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.Byte:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "PB", "Byte", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.KB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "PB", "KB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.MB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "PB", "MB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.GB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "PB", "GB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.TB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "PB", "TB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.PB:
                                    return Cores.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enums.StorageType.EB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "PB", "EB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.ZB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "PB", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.YB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "PB", "YB", Error), Comma, false, true, Error);
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
                        case Enums.StorageType.EB:
                            switch (TypeConvert)
                            {
                                case Enums.StorageType.Bit:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "EB", "Bit", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.Byte:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "EB", "Byte", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.KB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "EB", "KB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.MB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "EB", "MB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.GB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "EB", "GB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.TB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "EB", "TB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.PB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "EB", "PB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.EB:
                                    return Cores.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enums.StorageType.ZB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "EB", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.YB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "EB", "YB", Error), Comma, false, true, Error);
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
                        case Enums.StorageType.ZB:
                            switch (TypeConvert)
                            {
                                case Enums.StorageType.Bit:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "ZB", "Bit", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.Byte:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "ZB", "Byte", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.KB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "ZB", "KB", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.MB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "ZB", "MB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.GB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "ZB", "GB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.TB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "ZB", "TB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.PB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "ZB", "PB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.EB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "ZB", "EB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.ZB:
                                    return Cores.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enums.StorageType.YB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "ZB", "YB", Error), Comma, false, true, Error);
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
                        case Enums.StorageType.YB:
                            switch (TypeConvert)
                            {
                                case Enums.StorageType.Bit:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "YB", "Bit", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.Byte:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "YB", "Byte", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.KB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "YB", "KB", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.MB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "YB", "MB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.GB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "YB", "GB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.TB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "YB", "TB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.PB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "YB", "PB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.EB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "YB", "EB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.ZB:
                                    if (Cores.NumberControl(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue(CEEMT.DataStorage, "YB", "ZB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.StorageType.YB:
                                    return Cores.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                default:
                                    return Error;
                            }
                            break;
                        default:
                            return Error;
                    }
                    return Cores.LastCheck(Variable, Decimal, Comma, PostComma, Error);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "SE-DC1!)";
            }
        }
        #endregion
    }
}