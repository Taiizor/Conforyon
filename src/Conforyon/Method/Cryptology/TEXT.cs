#region Imports

using CC = Conforyon.Cores;
using CCC = Conforyon.Constant.Constants;
using CHB = Conforyon.Helper.Build;
using CHC = Conforyon.Helper.Case;
using SC = System.Convert;
using SSCMD5 = System.Security.Cryptography.MD5;
using SSCSHA1 = System.Security.Cryptography.SHA1;
using SSCSHA256 = System.Security.Cryptography.SHA256;
using SSCSHA384 = System.Security.Cryptography.SHA384;
using SSCSHA512 = System.Security.Cryptography.SHA512;
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
        public static string MD5(int Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return MD5($"{Text}", Uppercase, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string MD5(double Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return MD5($"{Text}", Uppercase, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string MD5(float Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return MD5($"{Text}", Uppercase, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string MD5(object Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return MD5($"{Text}", Uppercase, Error);
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
                    using SSCMD5 MD5 = SSCMD5.Create();

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
        public static string SHA1(int Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return SHA1($"{Text}", Uppercase, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA1(double Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return SHA1($"{Text}", Uppercase, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA1(float Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return SHA1($"{Text}", Uppercase, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA1(object Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return SHA1($"{Text}", Uppercase, Error);
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
                    using SSCSHA1 SHA1 = SSCSHA1.Create();

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
        public static string SHA256(int Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return SHA256($"{Text}", Uppercase, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA256(double Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return SHA256($"{Text}", Uppercase, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA256(float Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return SHA256($"{Text}", Uppercase, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA256(object Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return SHA256($"{Text}", Uppercase, Error);
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
                    using SSCSHA256 SHA256 = SSCSHA256.Create();

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
        public static string SHA384(int Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return SHA384($"{Text}", Uppercase, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA384(double Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return SHA384($"{Text}", Uppercase, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA384(float Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return SHA384($"{Text}", Uppercase, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA384(object Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return SHA384($"{Text}", Uppercase, Error);
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
                    using SSCSHA384 SHA384 = SSCSHA384.Create();

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
        public static string SHA512(int Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return SHA512($"{Text}", Uppercase, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA512(double Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return SHA512($"{Text}", Uppercase, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA512(float Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return SHA512($"{Text}", Uppercase, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA512(object Text, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return SHA512($"{Text}", Uppercase, Error);
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
                    using SSCSHA512 SHA512 = SSCSHA512.Create();

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