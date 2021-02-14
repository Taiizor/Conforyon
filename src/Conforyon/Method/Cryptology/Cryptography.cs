﻿#region Imports

using Conforyon.Constant;
using System;
using System.Security.Cryptography;
using System.Text;

#endregion

namespace Conforyon.Cryptology
{
    /// <summary>
    /// 
    /// </summary>
    public class Cryptography
    {
        #region Cryptography
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Base64"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string BASE64toTEXT(string Base64, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Base64.Length <= Constants.TextLength && Cores.UseCheck(Base64))
                {
                    if (Base64.EndsWith("="))
                    {
                        try
                        {
                            return Encoding.UTF8.GetString(Convert.FromBase64String(Base64));
                        }
                        catch
                        {
                            try
                            {
                                return Encoding.UTF8.GetString(Convert.FromBase64String(Base64 + "="));
                            }
                            catch
                            {
                                try
                                {
                                    return Encoding.UTF8.GetString(Convert.FromBase64String(Base64.Remove(Base64.Length - 1)));
                                }
                                catch
                                {
                                    return Encoding.UTF8.GetString(Convert.FromBase64String(Base64.Remove(Base64.Length - 2)));
                                }
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            return Encoding.UTF8.GetString(Convert.FromBase64String(Base64));
                        }
                        catch
                        {
                            try
                            {
                                return Encoding.UTF8.GetString(Convert.FromBase64String(Base64 + "="));
                            }
                            catch
                            {
                                return Encoding.UTF8.GetString(Convert.FromBase64String(Base64 + "=="));
                            }
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
                return Error + Constants.ErrorTitle + "CY-BTT1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string TEXTtoBASE64(string Text, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Text.Length <= Constants.TextLength && Cores.UseCheck(Text, true))
                {
                    return Convert.ToBase64String(Encoding.UTF8.GetBytes(Text));
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "CY-TTB1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string TEXTtoMD5(string Text, bool Uppercase = false, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Text.Length <= Constants.TextLength && Cores.UseCheck(Text, true))
                {
                    using MD5 MD5 = MD5.Create();
                    MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Text));
                    byte[] Result = MD5.Hash;
                    StringBuilder Builder = new();
                    for (int i = 0; i < Result.Length; i++)
                    {
                        Builder.Append(Result[i].ToString("x2"));
                    }

                    return Uppercase == false ? Builder.ToString().ToLowerInvariant() : Builder.ToString().ToUpperInvariant();
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "CY-TTM1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string TEXTtoSHA1(string Text, bool Uppercase = false, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Text.Length <= Constants.TextLength && Cores.UseCheck(Text, true))
                {
                    using SHA1 SHA1 = SHA1.Create();
                    byte[] Result = SHA1.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Text));
                    StringBuilder Builder = new();
                    for (int i = 0; i < Result.Length; i++)
                    {
                        Builder.Append(Result[i].ToString("x2"));
                    }

                    return Uppercase == false ? Builder.ToString().ToLowerInvariant() : Builder.ToString().ToUpperInvariant();
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "CY-TTS1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string TEXTtoSHA256(string Text, bool Uppercase = false, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Text.Length <= Constants.TextLength && Cores.UseCheck(Text, true))
                {
                    using SHA256 SHA256 = SHA256.Create();
                    byte[] Result = SHA256.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Text));
                    StringBuilder Builder = new();
                    for (int i = 0; i < Result.Length; i++)
                    {
                        Builder.Append(Result[i].ToString("x2"));
                    }

                    return Uppercase == false ? Builder.ToString().ToLowerInvariant() : Builder.ToString().ToUpperInvariant();
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "CY-TTS2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string TEXTtoSHA384(string Text, bool Uppercase = false, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Text.Length <= Constants.TextLength && Cores.UseCheck(Text, true))
                {
                    using SHA384 SHA384 = SHA384.Create();
                    byte[] Result = SHA384.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Text));
                    StringBuilder Builder = new();
                    for (int i = 0; i < Result.Length; i++)
                    {
                        Builder.Append(Result[i].ToString("x2"));
                    }

                    return Uppercase == false ? Builder.ToString().ToLowerInvariant() : Builder.ToString().ToUpperInvariant();
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "CY-TTS3!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string TEXTtoSHA512(string Text, bool Uppercase = false, string Error = Constants.ErrorMessage)
        {
            try
            {
                if (Text.Length <= Constants.TextLength && Cores.UseCheck(Text, true))
                {
                    using SHA512 SHA512 = SHA512.Create();
                    byte[] Result = SHA512.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Text));
                    StringBuilder Builder = new();
                    for (int i = 0; i < Result.Length; i++)
                    {
                        Builder.Append(Result[i].ToString("x2"));
                    }

                    return Uppercase == false ? Builder.ToString().ToLowerInvariant() : Builder.ToString().ToUpperInvariant();
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constants.ErrorTitle + "CY-TTS4!)";
            }
        }
        #endregion
    }
}