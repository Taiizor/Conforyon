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
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CHARtoASCII(string Variable, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= 32767 && UseCheck(Variable, true))
                {
                    string Sonuç = "";
                    byte[] LetterByte;
                    for (int i = 0; i < Variable.Length; i++)
                    {
                        LetterByte = UTF8Encoding.UTF8.GetBytes(Variable.Substring(i, 1)); //Encoding.ASCII
                        if (i < Variable.Length - 1)
                            Sonuç += LetterByte[0] + ",";
                        else
                            Sonuç += LetterByte[0].ToString();
                    }
                    return Sonuç;
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1T!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string ASCIItoCHAR(string Variable, string Error = ErrorMessage)
        {
            try
            {
                if (Variable.Length <= 32767 && UseCheck(Variable))
                {
                    string Sonuç = "";
                    char[] Ayraçlar = { ',' };
                    string[] Letterler = Variable.Split(Ayraçlar);
                    for (int i = 0; i < Letterler.Length; i++)
                    {
                        if (NumberCheck(Letterler[i], true) == true && Letterler[i].Length >= 1 && Letterler[i].Length <= 3 && Convert.ToInt32(Letterler[i]) >= 0 && Convert.ToInt32(Letterler[i]) <= 255)
                            Sonuç += UTF8Encoding.UTF8.GetString(new byte[] { Convert.ToByte(Letterler[i]) }); //Encoding.ASCII
                        else
                            return Error;
                    }
                    return Sonuç;
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1A!)";
            }
        }
    }
}