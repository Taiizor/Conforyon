#region Imports

using static Conforyon.Conforyon;
using static Conforyon.Enum.Enum;
using System.Text.RegularExpressions;
using static Conforyon.Constant.Constant;

#endregion

namespace Conforyon
{
    /// <summary>
    /// 
    /// </summary>
    public static class Time
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
        public static string AutoTimeConvert(string InputVariable, TimeType InputType, bool TypeText = false, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (InputVariable.Length <= VariableLength && InputType >= TimeType.Nanosecond && InputType <= TimeType.Millennium && PostComma >= PostCommaMinimum && PostComma <= PostCommaMaximum && !Regex.IsMatch(InputVariable, "[^0-9]") && !InputVariable.StartsWith("0") && UseCheck(InputVariable))
                {
                    TimeType Type = InputType;
                    if (InputType == TimeType.Millennium)
                    {
                        Type = TimeType.Millennium;
                    }
                    else
                    {
                        for (int i = (int)InputType; i <= (int)TimeType.Millennium; i++)
                        {
                            if (TimeConvert(InputVariable, InputType, (TimeType)i, true, true, 0, Error) == "0")
                            {
                                Type = (TimeType)i - 1;
                                break;
                            }
                            else
                            {
                                if ((TimeType)i == TimeType.Millennium)
                                {
                                    Type = (TimeType)i;
                                }
                            }
                        }
                    }

                    if (InputType != Type)
                    {
                        string Result = TimeConvert(InputVariable, InputType, Type, Decimal, Comma, PostComma, Error);
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
                                Result = UseDecimal(InputVariable);
                            }
                            else if (!Decimal && Comma)
                            {
                                Result = UseComma(InputVariable, PostComma);
                            }
                            else
                            {
                                Result = DecimalComma(InputVariable, PostComma);
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
                return Error + ErrorTitle + "TE-ATC1!)";
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
        public static string TimeConvert(string InputVariable, TimeType InputType, TimeType TypeConvert, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                string Variable;
                if (InputVariable.Length <= VariableLength && InputType >= TimeType.Nanosecond && InputType <= TimeType.Millennium && TypeConvert >= TimeType.Nanosecond && TypeConvert <= TimeType.Millennium && PostComma >= PostCommaMinimum && PostComma <= PostCommaMaximum && !Regex.IsMatch(InputVariable, "[^0-9]") && !InputVariable.StartsWith("0") && UseCheck(InputVariable))
                {
                    switch (InputType)
                    {
                        case TimeType.Nanosecond:
                            switch (TypeConvert)
                            {
                                case TimeType.Nanosecond:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case TimeType.Microsecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Nanosecond", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Millisecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Nanosecond", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Second:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Nanosecond", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Minute:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Nanosecond", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Hour:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Nanosecond", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Day:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Nanosecond", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Week:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Nanosecond", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Year:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Nanosecond", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Century:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Nanosecond", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Millennium:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Nanosecond", "Millennium", Error), Comma, true, false, Error);
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
                        case TimeType.Microsecond:
                            switch (TypeConvert)
                            {
                                case TimeType.Nanosecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Microsecond", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Microsecond:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case TimeType.Millisecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Microsecond", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Second:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Microsecond", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Minute:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Microsecond", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Hour:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Microsecond", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Day:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Microsecond", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Week:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Microsecond", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Year:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Microsecond", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Century:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Microsecond", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Millennium:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Microsecond", "Millennium", Error), Comma, true, false, Error);
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
                        case TimeType.Millisecond:
                            switch (TypeConvert)
                            {
                                case TimeType.Nanosecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millisecond", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Microsecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millisecond", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Millisecond:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case TimeType.Second:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millisecond", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Minute:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millisecond", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Hour:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millisecond", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Day:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millisecond", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Week:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millisecond", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Year:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millisecond", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Century:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millisecond", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Millennium:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millisecond", "Millennium", Error), Comma, true, false, Error);
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
                        case TimeType.Second:
                            switch (TypeConvert)
                            {
                                case TimeType.Nanosecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Second", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Microsecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Second", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Millisecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Second", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Second:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case TimeType.Minute:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Second", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Hour:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Second", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Day:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Second", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Week:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Second", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Year:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Second", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Century:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Second", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Millennium:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Second", "Millennium", Error), Comma, true, false, Error);
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
                        case TimeType.Minute:
                            switch (TypeConvert)
                            {
                                case TimeType.Nanosecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Minute", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Microsecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Minute", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Millisecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Minute", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Second:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Minute", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Minute:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case TimeType.Hour:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Minute", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Day:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Minute", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Week:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Minute", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Year:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Minute", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Century:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Minute", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Millennium:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Minute", "Millennium", Error), Comma, true, false, Error);
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
                        case TimeType.Hour:
                            switch (TypeConvert)
                            {
                                case TimeType.Nanosecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Hour", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Microsecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Hour", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Millisecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Hour", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Second:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Hour", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Minute:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Hour", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Hour:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case TimeType.Day:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Hour", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Week:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Hour", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Year:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Hour", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Century:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Hour", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Millennium:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Hour", "Millennium", Error), Comma, true, false, Error);
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
                        case TimeType.Day:
                            switch (TypeConvert)
                            {
                                case TimeType.Nanosecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Day", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Microsecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Day", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Millisecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Day", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Second:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Day", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Minute:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Day", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Hour:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Day", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Day:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case TimeType.Week:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Day", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Year:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Day", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Century:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Day", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Millennium:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Day", "Millennium", Error), Comma, true, false, Error);
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
                        case TimeType.Week:
                            switch (TypeConvert)
                            {
                                case TimeType.Nanosecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Week", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Microsecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Week", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Millisecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Week", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Second:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Week", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Minute:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Week", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Hour:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Week", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Day:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Week", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Week:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case TimeType.Year:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Week", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Century:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Week", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Millennium:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Week", "Millennium", Error), Comma, true, false, Error);
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
                        case TimeType.Year:
                            switch (TypeConvert)
                            {
                                case TimeType.Nanosecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Year", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Microsecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Year", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Millisecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Year", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Second:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Year", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Minute:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Year", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Hour:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Year", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Day:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Year", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Week:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Year", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Year:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case TimeType.Century:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Year", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Millennium:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Year", "Millennium", Error), Comma, true, false, Error);
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
                        case TimeType.Century:
                            switch (TypeConvert)
                            {
                                case TimeType.Nanosecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Century", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Microsecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Century", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Millisecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Century", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Second:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Century", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Minute:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Century", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Hour:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Century", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Day:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Century", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Week:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Century", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Year:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Century", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Century:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case TimeType.Millennium:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Century", "Millennium", Error), Comma, true, false, Error);
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
                        case TimeType.Millennium:
                            switch (TypeConvert)
                            {
                                case TimeType.Nanosecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millennium", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Microsecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millennium", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Millisecond:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millennium", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Second:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millennium", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Minute:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millennium", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Hour:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millennium", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Day:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millennium", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Week:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millennium", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Year:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millennium", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Century:
                                    if (NumberCheck(InputVariable))
                                    {
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millennium", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case TimeType.Millennium:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                default:
                                    return Error;
                            }
                            break;
                        default:
                            return Error;
                    }
                    if (!Comma)
                    {
                        return LastCheck(Variable, Decimal, !Comma, 0, Error);
                    }
                    else
                    {
                        return LastCheck(Variable, Decimal, Comma, PostComma, Error);
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + ErrorTitle + "TE-TC1!)";
            }
        }
    }
}