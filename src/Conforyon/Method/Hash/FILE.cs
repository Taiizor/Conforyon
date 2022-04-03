#region Imports

using Conforyon.Constant;
using Conforyon.Enum;
using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

using SIOFS = System.IO.FileStream;
using SIOF = System.IO.File;
using CHC = Conforyon.Helper.Case;
using CC = Conforyon.Cores;
using CCC = Conforyon.Constant.Constants;
using CHB = Conforyon.Helper.Byte;
using SC = System.Convert;
using SIOMS = System.IO.MemoryStream;
using SSCA = System.Security.Cryptography.Aes;
using SSCCM = System.Security.Cryptography.CipherMode;
using SSCCS = System.Security.Cryptography.CryptoStream;
using SSCCSM = System.Security.Cryptography.CryptoStreamMode;
using SSCICT = System.Security.Cryptography.ICryptoTransform;
using STE = System.Text.Encoding;
using SSCMD5 = System.Security.Cryptography.MD5;
using SSCSHA1 = System.Security.Cryptography.SHA1;
using SSCSHA256 = System.Security.Cryptography.SHA256;
using SSCSHA384 = System.Security.Cryptography.SHA384;
using SSCSHA512 = System.Security.Cryptography.SHA512;

#endregion

namespace Conforyon.Hash
{
    /// <summary>
    /// 
    /// </summary>
    public class FILE
    {
        #region FILE

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string MD5(string Path, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (SIOF.Exists(Path))
                {
                    using SSCMD5 MD5 = new MD5CryptoServiceProvider();
                    using SIOFS Stream = SIOF.OpenRead(Path);
                    byte[] Hash = MD5.ComputeHash(Stream);

                    return CHC.Format(BitConverter.ToString(Hash).Replace("-", ""), Uppercase);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "HH-FTM1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA1(string Path, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (SIOF.Exists(Path))
                {
                    using SSCSHA1 SHA1 = new SHA1CryptoServiceProvider();
                    using SIOFS Stream = SIOF.OpenRead(Path);
                    byte[] Hash = SHA1.ComputeHash(Stream);

                    return CHC.Format(BitConverter.ToString(Hash).Replace("-", ""), Uppercase);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "HH-FTS1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA256(string Path, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (SIOF.Exists(Path))
                {
                    using SSCSHA256 SHA256 = new SHA256CryptoServiceProvider();
                    using SIOFS Stream = SIOF.OpenRead(Path);
                    byte[] Hash = SHA256.ComputeHash(Stream);

                    return CHC.Format(BitConverter.ToString(Hash).Replace("-", ""), Uppercase);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "HH-FTS2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA384(string Path, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (SIOF.Exists(Path))
                {
                    using SSCSHA384 SHA384 = new SHA384CryptoServiceProvider();
                    using SIOFS Stream = SIOF.OpenRead(Path);
                    byte[] Hash = SHA384.ComputeHash(Stream);

                    return CHC.Format(BitConverter.ToString(Hash).Replace("-", ""), Uppercase);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "HH-FTS3!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA512(string Path, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (SIOF.Exists(Path))
                {
                    using SSCSHA512 SHA512 = new SHA512CryptoServiceProvider();
                    using SIOFS Stream = SIOF.OpenRead(Path);
                    byte[] Hash = SHA512.ComputeHash(Stream);

                    return CHC.Format(BitConverter.ToString(Hash).Replace("-", ""), Uppercase);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "HH-FTS4!)";
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
        public static Task<string> HASH_Async(Enums.HashType Type, string Path, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            try
            {
                return Type switch
                {
                    Enums.HashType.MD5 => new Task<string>(() => MD5(Path, Uppercase, Error)),
                    Enums.HashType.SHA1 => new Task<string>(() => SHA1(Path, Uppercase, Error)),
                    Enums.HashType.SHA256 => new Task<string>(() => SHA256(Path, Uppercase, Error)),
                    Enums.HashType.SHA384 => new Task<string>(() => SHA384(Path, Uppercase, Error)),
                    Enums.HashType.SHA512 => new Task<string>(() => SHA512(Path, Uppercase, Error)),
                    _ => new Task<string>(() => Error),
                };
            }
            catch
            {
                return new Task<string>(() => Error + CCC.ErrorTitle + "HH-FTH1!)");
            }
        }

        #endregion
    }
}