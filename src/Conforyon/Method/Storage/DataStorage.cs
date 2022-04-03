#region Imports

using CC = Conforyon.Cores;
using CCC = Conforyon.Constant.Constants;
using CEEMT = Conforyon.Enum.Enums.MethodType;
using CEEST = Conforyon.Enum.Enums.StorageType;
using CVV = Conforyon.Value.Values;

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
        public static string AutoDataConvert(int InputVariable, CEEST InputType, bool TypeText = false, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            return AutoDataConvert($"{InputVariable}", InputType, TypeText, Decimal, Comma, PostComma, Error);
        }

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
        public static string AutoDataConvert(object InputVariable, CEEST InputType, bool TypeText = false, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            return AutoDataConvert($"{InputVariable}", InputType, TypeText, Decimal, Comma, PostComma, Error);
        }

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
        public static string AutoDataConvert(string InputVariable, CEEST InputType, bool TypeText = false, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (InputVariable.Length <= CCC.VariableLength && InputType >= CEEST.Bit && InputType <= CEEST.YB && PostComma >= CCC.PostCommaMinimum && PostComma <= CCC.PostCommaMaximum && CC.NumberControl(InputVariable, true) && !InputVariable.StartsWith("0") && CC.TextControl(InputVariable))
                {
                    CEEST Type = InputType;

                    if (InputType == CEEST.YB)
                    {
                        Type = CEEST.YB;
                    }
                    else
                    {
                        for (int i = (int)InputType; i <= (int)CEEST.YB; i++)
                        {
                            if (DataConvert(InputVariable, InputType, (CEEST)i, false, false, 0, Error) == "0")
                            {
                                Type = (CEEST)i - 1;
                                break;
                            }
                            else
                            {
                                if ((CEEST)i == CEEST.YB)
                                {
                                    Type = (CEEST)i;
                                }
                            }
                        }
                    }

                    string Result = string.Empty;

                    if (InputType != Type)
                    {
                        Result = DataConvert(InputVariable, InputType, Type, Decimal, Comma, PostComma, Error);
                    }
                    else
                    {
                        Result = CC.ResultFormat(InputVariable, Decimal, Comma, PostComma, Error);
                    }

                    if (!TypeText || Result == Error)
                    {
                        return Result;
                    }
                    else
                    {
                        return $"{Result} {Type}";
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "SE-ADC1!)";
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
        public static string DataConvert(int InputVariable, CEEST InputType, CEEST TypeConvert, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            return DataConvert($"{InputVariable}", InputType, TypeConvert, Decimal, Comma, PostComma, Error);
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
        public static string DataConvert(object InputVariable, CEEST InputType, CEEST TypeConvert, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            return DataConvert($"{InputVariable}", InputType, TypeConvert, Decimal, Comma, PostComma, Error);
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
        public static string DataConvert(string InputVariable, CEEST InputType, CEEST TypeConvert, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            try
            {
                string Variable;

                if (InputVariable.Length <= CCC.VariableLength && InputType >= CEEST.Bit && InputType <= CEEST.YB && TypeConvert >= CEEST.Bit && TypeConvert <= CEEST.YB && PostComma >= CCC.PostCommaMinimum && PostComma <= CCC.PostCommaMaximum && CC.NumberControl(InputVariable, true) && !InputVariable.StartsWith("0") && CC.TextControl(InputVariable))
                {
                    switch (InputType)
                    {
                        case CEEST.Bit:
                            switch (TypeConvert)
                            {
                                case CEEST.Bit:
                                    return CC.ResultFormat(InputVariable, Decimal, Comma, PostComma, Error);
                                case CEEST.Byte:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "Bit", "Byte", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.KB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "Bit", "KB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.MB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "Bit", "MB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.GB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "Bit", "GB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.TB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "Bit", "TB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.PB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "Bit", "PB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.EB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "Bit", "EB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.ZB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "Bit", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.YB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "Bit", "YB", Error), Comma, false, true, Error);
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
                        case CEEST.Byte:
                            switch (TypeConvert)
                            {
                                case CEEST.Bit:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "Byte", "Bit", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.Byte:
                                    return CC.ResultFormat(InputVariable, Decimal, Comma, PostComma, Error);
                                case CEEST.KB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "Byte", "KB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.MB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "Byte", "MB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.GB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "Byte", "GB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.TB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "Byte", "TB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.PB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "Byte", "PB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.EB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "Byte", "EB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.ZB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "Byte", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.YB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "Byte", "YB", Error), Comma, false, true, Error);
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
                        case CEEST.KB:
                            switch (TypeConvert)
                            {
                                case CEEST.Bit:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "KB", "Bit", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.Byte:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "KB", "Byte", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.KB:
                                    return CC.ResultFormat(InputVariable, Decimal, Comma, PostComma, Error);
                                case CEEST.MB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "KB", "MB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.GB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "KB", "GB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.TB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "KB", "TB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.PB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "KB", "PB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.EB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "KB", "EB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.ZB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "KB", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.YB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "KB", "YB", Error).ToString(), Comma, false, true, Error);
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
                        case CEEST.MB:
                            switch (TypeConvert)
                            {
                                case CEEST.Bit:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "MB", "Bit", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.Byte:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "MB", "Byte", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.KB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "MB", "KB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.MB:
                                    return CC.ResultFormat(InputVariable, Decimal, Comma, PostComma, Error);
                                case CEEST.GB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "MB", "GB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.TB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "MB", "TB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.PB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "MB", "PB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.EB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "MB", "EB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.ZB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "MB", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.YB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "MB", "YB", Error), Comma, false, true, Error);
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
                        case CEEST.GB:
                            switch (TypeConvert)
                            {
                                case CEEST.Bit:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "GB", "Bit", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.Byte:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "GB", "Byte", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.KB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "GB", "KB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.MB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "GB", "MB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.GB:
                                    return CC.ResultFormat(InputVariable, Decimal, Comma, PostComma, Error);
                                case CEEST.TB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "GB", "TB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.PB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "GB", "PB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.EB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "GB", "EB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.ZB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "GB", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.YB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "GB", "YB", Error), Comma, false, true, Error);
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
                        case CEEST.TB:
                            switch (TypeConvert)
                            {
                                case CEEST.Bit:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "TB", "Bit", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.Byte:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "TB", "Byte", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.KB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "TB", "KB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.MB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "TB", "MB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.GB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "TB", "GB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.TB:
                                    return CC.ResultFormat(InputVariable, Decimal, Comma, PostComma, Error);
                                case CEEST.PB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "TB", "PB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.EB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "TB", "EB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.ZB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "TB", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.YB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "TB", "YB", Error), Comma, false, true, Error);
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
                        case CEEST.PB:
                            switch (TypeConvert)
                            {
                                case CEEST.Bit:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "PB", "Bit", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.Byte:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "PB", "Byte", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.KB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "PB", "KB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.MB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "PB", "MB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.GB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "PB", "GB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.TB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "PB", "TB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.PB:
                                    return CC.ResultFormat(InputVariable, Decimal, Comma, PostComma, Error);
                                case CEEST.EB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "PB", "EB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.ZB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "PB", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.YB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "PB", "YB", Error), Comma, false, true, Error);
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
                        case CEEST.EB:
                            switch (TypeConvert)
                            {
                                case CEEST.Bit:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "EB", "Bit", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.Byte:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "EB", "Byte", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.KB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "EB", "KB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.MB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "EB", "MB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.GB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "EB", "GB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.TB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "EB", "TB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.PB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "EB", "PB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.EB:
                                    return CC.ResultFormat(InputVariable, Decimal, Comma, PostComma, Error);
                                case CEEST.ZB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "EB", "ZB", Error), Comma, false, true, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.YB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "EB", "YB", Error), Comma, false, true, Error);
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
                        case CEEST.ZB:
                            switch (TypeConvert)
                            {
                                case CEEST.Bit:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "ZB", "Bit", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.Byte:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "ZB", "Byte", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.KB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "ZB", "KB", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.MB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "ZB", "MB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.GB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "ZB", "GB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.TB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "ZB", "TB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.PB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "ZB", "PB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.EB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "ZB", "EB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.ZB:
                                    return CC.ResultFormat(InputVariable, Decimal, Comma, PostComma, Error);
                                case CEEST.YB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "ZB", "YB", Error), Comma, false, true, Error);
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
                        case CEEST.YB:
                            switch (TypeConvert)
                            {
                                case CEEST.Bit:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "YB", "Bit", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.Byte:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "YB", "Byte", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.KB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "YB", "KB", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.MB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "YB", "MB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.GB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "YB", "GB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.TB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "YB", "TB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.PB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "YB", "PB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.EB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "YB", "EB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.ZB:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.DataStorage, "YB", "ZB", Error), Comma, false, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEEST.YB:
                                    return CC.ResultFormat(InputVariable, Decimal, Comma, PostComma, Error);
                                default:
                                    return Error;
                            }
                            break;
                        default:
                            return Error;
                    }

                    return CC.ResultFormat(Variable, Decimal, Comma, PostComma, Error);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "SE-DC1!)";
            }
        }

        #endregion
    }
}