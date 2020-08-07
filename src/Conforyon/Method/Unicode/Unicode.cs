#region Imports

using System;
using System.Linq;
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
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string ASCIItoCHAR(string Variable, char Bracket = ',', string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= TextLength && Variable.Contains(Bracket) && UseCheck(Variable))
                {
                    string Result = "";
                    string[] Letterler = Variable.Split(Bracket);
                    for (int i = 0; i < Letterler.Length; i++)
                    {
                        if (NumberCheck(Letterler[i], false, IntType.Int32) && Letterler[i].Length >= 1 && Letterler[i].Length <= 3 && Convert.ToInt32(Letterler[i]) >= 0 && Convert.ToInt32(Letterler[i]) <= 255)
                            Result += UTF8Encoding.UTF8.GetString(new byte[] { Convert.ToByte(Letterler[i]) }); //Encoding.ASCII
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