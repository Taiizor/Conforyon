#region Imports

using System;
using System.Text;
using static Conforyon.Conforyon;
using System.Security.Cryptography;

#endregion

namespace Conforyon
{
    public static class Crypto
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string BASE64toTEXT(string Variable, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= 32767 && Check(Variable))
                {
                    if (Variable.EndsWith("="))
                    {
                        try
                        {
                            return Encoding.UTF8.GetString(Convert.FromBase64String(Variable));
                        }
                        catch
                        {
                            try
                            {
                                return Encoding.UTF8.GetString(Convert.FromBase64String(Variable + "="));
                            }
                            catch
                            {
                                try
                                {
                                    return Encoding.UTF8.GetString(Convert.FromBase64String(Variable.Remove(Variable.Length - 1)));
                                }
                                catch
                                {
                                    return Encoding.UTF8.GetString(Convert.FromBase64String(Variable.Remove(Variable.Length - 2)));
                                }
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            return Encoding.UTF8.GetString(Convert.FromBase64String(Variable));
                        }
                        catch
                        {
                            try
                            {
                                return Encoding.UTF8.GetString(Convert.FromBase64String(Variable + "="));
                            }
                            catch
                            {
                                return Encoding.UTF8.GetString(Convert.FromBase64String(Variable + "=="));
                            }
                        }
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1B!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string TEXTtoBASE64(string Variable, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= 32767 && Check(Variable, true))
                    return Convert.ToBase64String(Encoding.UTF8.GetBytes(Variable));
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1C!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string TEXTtoMD5(string Variable, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= 32767 && Check(Variable, true))
                {
                    using (MD5 MD5 = MD5.Create())
                    {
                        MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Variable));
                        byte[] Sonuç = MD5.Hash;
                        StringBuilder Builder = new StringBuilder();
                        for (int i = 0; i < Sonuç.Length; i++)
                            Builder.Append(Sonuç[i].ToString("x2"));
                        return Builder.ToString();
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1C2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string TEXTtoSHA1(string Variable, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= 32767 && Check(Variable, true))
                {
                    using (SHA1 SHA1 = SHA1.Create())
                    {
                        byte[] Sonuç = SHA1.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Variable));
                        StringBuilder Builder = new StringBuilder();
                        for (int i = 0; i < Sonuç.Length; i++)
                            Builder.Append(Sonuç[i].ToString("x2"));
                        return Builder.ToString();
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1C3!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string TEXTtoSHA256(string Variable, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= 32767 && Check(Variable, true))
                {
                    using (SHA256 SHA256 = SHA256.Create())
                    {
                        byte[] Sonuç = SHA256.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Variable));
                        StringBuilder Builder = new StringBuilder();
                        for (int i = 0; i < Sonuç.Length; i++)
                            Builder.Append(Sonuç[i].ToString("x2"));
                        return Builder.ToString();
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1C4!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string TEXTtoSHA384(string Variable, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= 32767 && Check(Variable, true))
                {
                    using (SHA384 SHA384 = SHA384.Create())
                    {
                        byte[] Sonuç = SHA384.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Variable));
                        StringBuilder Builder = new StringBuilder();
                        for (int i = 0; i < Sonuç.Length; i++)
                            Builder.Append(Sonuç[i].ToString("x2"));
                        return Builder.ToString();
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1C5!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string TEXTtoSHA512(string Variable, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= 32767 && Check(Variable, true))
                {
                    using (SHA512 SHA512 = SHA512.Create())
                    {
                        byte[] Sonuç = SHA512.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Variable));
                        StringBuilder Builder = new StringBuilder();
                        for (int i = 0; i < Sonuç.Length; i++)
                            Builder.Append(Sonuç[i].ToString("x2"));
                        return Builder.ToString();
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1C6!)";
            }
        }
    }
}