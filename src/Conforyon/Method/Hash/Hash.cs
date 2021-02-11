#region Imports

using System;
using System.IO;
using System.Threading.Tasks;
using System.Security.Cryptography;

#endregion

namespace Conforyon.Hash
{
    /// <summary>
    /// 
    /// </summary>
    public class Hash
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string FILEtoMD5(string Path, bool Uppercase = false, string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                if (File.Exists(Path))
                {
                    using MD5 MD5 = new MD5CryptoServiceProvider();
                    using FileStream Stream = File.OpenRead(Path);
                    byte[] Hash = MD5.ComputeHash(Stream);
                    return Uppercase == false ? BitConverter.ToString(Hash).Replace("-", "").ToLowerInvariant() : BitConverter.ToString(Hash).Replace("-", "").ToUpperInvariant();
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constant.Constant.ErrorTitle + "HH-FTM1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string FILEtoSHA1(string Path, bool Uppercase = false, string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                if (File.Exists(Path))
                {
                    using SHA1 SHA1 = new SHA1CryptoServiceProvider();
                    using FileStream Stream = File.OpenRead(Path);
                    byte[] Hash = SHA1.ComputeHash(Stream);
                    return Uppercase == false ? BitConverter.ToString(Hash).Replace("-", "").ToLowerInvariant() : BitConverter.ToString(Hash).Replace("-", "").ToUpperInvariant();
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constant.Constant.ErrorTitle + "HH-FTS1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string FILEtoSHA256(string Path, bool Uppercase = false, string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                if (File.Exists(Path))
                {
                    using SHA256 SHA256 = new SHA256CryptoServiceProvider();
                    using FileStream Stream = File.OpenRead(Path);
                    byte[] Hash = SHA256.ComputeHash(Stream);
                    return Uppercase == false ? BitConverter.ToString(Hash).Replace("-", "").ToLowerInvariant() : BitConverter.ToString(Hash).Replace("-", "").ToUpperInvariant();
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constant.Constant.ErrorTitle + "HH-FTS2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string FILEtoSHA384(string Path, bool Uppercase = false, string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                if (File.Exists(Path))
                {
                    using SHA384 SHA384 = new SHA384CryptoServiceProvider();
                    using FileStream Stream = File.OpenRead(Path);
                    byte[] Hash = SHA384.ComputeHash(Stream);
                    return Uppercase == false ? BitConverter.ToString(Hash).Replace("-", "").ToLowerInvariant() : BitConverter.ToString(Hash).Replace("-", "").ToUpperInvariant();
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constant.Constant.ErrorTitle + "HH-FTS3!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string FILEtoSHA512(string Path, bool Uppercase = false, string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                if (File.Exists(Path))
                {
                    using SHA512 SHA512 = new SHA512CryptoServiceProvider();
                    using FileStream Stream = File.OpenRead(Path);
                    byte[] Hash = SHA512.ComputeHash(Stream);
                    return Uppercase == false ? BitConverter.ToString(Hash).Replace("-", "").ToLowerInvariant() : BitConverter.ToString(Hash).Replace("-", "").ToUpperInvariant();
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + Constant.Constant.ErrorTitle + "HH-FTS4!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Path"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static Task<string> FILEtoHASH_Async(Enum.Enum.HashType Type, string Path, bool Uppercase = false, string Error = Constant.Constant.ErrorMessage)
        {
            try
            {
                return Type switch
                {
                    Enum.Enum.HashType.MD5 => new Task<string>(() => FILEtoMD5(Path, Uppercase, Error)),
                    Enum.Enum.HashType.SHA1 => new Task<string>(() => FILEtoSHA1(Path, Uppercase, Error)),
                    Enum.Enum.HashType.SHA256 => new Task<string>(() => FILEtoSHA256(Path, Uppercase, Error)),
                    Enum.Enum.HashType.SHA384 => new Task<string>(() => FILEtoSHA384(Path, Uppercase, Error)),
                    Enum.Enum.HashType.SHA512 => new Task<string>(() => FILEtoSHA512(Path, Uppercase, Error)),
                    _ => new Task<string>(() => Error),
                };
            }
            catch
            {
                return new Task<string>(() => Error + Constant.Constant.ErrorTitle + "HH-FTH1!)");
            }
        }
    }
}