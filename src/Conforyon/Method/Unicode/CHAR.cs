#region Imports

using CC = Conforyon.Cores;
using CCC = Conforyon.Constant.Constants;
using STE = System.Text.Encoding;

#endregion

namespace Conforyon.Unicode
{
    /// <summary>
    /// 
    /// </summary>
    public class CHAR
    {
        #region CHAR

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CHAR"></param>
        /// <param name="Bracket"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string ASCII(int CHAR, char Bracket = ',', string Error = CCC.ErrorMessage)
        {
            return ASCII($"{CHAR}", Bracket, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CHAR"></param>
        /// <param name="Bracket"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string ASCII(long CHAR, char Bracket = ',', string Error = CCC.ErrorMessage)
        {
            return ASCII($"{CHAR}", Bracket, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CHAR"></param>
        /// <param name="Bracket"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string ASCII(double CHAR, char Bracket = ',', string Error = CCC.ErrorMessage)
        {
            return ASCII($"{CHAR}", Bracket, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CHAR"></param>
        /// <param name="Bracket"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string ASCII(float CHAR, char Bracket = ',', string Error = CCC.ErrorMessage)
        {
            return ASCII($"{CHAR}", Bracket, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CHAR"></param>
        /// <param name="Bracket"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string ASCII(char CHAR, char Bracket = ',', string Error = CCC.ErrorMessage)
        {
            return ASCII($"{CHAR}", Bracket, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CHAR"></param>
        /// <param name="Bracket"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string ASCII(object CHAR, char Bracket = ',', string Error = CCC.ErrorMessage)
        {
            return ASCII($"{CHAR}", Bracket, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CHAR"></param>
        /// <param name="Bracket"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string ASCII(string CHAR, char Bracket = ',', string Error = CCC.ErrorMessage)
        {
            try
            {
                if (CHAR.Length <= CCC.TextLength && CC.TextControl(CHAR, true))
                {
                    string Result = string.Empty;

                    byte[] LetterByte;

                    for (int Count = 0; Count < CHAR.Length; Count++)
                    {
                        LetterByte = STE.UTF8.GetBytes(CHAR.Substring(Count, 1)); //STE.ASCII

                        if (Count < CHAR.Length - 1)
                        {
                            Result += LetterByte[0] + Bracket.ToString();
                        }
                        else
                        {
                            Result += LetterByte[0].ToString();
                        }
                    }
                    return Result;
                }
                else
                {
                    return Error;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "UE-ASCII1!)";
            }
        }

        #endregion
    }
}