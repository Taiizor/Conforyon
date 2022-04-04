#region Imports

using CAA = Conforyon.Array.Arrays;
using CCC = Conforyon.Constant.Constants;
using CEEDT = Conforyon.Enum.Enums.DetectType;
using CEEMT = Conforyon.Enum.Enums.MethodType;
using CHD = Conforyon.Helper.Detect;
using CHF = Conforyon.Helper.Format;
using SCG = System.Collections.Generic;
using SCGD = System.Collections.Generic.Dictionary<string, string>;

#endregion

namespace Conforyon.Value
{
    /// <summary>
    /// 
    /// </summary>
    public class Values
    {
        #region Values

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Method"></param>
        /// <param name="First"></param>
        /// <param name="Last"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string GetValue(CEEMT Method = CEEMT.DataStorage, string First = "Bit", string Last = "Byte", string Error = CCC.ErrorMessage)
        {
            try
            {
                if (CAA.UnitValues.ContainsKey(Method))
                {
                    if (CAA.UnitValues[Method].ContainsKey(First))
                    {
                        if (CAA.UnitValues[Method][First].ContainsKey(Last))
                        {
                            return CHD.Enum switch
                            {
                                CEEDT.Dot => CAA.UnitValues[Method][First][Last].Replace(",", "."),
                                CEEDT.Comma => CAA.UnitValues[Method][First][Last].Replace(".", ","),
                                _ => CAA.UnitValues[Method][First][Last],
                            };
                        }
                        else
                        {
                            return Error;
                        }
                    }
                    else
                    {
                        return Error;
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "VE-VSGV1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Method"></param>
        /// <param name="First"></param>
        /// <param name="Last"></param>
        /// <param name="Value"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SetValue(CEEMT Method = CEEMT.DataStorage, string First = "Bit", string Last = "Byte", string Value = "8", string Error = CCC.ErrorMessage)
        {
            try
            {
                if (CAA.UnitValues.ContainsKey(Method))
                {
                    if (CAA.UnitValues[Method].ContainsKey(First))
                    {
                        if (CAA.UnitValues[Method][First].ContainsKey(Last))
                        {
                            CAA.UnitValues[Method][First][Last] = CHD.Enum switch
                            {
                                CEEDT.Dot => Value.Replace(",", "."),
                                CEEDT.Comma => Value.Replace(".", ","),
                                _ => Value,
                            };

                            return CHF.Formatter(CCC.FormatValue, Method, First, Last, CAA.UnitValues[Method][First][Last]);
                        }
                        else
                        {
                            return Error;
                        }
                    }
                    else
                    {
                        return Error;
                    }
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "VE-VSSV1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Error"></param>
        /// <param name="Title"></param>
        /// <returns></returns>
        public static SCG.Dictionary<CEEMT, SCG.Dictionary<string, SCGD>> ListValue(CEEMT Error = CEEMT.Error, string Title = "Title")
        {
            try
            {
                return CAA.UnitValues;
            }
            catch
            {
                return new()
                {
                    {
                        Error,
                        new()
                        {
                            {
                                Title,
                                new()
                                {
                                    {
                                        "CN",
                                        "VE-VSLV1!"
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
        public static string ListValueJson(string Error = CCC.ErrorMessage)
        {
            try
            {
                return Cores.DataToJson(ListValue());
            }
            catch
            {
                return Error + CCC.ErrorTitle + "VE-VSLVJ1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool ResetValue()
        {
            try
            {
                CAA.UnitValues = CAA.DefaultValues;

                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}