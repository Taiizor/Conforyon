#region Imports

using CC = Conforyon.Cores;
using CCC = Conforyon.Constant.Constants;
using SC = System.Convert;
using SLE = System.Linq.Enumerable;
using STE = System.Text.Encoding;

#endregion

namespace Conforyon.Cryptology
{
    /// <summary>
    /// 
    /// </summary>
    public class BASE
    {
        #region BASE

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Base"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string TEXT(object Base, string Error = CCC.ErrorMessage)
        {
            return TEXT($"{Base}", Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Base"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string TEXT(string Base, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (Base.Length <= CCC.TextLength && CC.TextControl(Base))
                {
                    if (Base.EndsWith("==="))
                    {
                        try
                        {
                            int Number = SLE.Count(Base, C => C == '=');

                            string Replace = string.Empty;

                            for (int Count = 0; Count < Number; Count++)
                            {
                                Replace += "=";
                            }

                            return TEXT(Base.Replace(Replace, "=="), Error);
                        }
                        catch
                        {
                            return TEXT(Base.Replace("=", ""), Error);
                        }
                    }
                    else if (Base.EndsWith("=="))
                    {
                        try
                        {
                            return STE.UTF8.GetString(SC.FromBase64String(Base));
                        }
                        catch
                        {
                            return STE.UTF8.GetString(SC.FromBase64String(Base.Substring(0, Base.Length - 2)));
                        }
                    }
                    else if (Base.EndsWith("="))
                    {
                        try
                        {
                            return TEXT($"{Base}=", Error);
                        }
                        catch
                        {
                            return TEXT(Base.Substring(0, Base.Length - 1), Error);
                        }
                    }
                    else
                    {
                        try
                        {
                            return TEXT($"{Base}==", Error);
                        }
                        catch
                        {
                            return TEXT(Base, Error);
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
                return Error + CCC.ErrorTitle + "CY-TEXT1!)";
            }
        }

        #endregion
    }
}