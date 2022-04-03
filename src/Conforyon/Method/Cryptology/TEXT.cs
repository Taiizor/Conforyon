#region Imports

using System.Security.Cryptography;
using CC = Conforyon.Cores;
using CCC = Conforyon.Constant.Constants;
using CHB = Conforyon.Helper.Build;
using CHC = Conforyon.Helper.Case;
using SC = System.Convert;
using STE = System.Text.Encoding;

#endregion

namespace Conforyon.Cryptology
{
    /// <summary>
    /// 
    /// </summary>
    public class TEXT
    {
        #region TEXT

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string BASE(int Text, string Error = CCC.ErrorMessage)
        {
            return BASE($"{Text}", Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string BASE(double Text, string Error = CCC.ErrorMessage)
        {
            return BASE($"{Text}", Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string BASE(float Text, string Error = CCC.ErrorMessage)
        {
            return BASE($"{Text}", Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string BASE(object Text, string Error = CCC.ErrorMessage)
        {
            return BASE($"{Text}", Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string BASE(string Text, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (Text.Length <= CCC.TextLength && CC.TextControl(Text, true))
                {
                    return SC.ToBase64String(STE.UTF8.GetBytes(Text));
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "CY-BASE1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string MD5(string Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (Text.Length <= CCC.TextLength && CC.TextControl(Text, true))
                {
                    using MD5 MD5 = MD5.Create();

                    return CHC.Format(CHB.Builder(MD5.ComputeHash(STE.ASCII.GetBytes(Text))), Uppercase);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "CY-MD51!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA1(string Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (Text.Length <= CCC.TextLength && CC.TextControl(Text, true))
                {
                    using SHA1 SHA1 = SHA1.Create();

                    return CHC.Format(CHB.Builder(SHA1.ComputeHash(STE.ASCII.GetBytes(Text))), Uppercase);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "CY-SHA1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA256(string Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (Text.Length <= CCC.TextLength && CC.TextControl(Text, true))
                {
                    using SHA256 SHA256 = SHA256.Create();

                    return CHC.Format(CHB.Builder(SHA256.ComputeHash(STE.ASCII.GetBytes(Text))), Uppercase);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "CY-SHA2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA384(string Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (Text.Length <= CCC.TextLength && CC.TextControl(Text, true))
                {
                    using SHA384 SHA384 = SHA384.Create();

                    return CHC.Format(CHB.Builder(SHA384.ComputeHash(STE.ASCII.GetBytes(Text))), Uppercase);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "CY-SHA3!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA512(string Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (Text.Length <= CCC.TextLength && CC.TextControl(Text, true))
                {
                    using SHA512 SHA512 = SHA512.Create();

                    return CHC.Format(CHB.Builder(SHA512.ComputeHash(STE.ASCII.GetBytes(Text))), Uppercase);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "CY-SHA5!)";
            }
        }

        #endregion
    }
}