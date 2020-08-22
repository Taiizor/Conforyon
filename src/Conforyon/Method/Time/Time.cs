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
                if (InputVariable.Length <= VariableLength && InputType >= TimeType.Millisecond && InputType <= TimeType.Week && PostComma >= PostCommaMinimum && PostComma <= PostCommaMaximum && !Regex.IsMatch(InputVariable, "[^0-9]") && !InputVariable.StartsWith("0") && UseCheck(InputVariable))
                {
                    TimeType Type = InputType;
                    if (InputType == TimeType.Week)
                        Type = TimeType.Week;
                    else
                    {
                        for (int i = (int)InputType; i <= (int)TimeType.Week; i++)
                        {
                            if (TimeConvert(InputVariable, InputType, (TimeType)i, false, false, 0, Error) == "0")
                            {
                                Type = (TimeType)i - 1;
                                break;
                            }
                            else
                            {
                                if ((TimeType)i == TimeType.Week)
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
                return Error + ErrorTitle + "SE-ADC1!)";
            }
        }

        public static string TimeConvert(string InputVariable, TimeType InputType, TimeType TypeConvert, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                string Variable = string.Empty;
                if (InputVariable.Length <= VariableLength && InputType >= TimeType.Millisecond && InputType <= TimeType.Week && TypeConvert >= TimeType.Millisecond && TypeConvert <= TimeType.Week && PostComma >= PostCommaMinimum && PostComma <= PostCommaMaximum && !Regex.IsMatch(InputVariable, "[^0-9]") && !InputVariable.StartsWith("0") && UseCheck(InputVariable))
                {
                    switch (InputType)
                    {
                        case TimeType.Millisecond:
                            switch (TypeConvert)
                            {
                                case TimeType.Millisecond:
                                    return LastCheck(InputVariable, Decimal, Comma, PostComma, Error);
                                case TimeType.Second:
                                    if (NumberCheck(InputVariable))
                                        Variable = VariableFormat(InputVariable, "0.001", Comma, Error, false, true);
                                    else
                                        return Error;
                                    break;
                                case TimeType.Minute:
                                    break;
                                case TimeType.Hour:
                                    break;
                                case TimeType.Day:
                                    break;
                                case TimeType.Week:
                                    break;
                                default:
                                    return Error;
                            }
                            break;
                        case TimeType.Second:
                            break;
                        case TimeType.Minute:
                            break;
                        case TimeType.Hour:
                            break;
                        case TimeType.Day:
                            break;
                        case TimeType.Week:
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