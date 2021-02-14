#region Imports

using Conforyon.Constant;
using Conforyon.Enum;
using Conforyon.Value;
using System.Text.RegularExpressions;

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
        public static string AutoTimeConvert(string InputVariable, Enums.TimeType InputType, bool TypeText = false, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (InputVariable.Length <= Constants.VariableLength && InputType >= Enums.TimeType.Nanosecond && InputType <= Enums.TimeType.Millennium && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && !Regex.IsMatch(InputVariable, "[^0-9]") && !InputVariable.StartsWith("0") && Cores.UseCheck(InputVariable))
                {
                    Enums.TimeType Type = InputType;
                    if (InputType == Enums.TimeType.Millennium)
                    {
                        Type = Enums.TimeType.Millennium;
                    }
                    else
                    {
                        for (int i = (int)InputType; i <= (int)Enums.TimeType.Millennium; i++)
                        {
                            if (TimeConvert(InputVariable, InputType, (Enums.TimeType)i, true, true, 0, Error) == "0")
                            {
                                Type = (Enums.TimeType)i - 1;
                                break;
                            }
                            else
                            {
                                if ((Enums.TimeType)i == Enums.TimeType.Millennium)
                                {
                                    Type = (Enums.TimeType)i;
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
                return Error + Constants.ErrorTitle + "TS-ATC1!)";
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
        public static string TimeConvert(string InputVariable, Enums.TimeType InputType, Enums.TimeType TypeConvert, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = Constants.ErrorMessage)
        {
            try
            {
                string Variable;
                if (InputVariable.Length <= Constants.VariableLength && InputType >= Enums.TimeType.Nanosecond && InputType <= Enums.TimeType.Millennium && TypeConvert >= Enums.TimeType.Nanosecond && TypeConvert <= Enums.TimeType.Millennium && PostComma >= Constants.PostCommaMinimum && PostComma <= Constants.PostCommaMaximum && !Regex.IsMatch(InputVariable, "[^0-9]") && !InputVariable.StartsWith("0") && Cores.UseCheck(InputVariable))
                {
                    switch (InputType)
                    {
                        case Enums.TimeType.Nanosecond:
                            switch (TypeConvert)
                            {
                                case Enums.TimeType.Nanosecond:
                                    return Cores.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enums.TimeType.Microsecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Nanosecond", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Millisecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Nanosecond", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Second:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Nanosecond", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Minute:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Nanosecond", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Hour:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Nanosecond", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Day:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Nanosecond", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Week:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Nanosecond", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Year:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Nanosecond", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Century:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Nanosecond", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Millennium:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Nanosecond", "Millennium", Error), Comma, true, false, Error);
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
                        case Enums.TimeType.Microsecond:
                            switch (TypeConvert)
                            {
                                case Enums.TimeType.Nanosecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Microsecond", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Microsecond:
                                    return Cores.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enums.TimeType.Millisecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Microsecond", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Second:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Microsecond", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Minute:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Microsecond", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Hour:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Microsecond", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Day:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Microsecond", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Week:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Microsecond", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Year:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Microsecond", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Century:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Microsecond", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Millennium:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Microsecond", "Millennium", Error), Comma, true, false, Error);
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
                        case Enums.TimeType.Millisecond:
                            switch (TypeConvert)
                            {
                                case Enums.TimeType.Nanosecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Millisecond", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Microsecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Millisecond", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Millisecond:
                                    return Cores.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enums.TimeType.Second:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Millisecond", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Minute:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Millisecond", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Hour:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Millisecond", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Day:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Millisecond", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Week:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Millisecond", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Year:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Millisecond", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Century:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Millisecond", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Millennium:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Millisecond", "Millennium", Error), Comma, true, false, Error);
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
                        case Enums.TimeType.Second:
                            switch (TypeConvert)
                            {
                                case Enums.TimeType.Nanosecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Second", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Microsecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Second", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Millisecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Second", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Second:
                                    return Cores.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enums.TimeType.Minute:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Second", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Hour:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Second", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Day:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Second", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Week:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Second", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Year:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Second", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Century:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Second", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Millennium:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Second", "Millennium", Error), Comma, true, false, Error);
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
                        case Enums.TimeType.Minute:
                            switch (TypeConvert)
                            {
                                case Enums.TimeType.Nanosecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Minute", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Microsecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Minute", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Millisecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Minute", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Second:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Minute", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Minute:
                                    return Cores.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enums.TimeType.Hour:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Minute", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Day:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Minute", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Week:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Minute", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Year:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Minute", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Century:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Minute", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Millennium:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Minute", "Millennium", Error), Comma, true, false, Error);
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
                        case Enums.TimeType.Hour:
                            switch (TypeConvert)
                            {
                                case Enums.TimeType.Nanosecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Hour", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Microsecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Hour", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Millisecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Hour", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Second:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Hour", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Minute:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Hour", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Hour:
                                    return Cores.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enums.TimeType.Day:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Hour", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Week:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Hour", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Year:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Hour", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Century:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Hour", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Millennium:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Hour", "Millennium", Error), Comma, true, false, Error);
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
                        case Enums.TimeType.Day:
                            switch (TypeConvert)
                            {
                                case Enums.TimeType.Nanosecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Day", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Microsecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Day", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Millisecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Day", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Second:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Day", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Minute:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Day", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Hour:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Day", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Day:
                                    return Cores.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enums.TimeType.Week:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Day", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Year:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Day", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Century:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Day", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Millennium:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Day", "Millennium", Error), Comma, true, false, Error);
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
                        case Enums.TimeType.Week:
                            switch (TypeConvert)
                            {
                                case Enums.TimeType.Nanosecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Week", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Microsecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Week", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Millisecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Week", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Second:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Week", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Minute:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Week", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Hour:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Week", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Day:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Week", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Week:
                                    return Cores.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enums.TimeType.Year:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Week", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Century:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Week", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Millennium:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Week", "Millennium", Error), Comma, true, false, Error);
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
                        case Enums.TimeType.Year:
                            switch (TypeConvert)
                            {
                                case Enums.TimeType.Nanosecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Year", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Microsecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Year", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Millisecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Year", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Second:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Year", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Minute:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Year", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Hour:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Year", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Day:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Year", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Week:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Year", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Year:
                                    return Cores.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enums.TimeType.Century:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Year", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Millennium:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Year", "Millennium", Error), Comma, true, false, Error);
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
                        case Enums.TimeType.Century:
                            switch (TypeConvert)
                            {
                                case Enums.TimeType.Nanosecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Century", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Microsecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Century", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Millisecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Century", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Second:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Century", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Minute:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Century", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Hour:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Century", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Day:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Century", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Week:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Century", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Year:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Century", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Century:
                                    return Cores.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case Enums.TimeType.Millennium:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Century", "Millennium", Error), Comma, true, false, Error);
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
                        case Enums.TimeType.Millennium:
                            switch (TypeConvert)
                            {
                                case Enums.TimeType.Nanosecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Millennium", "Nanosecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Microsecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Millennium", "Microsecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Millisecond:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Millennium", "Millisecond", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Second:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Millennium", "Second", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Minute:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Millennium", "Minute", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Hour:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Millennium", "Hour", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Day:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Millennium", "Day", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Week:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Millennium", "Week", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Year:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Millennium", "Year", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Century:
                                    if (Cores.NumberCheck(InputVariable))
                                    {
                                        Variable = Cores.VariableFormat(InputVariable, Values.GetValue("Time", "Millennium", "Century", Error), Comma, true, false, Error);
                                    }
                                    else
                                    {
                                        return Error;
                                    }

                                    break;
                                case Enums.TimeType.Millennium:
                                    return Cores.LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                default:
                                    return Error;
                            }
                            break;
                        default:
                            return Error;
                    }
                    if (!Comma)
                    {
                        return Cores.LastCheck(Variable, Decimal, !Comma, 0, Error);
                    }
                    else
                    {
                        return Cores.LastCheck(Variable, Decimal, Comma, PostComma, Error);
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "TS-TC1!)";
            }
        }
        #endregion
    }
}