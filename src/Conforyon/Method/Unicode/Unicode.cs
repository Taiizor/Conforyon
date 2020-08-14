#region Imports

using System;
using System.Text;
using static Conforyon.Conforyon;

#endregion

namespace Conforyon
{
    public static class Unicode
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CHAR"></param>
        /// <param name="Bracket"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CHARtoASCII(string CHAR, char Bracket = ',', string Error = ErrorMessage)
        {
            try
            {
                if (CHAR.Length <= TextLength && UseCheck(CHAR, true))
                {
                    string Result = string.Empty;
                    byte[] LetterByte;
                    for (int i = 0; i < CHAR.Length; i++)
                    {
                        LetterByte = UTF8Encoding.UTF8.GetBytes(CHAR.Substring(i, 1)); //Encoding.ASCII
                        if (i < CHAR.Length - 1)
                            Result += LetterByte[0] + Bracket.ToString();
                        else
                            Result += LetterByte[0].ToString();
                    }
                    return Result;
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "UE-CTA1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ASCII"></param>
        /// <param name="Bracket"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string ASCIItoCHAR(string ASCII, char Bracket = ',', string Error = ErrorMessage)
        {
            try
            {
                if (ASCII.Length <= TextLength && UseCheck(ASCII, Bracket == ' '))
                {
                    string Result = string.Empty;
                    if (ASCII.Contains(Bracket.ToString()))
                    {
                        string[] Letters = ASCII.Split(Bracket);
                        for (int i = 0; i < Letters.Length; i++)
                        {
                            if (NumberCheck(Letters[i], false, IntType.Int32) && Letters[i].Length >= 1 && Letters[i].Length <= 3 && Convert.ToInt32(Letters[i]) >= 0 && Convert.ToInt32(Letters[i]) <= 255)
                                Result += UTF8Encoding.UTF8.GetString(new byte[] { Convert.ToByte(Letters[i]) }); //Encoding.ASCII
                            else
                                return Error;
                        }
                    }
                    else
                    {
                        if (NumberCheck(ASCII, false, IntType.Int32) && ASCII.Length >= 1 && ASCII.Length <= 3 && Convert.ToInt32(ASCII) >= 0 && Convert.ToInt32(ASCII) <= 255)
                            Result = UTF8Encoding.UTF8.GetString(new byte[] { Convert.ToByte(ASCII) }); //Encoding.ASCII
                        else
                            return Error;
                    }
                    return Result;
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "UE-ATC1!)";
            }
        }
    }
}