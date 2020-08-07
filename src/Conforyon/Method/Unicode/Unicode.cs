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
        /// <param name="Variable"></param>
        /// <param name="Bracket"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CHARtoASCII(string Variable, char Bracket = ',', string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= TextLength && UseCheck(Variable, true))
                {
                    string Result = "";
                    byte[] LetterByte;
                    for (int i = 0; i < Variable.Length; i++)
                    {
                        LetterByte = UTF8Encoding.UTF8.GetBytes(Variable.Substring(i, 1)); //Encoding.ASCII
                        if (i < Variable.Length - 1)
                            Result += LetterByte[0] + Bracket;
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
        /// <param name="Variable"></param>
        /// <param name="Bracket"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string ASCIItoCHAR(string Variable, char Bracket = ',', string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= TextLength && UseCheck(Variable))
                {
                    string Result = "";
                    string[] Letters = Variable.Split(Bracket);
                    for (int i = 0; i < Letters.Length; i++)
                    {
                        if (NumberCheck(Letters[i], false, IntType.Int32) && Letters[i].Length >= 1 && Letters[i].Length <= 3 && Convert.ToInt32(Letters[i]) >= 0 && Convert.ToInt32(Letters[i]) <= 255)
                            Result += UTF8Encoding.UTF8.GetString(new byte[] { Convert.ToByte(Letters[i]) }); //Encoding.ASCII
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