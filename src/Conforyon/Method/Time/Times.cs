#region Imports

using CC = Conforyon.Cores;
using CCC = Conforyon.Constant.Constants;
using CEEMT = Conforyon.Enum.Enums.MethodType;
using CEETT = Conforyon.Enum.Enums.TimeType;
using CVV = Conforyon.Value.Values;

#endregion

namespace Conforyon.Time
{
    /// <summary>
    /// 
    /// </summary>
    public class Times
    {
        #region Times

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
        public static string AutoTimeConvert(int InputVariable, CEETT InputType, bool TypeText = false, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            return AutoTimeConvert($"{InputVariable}", InputType, TypeText, Decimal, Comma, PostComma, Error);
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
        public static string AutoTimeConvert(object InputVariable, CEETT InputType, bool TypeText = false, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            return AutoTimeConvert($"{InputVariable}", InputType, TypeText, Decimal, Comma, PostComma, Error);
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
        public static string AutoTimeConvert(string InputVariable, CEETT InputType, bool TypeText = false, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (InputVariable.Length <= CCC.VariableLength && InputType >= CEETT.Nanosecond && InputType <= CEETT.Millennium && PostComma >= CCC.PostCommaMinimum && PostComma <= CCC.PostCommaMaximum && CC.NumberControl(InputVariable, true) && !InputVariable.StartsWith("0") && CC.TextControl(InputVariable))
                {
                    CEETT Type = InputType;

                    if (InputType == CEETT.Millennium)
                    {
                        Type = CEETT.Millennium;
                    }
                    else
                    {
                        for (int i = (int)InputType; i <= (int)CEETT.Millennium; i++)
                        {
                            if (TimeConvert(InputVariable, InputType, (CEETT)i, true, true, 0, Error) == "0")
                            {
                                Type = (CEETT)i - 1;
                                break;
                            }
                            else
                            {
                                if ((CEETT)i == CEETT.Millennium)
                                {
                                    Type = (CEETT)i;
                                }
                            }
                        }
                    }

                    string Result = string.Empty;

                    if (InputType != Type)
                    {
                        Result = TimeConvert(InputVariable, InputType, Type, Decimal, Comma, PostComma, Error);
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
                return Error + CCC.ErrorTitle + "TE-ATC1!)";
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
        public static string TimeConvert(int InputVariable, CEETT InputType, CEETT TypeConvert, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            return TimeConvert($"{InputVariable}", InputType, TypeConvert, Decimal, Comma, PostComma, Error);
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
        public static string TimeConvert(string InputVariable, CEETT InputType, CEETT TypeConvert, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = CCC.ErrorMessage)
        {
            try
            {
                string Variable;

                if (InputVariable.Length <= CCC.VariableLength && InputType >= CEETT.Nanosecond && InputType <= CEETT.Millennium && TypeConvert >= CEETT.Nanosecond && TypeConvert <= CEETT.Millennium && PostComma >= CCC.PostCommaMinimum && PostComma <= CCC.PostCommaMaximum && CC.NumberControl(InputVariable, true) && !InputVariable.StartsWith("0") && CC.TextControl(InputVariable))
                {
                    switch (InputType)
                    {
                        case CEETT.Nanosecond:
                            switch (TypeConvert)
                            {
                                case CEETT.Nanosecond:
                                    return CC.ResultFormat(InputVariable, Decimal, Comma, PostComma, Error);
                                case CEETT.Microsecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Nanosecond", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Millisecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Nanosecond", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Second:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Nanosecond", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Minute:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Nanosecond", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Hour:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Nanosecond", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Day:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Nanosecond", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Week:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Nanosecond", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Year:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Nanosecond", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Century:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Nanosecond", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Millennium:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Nanosecond", "Millennium", Error), Comma, true, false, Error);
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
                        case CEETT.Microsecond:
                            switch (TypeConvert)
                            {
                                case CEETT.Nanosecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Microsecond", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Microsecond:
                                    return CC.ResultFormat(InputVariable, Decimal, Comma, PostComma, Error);
                                case CEETT.Millisecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Microsecond", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Second:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Microsecond", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Minute:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Microsecond", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Hour:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Microsecond", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Day:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Microsecond", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Week:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Microsecond", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Year:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Microsecond", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Century:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Microsecond", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Millennium:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Microsecond", "Millennium", Error), Comma, true, false, Error);
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
                        case CEETT.Millisecond:
                            switch (TypeConvert)
                            {
                                case CEETT.Nanosecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Millisecond", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Microsecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Millisecond", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Millisecond:
                                    return CC.ResultFormat(InputVariable, Decimal, Comma, PostComma, Error);
                                case CEETT.Second:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Millisecond", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Minute:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Millisecond", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Hour:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Millisecond", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Day:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Millisecond", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Week:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Millisecond", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Year:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Millisecond", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Century:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Millisecond", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Millennium:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Millisecond", "Millennium", Error), Comma, true, false, Error);
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
                        case CEETT.Second:
                            switch (TypeConvert)
                            {
                                case CEETT.Nanosecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Second", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Microsecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Second", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Millisecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Second", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Second:
                                    return CC.ResultFormat(InputVariable, Decimal, Comma, PostComma, Error);
                                case CEETT.Minute:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Second", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Hour:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Second", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Day:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Second", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Week:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Second", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Year:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Second", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Century:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Second", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Millennium:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Second", "Millennium", Error), Comma, true, false, Error);
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
                        case CEETT.Minute:
                            switch (TypeConvert)
                            {
                                case CEETT.Nanosecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Minute", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Microsecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Minute", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Millisecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Minute", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Second:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Minute", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Minute:
                                    return CC.ResultFormat(InputVariable, Decimal, Comma, PostComma, Error);
                                case CEETT.Hour:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Minute", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Day:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Minute", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Week:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Minute", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Year:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Minute", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Century:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Minute", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Millennium:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Minute", "Millennium", Error), Comma, true, false, Error);
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
                        case CEETT.Hour:
                            switch (TypeConvert)
                            {
                                case CEETT.Nanosecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Hour", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Microsecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Hour", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Millisecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Hour", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Second:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Hour", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Minute:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Hour", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Hour:
                                    return CC.ResultFormat(InputVariable, Decimal, Comma, PostComma, Error);
                                case CEETT.Day:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Hour", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Week:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Hour", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Year:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Hour", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Century:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Hour", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Millennium:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Hour", "Millennium", Error), Comma, true, false, Error);
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
                        case CEETT.Day:
                            switch (TypeConvert)
                            {
                                case CEETT.Nanosecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Day", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Microsecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Day", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Millisecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Day", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Second:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Day", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Minute:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Day", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Hour:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Day", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Day:
                                    return CC.ResultFormat(InputVariable, Decimal, Comma, PostComma, Error);
                                case CEETT.Week:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Day", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Year:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Day", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Century:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Day", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Millennium:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Day", "Millennium", Error), Comma, true, false, Error);
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
                        case CEETT.Week:
                            switch (TypeConvert)
                            {
                                case CEETT.Nanosecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Week", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Microsecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Week", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Millisecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Week", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Second:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Week", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Minute:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Week", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Hour:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Week", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Day:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Week", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Week:
                                    return CC.ResultFormat(InputVariable, Decimal, Comma, PostComma, Error);
                                case CEETT.Year:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Week", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Century:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Week", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Millennium:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Week", "Millennium", Error), Comma, true, false, Error);
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
                        case CEETT.Year:
                            switch (TypeConvert)
                            {
                                case CEETT.Nanosecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Year", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Microsecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Year", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Millisecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Year", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Second:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Year", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Minute:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Year", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Hour:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Year", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Day:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Year", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Week:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Year", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Year:
                                    return CC.ResultFormat(InputVariable, Decimal, Comma, PostComma, Error);
                                case CEETT.Century:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Year", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Millennium:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Year", "Millennium", Error), Comma, true, false, Error);
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
                        case CEETT.Century:
                            switch (TypeConvert)
                            {
                                case CEETT.Nanosecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Century", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Microsecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Century", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Millisecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Century", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Second:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Century", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Minute:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Century", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Hour:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Century", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Day:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Century", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Week:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Century", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Year:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Century", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Century:
                                    return CC.ResultFormat(InputVariable, Decimal, Comma, PostComma, Error);
                                case CEETT.Millennium:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Century", "Millennium", Error), Comma, true, false, Error);
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
                        case CEETT.Millennium:
                            switch (TypeConvert)
                            {
                                case CEETT.Nanosecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Millennium", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Microsecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Millennium", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Millisecond:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Millennium", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Second:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Millennium", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Minute:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Millennium", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Hour:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Millennium", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Day:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Millennium", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Week:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Millennium", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Year:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Millennium", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Century:
                                    if (CC.NumberControl(InputVariable))
                                    {
                                        Variable = CC.VariableFormat(InputVariable, CVV.GetValue(CEEMT.Time, "Millennium", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case CEETT.Millennium:
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
                return Error + CCC.ErrorTitle + "TE-TC1!)";
            }
        }

        #endregion
    }
}