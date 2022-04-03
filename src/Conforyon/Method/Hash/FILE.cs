#region Imports

using CCC = Conforyon.Constant.Constants;
using CEEHT = Conforyon.Enum.Enums.HashType;
using CHC = Conforyon.Helper.Case;
using SBC = System.BitConverter;
using SIOF = System.IO.File;
using SIOFS = System.IO.FileStream;
using SSCMD5 = System.Security.Cryptography.MD5;
using SSCMD5CSP = System.Security.Cryptography.MD5CryptoServiceProvider;
using SSCSHA1 = System.Security.Cryptography.SHA1;
using SSCSHA1CSP = System.Security.Cryptography.SHA1CryptoServiceProvider;
using SSCSHA256 = System.Security.Cryptography.SHA256;
using SSCSHA256CSP = System.Security.Cryptography.SHA256CryptoServiceProvider;
using SSCSHA384 = System.Security.Cryptography.SHA384;
using SSCSHA384CSP = System.Security.Cryptography.SHA384CryptoServiceProvider;
using SSCSHA512 = System.Security.Cryptography.SHA512;
using SSCSHA512CSP = System.Security.Cryptography.SHA512CryptoServiceProvider;
using STTT = System.Threading.Tasks.Task<string>;

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
        public static string MD5(object Path, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return MD5($"{Path}", Uppercase, Error);
        }

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
                    using SSCMD5 MD5 = new SSCMD5CSP();

                    using SIOFS Stream = SIOF.OpenRead(Path);

                    byte[] Hash = MD5.ComputeHash(Stream);

                    return CHC.Format(SBC.ToString(Hash).Replace("-", ""), Uppercase);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "HH-FMD51!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA1(object Path, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return SHA1($"{Path}", Uppercase, Error);
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
                    using SSCSHA1 SHA1 = new SSCSHA1CSP();

                    using SIOFS Stream = SIOF.OpenRead(Path);

                    byte[] Hash = SHA1.ComputeHash(Stream);

                    return CHC.Format(SBC.ToString(Hash).Replace("-", ""), Uppercase);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "HH-FSHA11!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA256(object Path, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return SHA256($"{Path}", Uppercase, Error);
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
                    using SSCSHA256 SHA256 = new SSCSHA256CSP();

                    using SIOFS Stream = SIOF.OpenRead(Path);

                    byte[] Hash = SHA256.ComputeHash(Stream);

                    return CHC.Format(SBC.ToString(Hash).Replace("-", ""), Uppercase);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "HH-FSHA2561!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA384(object Path, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return SHA384($"{Path}", Uppercase, Error);
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
                    using SSCSHA384 SHA384 = new SSCSHA384CSP();

                    using SIOFS Stream = SIOF.OpenRead(Path);

                    byte[] Hash = SHA384.ComputeHash(Stream);

                    return CHC.Format(SBC.ToString(Hash).Replace("-", ""), Uppercase);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "HH-FSHA3841!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Uppercase"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string SHA512(object Path, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            return SHA512($"{Path}", Uppercase, Error);
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
                    using SSCSHA512 SHA512 = new SSCSHA512CSP();

                    using SIOFS Stream = SIOF.OpenRead(Path);

                    byte[] Hash = SHA512.ComputeHash(Stream);

                    return CHC.Format(SBC.ToString(Hash).Replace("-", ""), Uppercase);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "HH-FSHA5121!)";
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
        public static STTT HASH_Async(CEEHT Type, string Path, bool Uppercase = false, string Error = CCC.ErrorMessage)
        {
            try
            {
                return Type switch
                {
                    CEEHT.MD5 => new STTT(() => MD5(Path, Uppercase, Error)),
                    CEEHT.SHA1 => new STTT(() => SHA1(Path, Uppercase, Error)),
                    CEEHT.SHA256 => new STTT(() => SHA256(Path, Uppercase, Error)),
                    CEEHT.SHA384 => new STTT(() => SHA384(Path, Uppercase, Error)),
                    CEEHT.SHA512 => new STTT(() => SHA512(Path, Uppercase, Error)),
                    _ => new STTT(() => Error),
                };
            }
            catch
            {
                return new STTT(() => Error + CCC.ErrorTitle + "HH-FHASHA1!)");
            }
        }

        #endregion
    }
}