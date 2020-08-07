#region Imports

using System;
using System.IO;
using static Conforyon.Conforyon;
using System.Security.Cryptography;

#endregion

namespace Conforyon
{
    public static class Hash
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Mod"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string FILEtoMD5(string Path, bool Mod = false, string Error = ErrorMessage)
        {
            try
            {
                if (File.Exists(Path))
                {
                    using (MD5 MD5 = new MD5CryptoServiceProvider())
                    {
                        using (var Stream = File.OpenRead(Path))
                        {
                            var Hash = MD5.ComputeHash(Stream);
                            return Mod == false ? BitConverter.ToString(Hash).Replace("-", "").ToLowerInvariant() : BitConverter.ToString(Hash).Replace("-", "").ToUpperInvariant();
                        }
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "HH-FTM1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Mod"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string FILEtoSHA1(string Path, bool Mod = false, string Error = ErrorMessage)
        {
            try
            {
                if (File.Exists(Path))
                {
                    using (SHA1 SHA1 = new SHA1CryptoServiceProvider())
                    {
                        using (var Stream = File.OpenRead(Path))
                        {
                            var Hash = SHA1.ComputeHash(Stream);
                            return Mod == false ? BitConverter.ToString(Hash).Replace("-", "").ToLowerInvariant() : BitConverter.ToString(Hash).Replace("-", "").ToUpperInvariant();
                        }
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "HH-FTS1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Mod"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string FILEtoSHA256(string Path, bool Mod = false, string Error = ErrorMessage)
        {
            try
            {
                if (File.Exists(Path))
                {
                    using (SHA256 SHA256 = new SHA256CryptoServiceProvider())
                    {
                        using (var Stream = File.OpenRead(Path))
                        {
                            var Hash = SHA256.ComputeHash(Stream);
                            return Mod == false ? BitConverter.ToString(Hash).Replace("-", "").ToLowerInvariant() : BitConverter.ToString(Hash).Replace("-", "").ToUpperInvariant();
                        }
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "HH-FTS2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Mod"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string FILEtoSHA384(string Path, bool Mod = false, string Error = ErrorMessage)
        {
            try
            {
                if (File.Exists(Path))
                {
                    using (SHA384 SHA384 = new SHA384CryptoServiceProvider())
                    {
                        using (var Stream = File.OpenRead(Path))
                        {
                            var Hash = SHA384.ComputeHash(Stream);
                            return Mod == false ? BitConverter.ToString(Hash).Replace("-", "").ToLowerInvariant() : BitConverter.ToString(Hash).Replace("-", "").ToUpperInvariant();
                        }
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "HH-FTS3!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Mod"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string FILEtoSHA512(string Path, bool Mod = false, string Error = ErrorMessage)
        {
            try
            {
                if (File.Exists(Path))
                {
                    using (SHA512 SHA512 = new SHA512CryptoServiceProvider())
                    {
                        using (var Stream = File.OpenRead(Path))
                        {
                            var Hash = SHA512.ComputeHash(Stream);
                            return Mod == false ? BitConverter.ToString(Hash).Replace("-", "").ToLowerInvariant() : BitConverter.ToString(Hash).Replace("-", "").ToUpperInvariant();
                        }
                    }
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "HH-FTS4!)";
            }
        }
    }
}