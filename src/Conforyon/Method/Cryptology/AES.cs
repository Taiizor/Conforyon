#region Imports

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

#endregion

namespace Conforyon.Cryptology
{
    /// <summary>
    /// 
    /// </summary>
    public class AES
    {
        #region AES

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="IV"></param>
        /// <param name="Key"></param>
        /// <param name="Mode"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string Encrypt(int Text, string IV = CCC.IV, string Key = CCC.Key, SSCCM Mode = CCC.Mode, string Error = CCC.ErrorMessage)
        {
            return Encrypt($"{Text}", IV, Key, Mode, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="IV"></param>
        /// <param name="Key"></param>
        /// <param name="Mode"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string Encrypt(long Text, string IV = CCC.IV, string Key = CCC.Key, SSCCM Mode = CCC.Mode, string Error = CCC.ErrorMessage)
        {
            return Encrypt($"{Text}", IV, Key, Mode, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="IV"></param>
        /// <param name="Key"></param>
        /// <param name="Mode"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string Encrypt(double Text, string IV = CCC.IV, string Key = CCC.Key, SSCCM Mode = CCC.Mode, string Error = CCC.ErrorMessage)
        {
            return Encrypt($"{Text}", IV, Key, Mode, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="IV"></param>
        /// <param name="Key"></param>
        /// <param name="Mode"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string Encrypt(float Text, string IV = CCC.IV, string Key = CCC.Key, SSCCM Mode = CCC.Mode, string Error = CCC.ErrorMessage)
        {
            return Encrypt($"{Text}", IV, Key, Mode, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="IV"></param>
        /// <param name="Key"></param>
        /// <param name="Mode"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string Encrypt(object Text, string IV = CCC.IV, string Key = CCC.Key, SSCCM Mode = CCC.Mode, string Error = CCC.ErrorMessage)
        {
            return Encrypt($"{Text}", IV, Key, Mode, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="IV"></param>
        /// <param name="Key"></param>
        /// <param name="Mode"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string Encrypt(string Text, string IV = CCC.IV, string Key = CCC.Key, SSCCM Mode = CCC.Mode, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (Text.Length <= CCC.TextLength && IV.Length == CCC.IVLength && Key.Length == CCC.KeyLength && CC.TextControl(Text))
                {
                    return Encrypt(Text, CHB.Bytes(IV), CHB.Bytes(Key), Mode, Error);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "CY-AESE1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="IV"></param>
        /// <param name="Key"></param>
        /// <param name="Mode"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        private static string Encrypt(string Text, byte[] IV, byte[] Key, SSCCM Mode, string Error)
        {
            try
            {
                SSCA Encryptor = SSCA.Create();

                Encryptor.IV = IV;
                Encryptor.Key = Key;
                Encryptor.Mode = Mode;

                SIOMS MemoryStream = new();

                SSCICT Create = Encryptor.CreateEncryptor();

                SSCCS CryptoStream = new(MemoryStream, Create, SSCCSM.Write);

                string Result = string.Empty;

                try
                {
                    byte[] FirstBytes = STE.ASCII.GetBytes(Text);

                    CryptoStream.Write(FirstBytes, 0, FirstBytes.Length);
                    CryptoStream.FlushFinalBlock();

                    byte[] LastBytes = MemoryStream.ToArray();

                    Result = SC.ToBase64String(LastBytes, 0, LastBytes.Length);
                }
                finally
                {
                    MemoryStream.Close();
                    CryptoStream.Close();
                }

                return Result;
            }
            catch
            {
                return Error + CCC.ErrorTitle + "CY-AESE2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Base"></param>
        /// <param name="IV"></param>
        /// <param name="Key"></param>
        /// <param name="Mode"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string Decrypt(object Base, string IV = CCC.IV, string Key = CCC.Key, SSCCM Mode = CCC.Mode, string Error = CCC.ErrorMessage)
        {
            return Decrypt($"{Base}", IV, Key, Mode, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Base"></param>
        /// <param name="IV"></param>
        /// <param name="Key"></param>
        /// <param name="Mode"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string Decrypt(string Base, string IV = CCC.IV, string Key = CCC.Key, SSCCM Mode = CCC.Mode, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (Base.Length <= CCC.TextLength && IV.Length == CCC.IVLength && Key.Length == CCC.KeyLength && CC.TextControl(Base))
                {
                    return Decrypt(Base, CHB.Bytes(IV), CHB.Bytes(Key), Mode, Error);
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "CY-AESD1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Base"></param>
        /// <param name="IV"></param>
        /// <param name="Key"></param>
        /// <param name="Mode"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        private static string Decrypt(string Base, byte[] IV, byte[] Key, SSCCM Mode, string Error)
        {
            try
            {
                SSCA Decryptor = SSCA.Create();

                Decryptor.IV = IV;
                Decryptor.Key = Key;
                Decryptor.Mode = Mode;

                SIOMS MemoryStream = new();

                SSCICT Create = Decryptor.CreateDecryptor();

                SSCCS CryptoStream = new(MemoryStream, Create, SSCCSM.Write);

                string Result = string.Empty;

                try
                {
                    byte[] FirstBytes = SC.FromBase64String(Base);

                    CryptoStream.Write(FirstBytes, 0, FirstBytes.Length);
                    CryptoStream.FlushFinalBlock();

                    byte[] LastBytes = MemoryStream.ToArray();

                    Result = STE.ASCII.GetString(LastBytes, 0, LastBytes.Length);
                }
                finally
                {
                    MemoryStream.Close();
                    CryptoStream.Close();
                }

                return Result;
            }
            catch
            {
                return Error + CCC.ErrorTitle + "CY-AESD2!)";
            }
        }

        #endregion
    }
}