#region Imports

using static Conforyon.Conforyon;
using System.Text.RegularExpressions;

#endregion

namespace Conforyon
{
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
                if (InputVariable.Length <= VariableLength && InputType >= TimeType.Microsecond && InputType <= TimeType.Year && PostComma >= PostCommaMinimum && PostComma <= PostCommaMaximum && !Regex.IsMatch(InputVariable, "[^0-9]") && !InputVariable.StartsWith("0") && UseCheck(InputVariable))
                {
                    TimeType Type = InputType;
                    if (InputType == TimeType.Year)
                        Type = TimeType.Year;
                    else
                    {
                        for (int i = (int)InputType; i <= (int)TimeType.Year; i++)
                        {
                            if (TimeConvert(InputVariable, InputType, (TimeType)i, true, true, 0, Error) == "0")
                            {
                                Type = (TimeType)i - 1;
                                break;
                            }
                            else
                            {
                                if ((TimeType)i == TimeType.Year)
                                    Type = (TimeType)i;
                            }
                        }
                    }

                    if (InputType != Type)
                    {
                        string Result = TimeConvert(InputVariable, InputType, Type, Decimal, Comma, PostComma, Error);
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
                if (InputVariable.Length <= VariableLength && InputType >= TimeType.Microsecond && InputType <= TimeType.Year && TypeConvert >= TimeType.Microsecond && TypeConvert <= TimeType.Year && PostComma >= PostCommaMinimum && PostComma <= PostCommaMaximum && !Regex.IsMatch(InputVariable, "[^0-9]") && !InputVariable.StartsWith("0") && UseCheck(InputVariable))
                {
                    switch (InputType)
                    {
                        case TimeType.Microsecond:
                            switch (TypeConvert)
                            {
                                case TimeType.Microsecond:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case TimeType.Millisecond:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Microsecond", "Millisecond", Error), Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Second:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Microsecond", "Second", Error), Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Minute:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Microsecond", "Minute", Error), Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Hour:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Microsecond", "Hour", Error), Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Day:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Microsecond", "Day", Error), Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Week:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Microsecond", "Week", Error), Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Year:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Microsecond", "Year", Error), Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case TimeType.Millisecond:
                            switch (TypeConvert)
                            {
                                case TimeType.Microsecond:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millisecond", "Microsecond", Error), Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Millisecond:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case TimeType.Second:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millisecond", "Second", Error), Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Minute:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millisecond", "Minute", Error), Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Hour:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millisecond", "Hour", Error), Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Day:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millisecond", "Day", Error), Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Week:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millisecond", "Week", Error), Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Year:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, GetValues("Time", "Millisecond", "Year", Error), Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case TimeType.Second:
                            switch (TypeConvert)
                            {
                                case TimeType.Microsecond:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1000000", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Millisecond:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1000", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Second:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case TimeType.Minute:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "0,016667", Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Hour:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "0,000278", Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Day:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "0,000012", Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Week:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "0,000002", Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Year:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "0,000000031688088", Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case TimeType.Minute:
                            switch (TypeConvert)
                            {
                                case TimeType.Microsecond:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "60000000", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Millisecond:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "60000", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Second:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "60", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Minute:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case TimeType.Hour:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "0,016667", Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Day:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "0,000694", Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Week:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "0,000099", Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Year:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "0,000002", Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case TimeType.Hour:
                            switch (TypeConvert)
                            {
                                case TimeType.Microsecond:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "3600000000", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Millisecond:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "3600000", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Second:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "3600", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Minute:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "60", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Hour:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case TimeType.Day:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "0,041667", Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Week:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "0,005952", Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Year:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "0,000114", Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case TimeType.Day:
                            switch (TypeConvert)
                            {
                                case TimeType.Microsecond:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "86400000000", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Millisecond:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "86400000", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Second:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "86400", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Minute:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "1440", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Hour:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "24", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Day:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case TimeType.Week:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "0,142857", Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Year:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "0,002738", Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case TimeType.Week:
                            switch (TypeConvert)
                            {
                                case TimeType.Microsecond:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "604800000000", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Millisecond:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "604800000", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Second:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "604800", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Minute:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "10080", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Hour:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "168", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Day:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "7", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Week:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case TimeType.Year:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "0,019165", Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case TimeType.Year:
                            switch (TypeConvert)
                            {
                                case TimeType.Microsecond:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "31557600000000", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Millisecond:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "31557600000", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Second:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "31557600", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Minute:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "525960", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Hour:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "8766", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Day:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "365,25", Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Week:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "52,17857", Comma, Error, true, false);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Year:
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
                return Error + ErrorTitle + "TE-TC1!)";
            }
        }
    }
}