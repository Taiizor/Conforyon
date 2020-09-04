#region Imports

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;

#endregion

// |---------DO-NOT-REMOVE---------|
//
//     Creator: Taiizor
//     Site   : www.Taiizor.com
//     Created: 04.Jul.2019
//     Changed: 04.Sep.2020
//     Version: 1.4.7.4
//
// |---------DO-NOT-REMOVE---------|

namespace Conforyon
{
    public static class Conforyon
    {
        #region Variables
        /// <summary>
        /// 
        /// </summary>
        public const string ErrorTitle = " (CN-";

        /// <summary>
        /// 
        /// </summary>
        public const string ErrorMessage = "Error!";

        /// <summary>
        /// 
        /// </summary>
        public const string EmptyMessage = "Empty!";

        /// <summary>
        /// 
        /// </summary>
        public const int VariableLength = 15;

        /// <summary>
        /// 
        /// </summary>
        public const int PostCommaMinimum = 0;

        /// <summary>
        /// 
        /// </summary>
        public const int PostCommaMaximum = 99;

        /// <summary>
        /// 
        /// </summary>
        public const int TextLength = 32767;
        #endregion

        #region Enums
        /// <summary>
        /// 
        /// </summary>
        public enum ColorType
        {
            RGB1,
            RGB2,
            RGB3,
            RRGGBB1,
            RRGGBB2,
            RRGGBB3,
            RR,
            GG,
            BB,
            OnlyR,
            OnlyG,
            OnlyB
        }

        /// <summary>
        /// 
        /// </summary>
        public enum HashType
        {
            MD5,
            SHA1,
            SHA256,
            SHA384,
            SHA512
        }

        /// <summary>
        /// 
        /// </summary>
        public enum LengthType
        {
            MM,
            CM,
            DM,
            M,
            DAM,
            HM,
            KM,
        }

        /// <summary>
        /// 
        /// </summary>
        public enum SpeedType
        {
            MPH,
            KMH
        }

        /// <summary>
        /// 
        /// </summary>
        public enum StorageType
        {
            Bit,
            Byte,
            KB,
            MB,
            GB,
            TB,
            PB,
            EB,
            ZB,
            YB
        }

        /// <summary>
        /// 
        /// </summary>
        public enum TimeType
        {
            Microsecond,
            Millisecond,
            Second,
            Minute,
            Hour,
            Day,
            Week,
            Year
        }

        /// <summary>
        /// 
        /// </summary>
        public enum WeightType
        {
            Milligram,
            Gram,
            KG
        }

        /// <summary>
        /// 
        /// </summary>
        public enum IntType
        {
            Int16,
            Int32,
            Int64,
            UInt16,
            UInt32,
            UInt64
        }

        /// <summary>
        /// 
        /// </summary>
        public enum SearchType
        {
            Starts,
            Contains,
            Ends
        }
        #endregion

        #region Arrays
        /// <summary>
        /// 
        /// </summary>
        public static readonly string[] SymbolsMath = {
            "-",
            "+"
        };

        /// <summary>
        /// 
        /// </summary>
        public static readonly string[] SymbolsCalc = {
            "E",
            "B",
            "+",
            "-"
        };

        /// <summary>
        /// 
        /// </summary>
        private static Dictionary<string, Dictionary<string, Dictionary<string, string>>> Values = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>()
        {
            {
                "DataStorage", new Dictionary<string, Dictionary<string, string>>()
                {
                    {
                        "Bit", new Dictionary<string, string>()
                        {
                            {
                                "Byte", "8"
                            },
                            {
                                "KB", "8192"
                            },
                            {
                                "MB", "8388608"
                            },
                            {
                                "GB", "8589934592"
                            },
                            {
                                "TB", "8796093022208"
                            },
                            {
                                "PB", "9007199254740992"
                            },
                            {
                                "EB", "18014398509481984"
                            },
                            {
                                "ZB", "27021597764222976"
                            },
                            {
                                "YB", "36028797018963970"
                            }
                        }
                    },
                    {
                        "Byte", new Dictionary<string, string>()
                        {
                            {
                                "Bit", "8"
                            },
                            {
                                "KB", "1024"
                            },
                            {
                                "MB", "1048576"
                            },
                            {
                                "GB", "1073741824"
                            },
                            {
                                "TB", "1099511627776"
                            },
                            {
                                "PB", "1125899906842624"
                            },
                            {
                                "EB", "1152921504606846976"
                            },
                            {
                                "ZB", "2305843009213694000"
                            },
                            {
                                "YB", "3458764513820541000"
                            }
                        }
                    },
                    {
                        "KB", new Dictionary<string, string>()
                        {
                            {
                                "Bit", "8192"
                            },
                            {
                                "Byte", "1024"
                            },
                            {
                                "MB", "1024"
                            },
                            {
                                "GB", "1048576"
                            },
                            {
                                "TB", "1073741824"
                            },
                            {
                                "PB", "1099511627776"
                            },
                            {
                                "EB", "1125899906842624"
                            },
                            {
                                "ZB", "1152921504606846976"
                            },
                            {
                                "YB", "2305843009213694000"
                            }
                        }
                    },
                    {
                        "MB", new Dictionary<string, string>()
                        {
                            {
                                "Bit", "8388608"
                            },
                            {
                                "Byte", "1048576"
                            },
                            {
                                "KB", "1024"
                            },
                            {
                                "GB", "1024"
                            },
                            {
                                "TB", "1048576"
                            },
                            {
                                "PB", "1073741824"
                            },
                            {
                                "EB", "1099511627776"
                            },
                            {
                                "ZB", "1125899906842624"
                            },
                            {
                                "YB", "1152921504606847000"
                            }
                        }
                    },
                    {
                        "GB", new Dictionary<string, string>()
                        {
                            {
                                "Bit", "8589934592"
                            },
                            {
                                "Byte", "1073741824"
                            },
                            {
                                "KB", "1048576"
                            },
                            {
                                "MB", "1024"
                            },
                            {
                                "TB", "1024"
                            },
                            {
                                "PB", "1048576"
                            },
                            {
                                "EB", "1073741824"
                            },
                            {
                                "ZB", "1099511627776"
                            },
                            {
                                "YB", "1125899906842624"
                            }
                        }
                    },
                    {
                        "TB", new Dictionary<string, string>()
                        {
                            {
                                "Bit", "8796093022208"
                            },
                            {
                                "Byte", "1099511627776"
                            },
                            {
                                "KB", "1073741824"
                            },
                            {
                                "MB", "1048576"
                            },
                            {
                                "GB", "1024"
                            },
                            {
                                "PB", "1024"
                            },
                            {
                                "EB", "1048576"
                            },
                            {
                                "ZB", "1073741824"
                            },
                            {
                                "YB", "1099511627776"
                            }
                        }
                    },
                    {
                        "PB", new Dictionary<string, string>()
                        {
                            {
                                "Bit", "9007199254740992"
                            },
                            {
                                "Byte", "1125899906842624"
                            },
                            {
                                "KB", "1099511627776"
                            },
                            {
                                "MB", "1073741824"
                            },
                            {
                                "GB", "1048576"
                            },
                            {
                                "TB", "1024"
                            },
                            {
                                "EB", "1024"
                            },
                            {
                                "ZB", "1048576"
                            },
                            {
                                "YB", "1073741824"
                            }
                        }
                    },
                    {
                        "EB", new Dictionary<string, string>()
                        {
                            {
                                "Bit", "9223372036854775808"
                            },
                            {
                                "Byte", "1152921504606846976"
                            },
                            {
                                "KB", "1125899906842624"
                            },
                            {
                                "MB", "1099511627776"
                            },
                            {
                                "GB", "1073741824"
                            },
                            {
                                "TB", "1048576"
                            },
                            {
                                "PB", "1024"
                            },
                            {
                                "ZB", "1024"
                            },
                            {
                                "YB", "1048576"
                            }
                        }
                    },
                    {
                        "ZB", new Dictionary<string, string>()
                        {
                            {
                                "Bit", "9444732965739290427392"
                            },
                            {
                                "Byte", "1180591620717411303424"
                            },
                            {
                                "KB", "1152921504606846976"
                            },
                            {
                                "MB", "1125899906842624"
                            },
                            {
                                "GB", "1099511627776"
                            },
                            {
                                "TB", "1073741824"
                            },
                            {
                                "PB", "1048576"
                            },
                            {
                                "EB", "1024"
                            },
                            {
                                "YB", "1024"
                            }
                        }
                    },
                    {
                        "YB", new Dictionary<string, string>()
                        {
                            {
                                "Bit", "9671406556917033397649408"
                            },
                            {
                                "Byte", "1208925819614629174706176"
                            },
                            {
                                "KB", "1180591620717411303424"
                            },
                            {
                                "MB", "1152921504606846976"
                            },
                            {
                                "GB", "1125899906842624"
                            },
                            {
                                "TB", "1099511627776"
                            },
                            {
                                "PB", "1073741824"
                            },
                            {
                                "EB", "1048576"
                            },
                            {
                                "ZB", "1024"
                            }
                        }
                    }
                }
            },
            {
                "Speed", new Dictionary<string, Dictionary<string, string>>()
                {
                    {
                        "MPH", new Dictionary<string, string>()
                        {
                            {
                                "KPH", "1,609344"
                            }
                        }
                    },
                    {
                        "KPH", new Dictionary<string, string>()
                        {
                            {
                                "MPH", "0,621371192"
                            }
                        }
                    }
                }
            },
            {
                "Temperature", new Dictionary<string, Dictionary<string, string>>()
                {
                    {
                        "Celsius", new Dictionary<string, string>()
                        {
                            {
                                "Divide", "5"
                            },
                            {
                                "Multipy", "9"
                            },
                            {
                                "Add", "32"
                            }
                        }
                    },
                    {
                        "Fahrenheit", new Dictionary<string, string>()
                        {
                            {
                                "Deduct", "32"
                            },
                            {
                                "Multipy", "5"
                            },
                            {
                                "Divide", "9"
                            }
                        }
                    }
                }
            },
            {
                "Time", new Dictionary<string, Dictionary<string, string>>()
                {
                    {
                        "Microsecond", new Dictionary<string, string>()
                        {
                            {
                                "Millisecond", "0,001"
                            },
                            {
                                "Second", "0,000001"
                            },
                            {
                                "Minute", "0,000000016666667"
                            },
                            {
                                "Hour", "0,000000000277778"
                            },
                            {
                                "Day", "0,000000000011574"
                            },
                            {
                                "Week", "0,000000000001653"
                            },
                            {
                                "Year", "0,000000000000032"
                            }
                        }
                    },
                    {
                        "Millisecond", new Dictionary<string, string>()
                        {
                            {
                                "Microsecond", "1000"
                            },
                            {
                                "Second", "0,001"
                            },
                            {
                                "Minute", "0,0000166667"
                            },
                            {
                                "Hour", "0,000000277777778"
                            },
                            {
                                "Day", "0,000000011574074"
                            },
                            {
                                "Week", "0,000000001653439"
                            },
                            {
                                "Year", "0,000000000031688"
                            }
                        }
                    },
                    {
                        "Second", new Dictionary<string, string>()
                        {
                            {
                                "Microsecond", "1000000"
                            },
                            {
                                "Millisecond", "1000"
                            },
                            {
                                "Minute", "0,016667"
                            },
                            {
                                "Hour", "0,000278"
                            },
                            {
                                "Day", "0,000012"
                            },
                            {
                                "Week", "0,000002"
                            },
                            {
                                "Year", "0,000000031688088"
                            }
                        }
                    },
                    {
                        "Minute", new Dictionary<string, string>()
                        {
                            {
                                "Microsecond", "60000000"
                            },
                            {
                                "Millisecond", "60000"
                            },
                            {
                                "Second", "60"
                            },
                            {
                                "Hour", "0,016667"
                            },
                            {
                                "Day", "0,000694"
                            },
                            {
                                "Week", "0,000099"
                            },
                            {
                                "Year", "0,000002"
                            }
                        }
                    },
                    {
                        "Hour", new Dictionary<string, string>()
                        {
                            {
                                "Microsecond", "3600000000"
                            },
                            {
                                "Millisecond", "3600000"
                            },
                            {
                                "Second", "3600"
                            },
                            {
                                "Minute", "60"
                            },
                            {
                                "Day", "0,041667"
                            },
                            {
                                "Week", "0,005952"
                            },
                            {
                                "Year", "0,000114"
                            }
                        }
                    },
                    {
                        "Day", new Dictionary<string, string>()
                        {
                            {
                                "Microsecond", "86400000000"
                            },
                            {
                                "Millisecond", "86400000"
                            },
                            {
                                "Second", "86400"
                            },
                            {
                                "Minute", "1440"
                            },
                            {
                                "Hour", "24"
                            },
                            {
                                "Week", "0,142857"
                            },
                            {
                                "Year", "0,002738"
                            }
                        }
                    },
                    {
                        "Week", new Dictionary<string, string>()
                        {
                            {
                                "Microsecond", "604800000000"
                            },
                            {
                                "Millisecond", "604800000"
                            },
                            {
                                "Second", "604800"
                            },
                            {
                                "Minute", "10080"
                            },
                            {
                                "Hour", "168"
                            },
                            {
                                "Day", "7"
                            },
                            {
                                "Year", "0,019165"
                            }
                        }
                    },
                    {
                        "Year", new Dictionary<string, string>()
                        {
                            {
                                "Microsecond", "31557600000000"
                            },
                            {
                                "Millisecond", "31557600000"
                            },
                            {
                                "Second", "31557600"
                            },
                            {
                                "Minute", "525960"
                            },
                            {
                                "Hour", "8766"
                            },
                            {
                                "Day", "365,25"
                            },
                            {
                                "Week", "52,17857"
                            }
                        }
                    }
                }
            },
            {
                "Typography", new Dictionary<string, Dictionary<string, string>>()
                {
                    {
                        "INCH", new Dictionary<string, string>()
                        {
                            {
                                "CM", "2,54"
                            },
                            {
                                "PX", "96"
                            }
                        }
                    },
                    {
                        "CM", new Dictionary<string, string>()
                        {
                            {
                                "INCH", "0,3937007874"
                            },
                            {
                                "PX", "37,795275591"
                            }
                        }
                    },
                    {
                        "PX", new Dictionary<string, string>()
                        {
                            {
                                "INCH", "0,0104166667"
                            },
                            {
                                "CM", "0,0264583333"
                            }
                        }
                    }
                }
            }
        };
        #endregion

        #region Cores
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="TypePass"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool NumberCheck(string Variable, bool TypePass = false, IntType Type = IntType.Int64)
        {
            try
            {
                if (Regex.IsMatch(Variable, "[^0-9]"))
                    return false;
                else
                {
                    if (TypePass)
                        return true;
                    else
                    {
                        switch (Type)
                        {
                            case IntType.Int16:
                                Convert.ToInt16(Variable);
                                break;
                            case IntType.Int32:
                                Convert.ToInt32(Variable);
                                break;
                            case IntType.Int64:
                                Convert.ToInt64(Variable);
                                break;
                            case IntType.UInt16:
                                Convert.ToUInt16(Variable);
                                break;
                            case IntType.UInt32:
                                Convert.ToUInt32(Variable);
                                break;
                            case IntType.UInt64:
                                Convert.ToUInt64(Variable);
                                break;
                            default:
                                return false;
                        }
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Words"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool Searching(string Text, string[] Words, SearchType Type = SearchType.Contains)
        {
            try
            {
                switch (Type)
                {
                    case SearchType.Starts:
                        if (Words.Length > 1)
                        {
                            foreach (string Letter in Words)
                                if (Text.StartsWith(Letter)) return true;
                        }
                        else if (Text.StartsWith(Words[0]))
                            return true;
                        break;
                    case SearchType.Contains:
                        if (Words.Length > 1)
                        {
                            foreach (string Letter in Words)
                                if (Text.Contains(Letter)) return true;
                        }
                        else if (Text.Contains(Words[0]))
                            return true;
                        break;
                    case SearchType.Ends:
                        if (Words.Length > 1)
                        {
                            foreach (string Letter in Words)
                                if (Text.EndsWith(Letter)) return true;
                        }
                        else if (Text.EndsWith(Words[0]))
                            return true;
                        break;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="InputVariable"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Comma"></param>
        /// <param name="Error"></param>
        /// <param name="Mod"></param>
        /// <param name="Mod2"></param>
        /// <returns></returns>
        public static string VariableFormat(string InputVariable, string Coefficient, bool Comma, string Error = ErrorMessage, bool Mod = false, bool Mod2 = false)
        {
            try
            {
                if (!Mod)
                {
                    if (NumberCheck(Coefficient.ToString()))
                    {
                        string Variable1, Variable2, Variable3;
                        if (Comma)
                        {
                            if (Mod2)
                            {
                                Variable2 = (Convert.ToInt64(InputVariable) / Convert.ToDouble(Coefficient)).ToString();
                                Variable3 = (Convert.ToInt64(InputVariable) / Convert.ToInt64(Coefficient)).ToString();
                            }
                            else
                            {
                                Variable2 = (Convert.ToInt64(InputVariable) * Convert.ToDouble(Coefficient)).ToString();
                                Variable3 = (Convert.ToInt64(InputVariable) * Convert.ToInt64(Coefficient)).ToString();
                            }

                            if (Searching(Variable2, SymbolsCalc, SearchType.Contains))
                            {
                                if (Searching(Variable3, SymbolsMath, SearchType.Starts))
                                    Variable1 = Variable2;
                                else
                                    Variable1 = Variable3;
                            }
                            else if (Searching(Variable3, SymbolsMath, SearchType.Starts))
                            {
                                if (Searching(Variable3, SymbolsMath, SearchType.Starts))
                                    Variable1 = Variable2;
                                else
                                    Variable1 = Variable3;
                            }
                            else
                                Variable1 = Variable2;
                        }
                        else
                        {
                            if (Mod2)
                            {
                                Variable2 = (Convert.ToInt64(InputVariable) / Convert.ToDouble(Coefficient)).ToString();
                                Variable3 = (Convert.ToInt64(InputVariable) / Convert.ToInt64(Coefficient)).ToString();
                            }
                            else
                            {
                                Variable2 = (Convert.ToInt64(InputVariable) * Convert.ToDouble(Coefficient)).ToString();
                                Variable3 = (Convert.ToInt64(InputVariable) * Convert.ToInt64(Coefficient)).ToString();
                            }

                            if (Searching(Variable2, SymbolsCalc, SearchType.Contains))
                            {
                                if (Searching(Variable3, SymbolsMath, SearchType.Starts))
                                    Variable1 = Variable2;
                                else
                                    Variable1 = Variable3;
                            }
                            else if (Searching(Variable3, SymbolsMath, SearchType.Starts))
                            {
                                if (Searching(Variable3, SymbolsMath, SearchType.Starts))
                                    Variable1 = Variable2;
                                else
                                    Variable1 = Variable3;
                            }
                            else
                                Variable1 = Variable3;
                        }
                        if (string.IsNullOrEmpty(Variable1) || string.IsNullOrWhiteSpace(Variable1))
                            return Error;
                        else
                            return Variable1;
                    }
                    else
                        return Error;
                }
                else
                {
                    if (Mod2)
                        return (Convert.ToInt64(InputVariable) / Convert.ToDouble(Coefficient)).ToString();
                    else
                        return (Convert.ToInt64(InputVariable) * Convert.ToDouble(Coefficient)).ToString();
                }
            }
            catch
            {
                return Error + ErrorTitle + "CN-VF1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string UseDecimal(string Variable, string Error = ErrorMessage)
        {
            try
            {
                if (Searching(Variable, SymbolsCalc))
                    return Variable;
                else
                {
                    if (Variable.Contains(","))
                    {
                        char[] Brackets = { ',', '.' };
                        string[] Variables = Variable.Split(Brackets);
                        string Result = string.Format("{0:0,0}", Convert.ToInt64(Variables[0]));
                        if (Result.Length == 2 && Result == "00")
                            Result = "0";
                        else if (Result.Length == 2 && Result.StartsWith("0") && !Result.EndsWith("0"))
                            Result.Replace("0", "");
                        return Result + "," + Variables[1];
                    }
                    else
                    {
                        if (Variable.Length > 2)
                        {
                            if (NumberCheck(Variable))
                                return string.Format("{0:0,0}", Convert.ToInt64(Variable));
                            else
                                return string.Format("{0:0,0}", Variable);
                        }
                        else
                            return Variable;
                    }
                }
            }
            catch
            {
                return Error + ErrorTitle + "CN-UD1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string UseDecimal2(string Variable, string Error = ErrorMessage)
        {
            try
            {
                if (Searching(Variable, SymbolsCalc))
                    return Variable;
                else
                {
                    if (Variable.Contains(","))
                    {
                        char[] Brackets = { ',' };
                        string[] Variables = Variable.Split(Brackets);
                        string Result = string.Format("{0:0,0}", Convert.ToInt64(Variables[0]));
                        if (Result.Length == 2 && Result == "00")
                            return "0";
                        else if (Result.Length == 2 && Result.StartsWith("0") && !Result.EndsWith("0"))
                            return Result.Replace("0", "");
                        else
                            return Result;
                    }
                    else
                    {
                        if (Variable.Length > 2)
                        {
                            if (NumberCheck(Variable))
                                return string.Format("{0:0,0}", Convert.ToInt64(Variable));
                            else
                                return string.Format("{0:0,0}", Variable);
                        }
                        else
                            return Variable;
                    }
                }
            }
            catch
            {
                return Error + ErrorTitle + "CN-UD2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string UseComma(string Variable, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Searching(Variable, SymbolsCalc))
                    return Variable;
                else
                {
                    if (Variable.Contains(",") && PostComma != 0)
                    {
                        char[] Brackets = { ',' };
                        string[] Variables = Variable.Split(Brackets);
                        if (PostComma <= Variables[1].Length)
                            return Variables[0] + "," + Variables[1].Substring(0, PostComma);
                        else
                        {
                            string Operation = Variables[0] + "," + Variables[1].Substring(0, Variables[1].Length);
                            int Operation2 = PostComma - Variables[1].Length;
                            for (int i = 0; i < Operation2; i++)
                                Operation += "0";
                            return Operation;
                        }
                    }
                    else
                    {
                        if (PostComma == 0)
                        {
                            char[] Brackets = { ',' };
                            string[] Variables = Variable.Split(Brackets);
                            return Variables[0];
                        }
                        else
                        {
                            string Operation = ",";
                            for (int i = 0; i < PostComma; i++)
                                Operation += "0";
                            return Variable + Operation;
                        }
                    }
                }
            }
            catch
            {
                return Error + ErrorTitle + "CN-UC1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string UseComma2(string Variable, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Searching(Variable, SymbolsCalc))
                    return Variable;
                else
                {
                    if (PostComma <= Variable.Length)
                    {
                        if (Variable == ",")
                            return Variable.Substring(0, PostComma) + "0";
                        else
                            return Variable.Substring(0, PostComma);
                    }
                    else
                    {
                        string Operation = Variable.Substring(0, Variable.Length);
                        int Operation2 = PostComma - Variable.Length;
                        if (Variable == ",")
                            for (int i = 0; i <= Operation2; i++) Operation += "0";
                        else
                            for (int i = 0; i < Operation2; i++) Operation += "0";
                        return Operation;
                    }
                }
            }
            catch
            {
                return Error + ErrorTitle + "CN-UC2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string DecimalComma(string Variable, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Searching(Variable, SymbolsCalc))
                    return Variable;
                else
                {
                    if (PostComma == 0)
                        return UseDecimal2(Variable);
                    else
                    {
                        if (Variable.Contains(","))
                        {
                            char[] Brackets = { ',' };
                            string[] Variables = Variable.Split(Brackets);
                            return UseDecimal2(Variables[0]) + "," + UseComma2(Variables[1], PostComma);
                        }
                        else
                            return UseDecimal2(Variable) + UseComma2(",", PostComma);
                    }
                }
            }
            catch
            {
                return Error + ErrorTitle + "CN-DC1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string LastCheck(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (!Decimal && !Comma)
                {
                    if (string.IsNullOrEmpty(Variable))
                        return Error;
                    else
                        return Variable;
                }
                else
                {
                    if (Decimal && !Comma)
                        return UseDecimal(Variable);
                    else if (!Decimal && Comma)
                        return UseComma(Variable, PostComma);
                    else
                        return DecimalComma(Variable, PostComma);
                }
            }
            catch
            {
                return Error + ErrorTitle + "CN-LC1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string LastCheck2(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (!Decimal && !Comma)
                {
                    if (string.IsNullOrEmpty(Variable))
                        return Error;
                    else
                        return LastCheck(Variable, false, true, 0, Error);
                }
                else
                {
                    if (Decimal && !Comma)
                        return LastCheck(Variable, true, true, 0, Error);
                    else if (!Decimal && Comma)
                        return LastCheck(Variable, false, true, PostComma, Error);
                    else
                        return DecimalComma(Variable, PostComma);
                }
            }
            catch
            {
                return Error + ErrorTitle + "CN-LC2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Spaces"></param>
        /// <returns></returns>
        public static bool UseCheck(string Variable, bool Spaces = false)
        {
            try
            {
                if (Variable != "" && !string.IsNullOrEmpty(Variable))
                {
                    if (Spaces)
                        return true;
                    else
                    {
                        if (Variable.Contains(" ") || string.IsNullOrWhiteSpace(Variable))
                            return false;
                        else
                            return true;
                    }
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Key1"></param>
        /// <param name="Key2"></param>
        /// <param name="Key3"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string GetValues(string Key1 = "DataStorage", string Key2 = "Bit", string Key3 = "Byte", string Error = ErrorMessage)
        {
            try
            {
                if (Values.ContainsKey(Key1))
                {
                    if (Values[Key1].ContainsKey(Key2))
                    {
                        if (Values[Key1][Key2].ContainsKey(Key3))
                            return Values[Key1][Key2][Key3];
                        else
                            return Error;
                    }
                    else
                        return Error;
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "CN-GV1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Key1"></param>
        /// <param name="Key2"></param>
        /// <param name="Key3"></param>
        /// <param name="Value"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SetValues(string Key1 = "DataStorage", string Key2 = "Bit", string Key3 = "Byte", string Value = "8", string Error = ErrorMessage)
        {
            try
            {
                if (Values.ContainsKey(Key1))
                {
                    if (Values[Key1].ContainsKey(Key2))
                    {
                        if (Values[Key1][Key2].ContainsKey(Key3))
                        {
                            Values[Key1][Key2][Key3] = Value;
                            return Values[Key1][Key2][Key3];
                        }
                        else
                            return Error;
                    }
                    else
                        return Error;
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "CN-GV1!)";
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, Dictionary<string, Dictionary<string, string>>> ListValues(string Error = ErrorMessage)
        {
            try
            {
                return Values;
            }
            catch
            {
                return new Dictionary<string, Dictionary<string, Dictionary<string, string>>>()
                {
                    {
                        "Error", new Dictionary<string, Dictionary<string, string>>()
                        {
                            {
                                "ErrorTitle", new Dictionary<string, string>()
                                {
                                    {
                                        "CN", "LV1!"
                                    }
                                }
                            }
                        }
                    }
                };
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string ListValuesJson(string Error = ErrorMessage)
        {
            try
            {
                return new JavaScriptSerializer().Serialize(ListValues());
            }
            catch
            {
                return Error + ErrorTitle + "CN-LVJ1!)";
            }
        }
        #endregion
    }
}