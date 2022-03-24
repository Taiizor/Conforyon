#region Imports

using Conforyon.Array;
using Conforyon.Constant;
using System.Collections.Generic;

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
        public static string GetValue(string Key1 = "DataStorage", string Key2 = "Bit", string Key3 = "Byte", string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Arrays.UnitValues.ContainsKey(Key1))
                {
                    if (Arrays.UnitValues[Key1].ContainsKey(Key2))
                    {
                        if (Arrays.UnitValues[Key1][Key2].ContainsKey(Key3))
                        {
                            return Arrays.UnitValues[Key1][Key2][Key3];
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
                return Error + Constants.ErrorTitle + "VS-GV1!)";
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
        public static string SetValue(string Key1 = "DataStorage", string Key2 = "Bit", string Key3 = "Byte", string Value = "8", string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Arrays.UnitValues.ContainsKey(Key1))
                {
                    if (Arrays.UnitValues[Key1].ContainsKey(Key2))
                    {
                        if (Arrays.UnitValues[Key1][Key2].ContainsKey(Key3))
                        {
                            Arrays.UnitValues[Key1][Key2][Key3] = Value;
                            return Arrays.UnitValues[Key1][Key2][Key3];
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
                return Error + Constants.ErrorTitle + "VS-SV1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Error"></param>
        /// <param name="Title"></param>
        /// <returns></returns>
        public static Dictionary<string, Dictionary<string, Dictionary<string, string>>> ListValue(string Error = "Error", string Title = "Title")
        {
            try
            {
                return Arrays.UnitValues;
            }
            catch
            {
                return new Dictionary<string, Dictionary<string, Dictionary<string, string>>>()
                {
                    {
                        Error, new Dictionary<string, Dictionary<string, string>>()
                        {
                            {
                                Title, new Dictionary<string, string>()
                                {
                                    {
                                        "CN", "VS-LV1!"
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
        public static string ListValueJson(string Error = Constants.ErrorMessage)
        {
            try
            {
                return Cores.DataToJson(ListValue());
            }
            catch
            {
                return Error + Constants.ErrorTitle + "VS-LVJ1!)";
            }
        }
        #endregion
    }
}