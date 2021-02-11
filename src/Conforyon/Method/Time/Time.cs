#region Imports

using System.Text.RegularExpressions;

#endregion

namespace Conforyon.Time
{
    /// <summary>
    /// 
    /// </summary>
    public class Time
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
        public static string AutoTimeConvert(string InputVariable, Enum.Enum.TimeType InputType, bool TypeText = false, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                if (InputVariable.Length <= Constant.Constant.VariableLength && InputType >= Enum.Enum.TimeType.Nanosecond && InputType <= Enum.Enum.TimeType.Millennium && PostComma >= Constant.Constant.PostCommaMinimum && PostComma <= Constant.Constant.PostCommaMaximum && !Regex.IsMatch(InputVariable, "[^0-9]") && !InputVariable.StartsWith("0") && Core.UseCheck(InputVariable))
                {
                    Enum.Enum.TimeType Type = InputType;
                    if (InputType == Enum.Enum.TimeType.Millennium)
                    {
                        Type = Enum.Enum.TimeType.Millennium;
                    }
                    else
                    {
                        for (int i = (int)InputType; i <= (int)Enum.Enum.TimeType.Millennium; i++)
                        {
                            if (TimeConvert(InputVariable, InputType, (Enum.Enum.TimeType)i, true, true, 0, Error) == "0")
                            {
                                Type = (Enum.Enum.TimeType)i - 1;
                                break;
                            }
                            else
                            {
                                if ((Enum.Enum.TimeType)i == Enum.Enum.TimeType.Millennium)
                                {
                                    Type = (Enum.Enum.TimeType)i;
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
                return Error + Constant.Constant.ErrorTitle + "TE-ATC1!)";
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
        public static string TimeConvert(string InputVariable, Enum.Enum.TimeType InputType, Enum.Enum.TimeType TypeConvert, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                string Variable;
                if (InputVariable.Length <= Constant.Constant.VariableLength && InputType >= Enum.Enum.TimeType.Nanosecond && InputType <= Enum.Enum.TimeType.Millennium && TypeConvert >= Enum.Enum.TimeType.Nanosecond && TypeConvert <= Enum.Enum.TimeType.Millennium && PostComma >= Constant.Constant.PostCommaMinimum && PostComma <= Constant.Constant.PostCommaMaximum && !Regex.IsMatch(InputVariable, "[^0-9]") && !InputVariable.StartsWith("0") && Core.UseCheck(InputVariable))
                {
                    switch (InputType)
                    {
                        case Enum.Enum.TimeType.Nanosecond:
                            switch (TypeConvert)
                            {
                                case Enum.Enum.TimeType.Nanosecond:
                                    return Core.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enum.Enum.TimeType.Microsecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Nanosecond", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Millisecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Nanosecond", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Second:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Nanosecond", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Minute:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Nanosecond", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Hour:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Nanosecond", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Day:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Nanosecond", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Week:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Nanosecond", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Year:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Nanosecond", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Century:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Nanosecond", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Millennium:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Nanosecond", "Millennium", Error), Comma, true, false, Error);
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
                        case Enum.Enum.TimeType.Microsecond:
                            switch (TypeConvert)
                            {
                                case Enum.Enum.TimeType.Nanosecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Microsecond", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Microsecond:
                                    return Core.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enum.Enum.TimeType.Millisecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Microsecond", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Second:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Microsecond", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Minute:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Microsecond", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Hour:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Microsecond", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Day:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Microsecond", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Week:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Microsecond", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Year:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Microsecond", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Century:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Microsecond", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Millennium:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Microsecond", "Millennium", Error), Comma, true, false, Error);
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
                        case Enum.Enum.TimeType.Millisecond:
                            switch (TypeConvert)
                            {
                                case Enum.Enum.TimeType.Nanosecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Millisecond", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Microsecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Millisecond", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Millisecond:
                                    return Core.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enum.Enum.TimeType.Second:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Millisecond", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Minute:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Millisecond", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Hour:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Millisecond", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Day:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Millisecond", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Week:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Millisecond", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Year:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Millisecond", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Century:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Millisecond", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Millennium:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Millisecond", "Millennium", Error), Comma, true, false, Error);
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
                        case Enum.Enum.TimeType.Second:
                            switch (TypeConvert)
                            {
                                case Enum.Enum.TimeType.Nanosecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Second", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Microsecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Second", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Millisecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Second", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Second:
                                    return Core.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enum.Enum.TimeType.Minute:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Second", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Hour:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Second", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Day:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Second", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Week:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Second", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Year:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Second", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Century:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Second", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Millennium:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Second", "Millennium", Error), Comma, true, false, Error);
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
                        case Enum.Enum.TimeType.Minute:
                            switch (TypeConvert)
                            {
                                case Enum.Enum.TimeType.Nanosecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Minute", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Microsecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Minute", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Millisecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Minute", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Second:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Minute", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Minute:
                                    return Core.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enum.Enum.TimeType.Hour:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Minute", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Day:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Minute", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Week:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Minute", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Year:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Minute", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Century:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Minute", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Millennium:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Minute", "Millennium", Error), Comma, true, false, Error);
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
                        case Enum.Enum.TimeType.Hour:
                            switch (TypeConvert)
                            {
                                case Enum.Enum.TimeType.Nanosecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Hour", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Microsecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Hour", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Millisecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Hour", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Second:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Hour", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Minute:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Hour", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Hour:
                                    return Core.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enum.Enum.TimeType.Day:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Hour", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Week:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Hour", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Year:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Hour", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Century:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Hour", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Millennium:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Hour", "Millennium", Error), Comma, true, false, Error);
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
                        case Enum.Enum.TimeType.Day:
                            switch (TypeConvert)
                            {
                                case Enum.Enum.TimeType.Nanosecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Day", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Microsecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Day", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Millisecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Day", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Second:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Day", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Minute:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Day", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Hour:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Day", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Day:
                                    return Core.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enum.Enum.TimeType.Week:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Day", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Year:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Day", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Century:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Day", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Millennium:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Day", "Millennium", Error), Comma, true, false, Error);
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
                        case Enum.Enum.TimeType.Week:
                            switch (TypeConvert)
                            {
                                case Enum.Enum.TimeType.Nanosecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Week", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Microsecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Week", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Millisecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Week", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Second:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Week", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Minute:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Week", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Hour:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Week", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Day:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Week", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Week:
                                    return Core.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enum.Enum.TimeType.Year:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Week", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Century:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Week", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Millennium:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Week", "Millennium", Error), Comma, true, false, Error);
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
                        case Enum.Enum.TimeType.Year:
                            switch (TypeConvert)
                            {
                                case Enum.Enum.TimeType.Nanosecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Year", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Microsecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Year", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Millisecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Year", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Second:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Year", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Minute:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Year", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Hour:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Year", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Day:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Year", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Week:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Year", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Year:
                                    return Core.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enum.Enum.TimeType.Century:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Year", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Millennium:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Year", "Millennium", Error), Comma, true, false, Error);
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
                        case Enum.Enum.TimeType.Century:
                            switch (TypeConvert)
                            {
                                case Enum.Enum.TimeType.Nanosecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Century", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Microsecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Century", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Millisecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Century", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Second:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Century", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Minute:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Century", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Hour:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Century", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Day:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Century", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Week:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Century", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Year:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Century", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Century:
                                    return Core.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enum.Enum.TimeType.Millennium:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Century", "Millennium", Error), Comma, true, false, Error);
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
                        case Enum.Enum.TimeType.Millennium:
                            switch (TypeConvert)
                            {
                                case Enum.Enum.TimeType.Nanosecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Millennium", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Microsecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Millennium", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Millisecond:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Millennium", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Second:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Millennium", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Minute:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Millennium", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Hour:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Millennium", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Day:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Millennium", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Week:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Millennium", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Year:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Millennium", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Century:
                                    if (Core.NumberCheck(InputVariable))
                                    {
                                        Variable = Core.VariableFormat(InputVariable, Value.Value.GetValue("Time", "Millennium", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enum.Enum.TimeType.Millennium:
                                    return Core.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                default:
                                    return Error;
                            }
                            break;
                        default:
                            return Error;
                    }
                    if (!Comma)
                    {
                        return Core.LastCheck(Variable, Decimal, !Comma, 0, Error);
                    }
                    else
                    {
                        return Core.LastCheck(Variable, Decimal, Comma, PostComma, Error);
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constant.Constant.ErrorTitle + "TE-TC1!)";
            }
        }
    }
}