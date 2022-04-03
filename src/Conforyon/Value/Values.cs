﻿#region Imports

using CAA = Conforyon.Array.Arrays;
using CCC = Conforyon.Constant.Constants;
using SCG = System.Collections.Generic;
using SCGD = System.Collections.Generic.Dictionary<string, string>;
using CEEMT = Conforyon.Enum.Enums.MethodType;

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
        /// <param name="Key2"></param>
        /// <param name="Key3"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string GetValue(CEEMT Method = CEEMT.DataStorage, string Key2 = "Bit", string Key3 = "Byte", string Error = CCC.ErrorMessage)
        {
            try
            {
                if (CAA.UnitValues.ContainsKey(Method))
                {
                    if (CAA.UnitValues[Method].ContainsKey(Key2))
                    {
                        if (CAA.UnitValues[Method][Key2].ContainsKey(Key3))
                        {
                            return CAA.UnitValues[Method][Key2][Key3];
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
                return Error + CCC.ErrorTitle + "VS-GV1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Method"></param>
        /// <param name="Key2"></param>
        /// <param name="Key3"></param>
        /// <param name="Value"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SetValue(CEEMT Method = CEEMT.DataStorage, string Key2 = "Bit", string Key3 = "Byte", string Value = "8", string Error = CCC.ErrorMessage)
        {
            try
            {
                if (CAA.UnitValues.ContainsKey(Method))
                {
                    if (CAA.UnitValues[Method].ContainsKey(Key2))
                    {
                        if (CAA.UnitValues[Method][Key2].ContainsKey(Key3))
                        {
                            CAA.UnitValues[Method][Key2][Key3] = Value;
                            return CAA.UnitValues[Method][Key2][Key3];
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
                return Error + CCC.ErrorTitle + "VS-SV1!)";
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
                                        "VS-LV1!"
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
                return Error + CCC.ErrorTitle + "VS-LVJ1!)";
            }
        }

        #endregion
    }
}