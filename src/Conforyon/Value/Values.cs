#region Imports

using CAA = Conforyon.Array.Arrays;
using CCC = Conforyon.Constant.Constants;
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
        /// <param name="Key1"></param>
        /// <param name="Key2"></param>
        /// <param name="Key3"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string GetValue(string Key1 = "DataStorage", string Key2 = "Bit", string Key3 = "Byte", string Error = CCC.ErrorMessage)
        {
            try
            {
                if (CAA.UnitValues.ContainsKey(Key1))
                {
                    if (CAA.UnitValues[Key1].ContainsKey(Key2))
                    {
                        if (CAA.UnitValues[Key1][Key2].ContainsKey(Key3))
                        {
                            return CAA.UnitValues[Key1][Key2][Key3];
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
        /// <param name="Key1"></param>
        /// <param name="Key2"></param>
        /// <param name="Key3"></param>
        /// <param name="Value"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SetValue(string Key1 = "DataStorage", string Key2 = "Bit", string Key3 = "Byte", string Value = "8", string Error = CCC.ErrorMessage)
        {
            try
            {
                if (CAA.UnitValues.ContainsKey(Key1))
                {
                    if (CAA.UnitValues[Key1].ContainsKey(Key2))
                    {
                        if (CAA.UnitValues[Key1][Key2].ContainsKey(Key3))
                        {
                            CAA.UnitValues[Key1][Key2][Key3] = Value;
                            return CAA.UnitValues[Key1][Key2][Key3];
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
        public static SCG.Dictionary<string, SCG.Dictionary<string, SCGD>> ListValue(string Error = "Error", string Title = "Title")
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