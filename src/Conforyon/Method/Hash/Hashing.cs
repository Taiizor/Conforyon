﻿#region Imports

using Conforyon.Constant;
using Conforyon.Enum;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;

#endregion

namespace Conforyon.Hash
{
    /// <summary>
    /// 
    /// </summary>
    public class Hashing
    {
        #region Hashing
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string FILEtoMD5(string Path, bool Uppercase = false, string Error = Constants.ErrorMessage)
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
                return Error + Constants.ErrorTitle + "HH-FTM1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string FILEtoSHA1(string Path, bool Uppercase = false, string Error = Constants.ErrorMessage)
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
                return Error + Constants.ErrorTitle + "HH-FTS1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string FILEtoSHA256(string Path, bool Uppercase = false, string Error = Constants.ErrorMessage)
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
                return Error + Constants.ErrorTitle + "HH-FTS2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string FILEtoSHA384(string Path, bool Uppercase = false, string Error = Constants.ErrorMessage)
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
                return Error + Constants.ErrorTitle + "HH-FTS3!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string FILEtoSHA512(string Path, bool Uppercase = false, string Error = Constants.ErrorMessage)
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
                return Error + Constants.ErrorTitle + "HH-FTS4!)";
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
        public static Task<string> FILEtoHASH_Async(Enums.HashType Type, string Path, bool Uppercase = false, string Error = Constants.ErrorMessage)
        {
            try
            {
                return Type switch
                {
                    Enums.HashType.MD5 => new Task<string>(() => FILEtoMD5(Path, Uppercase, Error)),
                    Enums.HashType.SHA1 => new Task<string>(() => FILEtoSHA1(Path, Uppercase, Error)),
                    Enums.HashType.SHA256 => new Task<string>(() => FILEtoSHA256(Path, Uppercase, Error)),
                    Enums.HashType.SHA384 => new Task<string>(() => FILEtoSHA384(Path, Uppercase, Error)),
                    Enums.HashType.SHA512 => new Task<string>(() => FILEtoSHA512(Path, Uppercase, Error)),
                    _ => new Task<string>(() => Error),
                };
            }
            catch
            {
                return new Task<string>(() => Error + Constants.ErrorTitle + "HH-FTH1!)");
            }
        }
        #endregion
    }
}