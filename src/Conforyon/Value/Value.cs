#region Imports

using System.Collections.Generic;
using System.Web.Script.Serialization;

#endregion

namespace Conforyon.Value
{
    /// <summary>
    /// 
    /// </summary>
    public class Value
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
        public static string GetValue(string Key1 = "DataStorage", string Key2 = "Bit", string Key3 = "Byte", string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                if (Array.Array.UnitValues.ContainsKey(Key1))
                {
                    if (Array.Array.UnitValues[Key1].ContainsKey(Key2))
                    {
                        if (Array.Array.UnitValues[Key1][Key2].ContainsKey(Key3))
                        {
                            return Array.Array.UnitValues[Key1][Key2][Key3];
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
                return Error + Constant.Constant.ErrorTitle + "CN-GV1!)";
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
        public static string SetValue(string Key1 = "DataStorage", string Key2 = "Bit", string Key3 = "Byte", string Value = "8", string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                if (Array.Array.UnitValues.ContainsKey(Key1))
                {
                    if (Array.Array.UnitValues[Key1].ContainsKey(Key2))
                    {
                        if (Array.Array.UnitValues[Key1][Key2].ContainsKey(Key3))
                        {
                            Array.Array.UnitValues[Key1][Key2][Key3] = Value;
                            return Array.Array.UnitValues[Key1][Key2][Key3];
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
                return Error + Constant.Constant.ErrorTitle + "CN-GV1!)";
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
                return Array.Array.UnitValues;
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
        public static string ListValueJson(string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                return new JavaScriptSerializer().Serialize(ListValue());
            }
            catch
            {
                return Error + Constant.Constant.ErrorTitle + "CN-LVJ1!)";
            }
        }
        #endregion
    }
}