#region Imports

using CC = Conforyon.Cores;
using CCC = Conforyon.Constant.Constants;
using CEEIT = Conforyon.Enum.Enums.IntType;
using SC = System.Convert;
using STE = System.Text.Encoding;

#endregion

namespace Conforyon.Unicode
{
    /// <summary>
    /// 
    /// </summary>
    public class ASCII
    {
        #region ASCII

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ASCII"></param>
        /// <param name="Bracket"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CHAR(int ASCII, char Bracket = ',', string Error = CCC.ErrorMessage)
        {
            return CHAR($"{ASCII}", Bracket, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ASCII"></param>
        /// <param name="Bracket"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CHAR(double ASCII, char Bracket = ',', string Error = CCC.ErrorMessage)
        {
            return CHAR($"{ASCII}", Bracket, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ASCII"></param>
        /// <param name="Bracket"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CHAR(float ASCII, char Bracket = ',', string Error = CCC.ErrorMessage)
        {
            return CHAR($"{ASCII}", Bracket, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ASCII"></param>
        /// <param name="Bracket"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CHAR(char ASCII, char Bracket = ',', string Error = CCC.ErrorMessage)
        {
            return CHAR($"{ASCII}", Bracket, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ASCII"></param>
        /// <param name="Bracket"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CHAR(object ASCII, char Bracket = ',', string Error = CCC.ErrorMessage)
        {
            return CHAR($"{ASCII}", Bracket, Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ASCII"></param>
        /// <param name="Bracket"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string CHAR(string ASCII, char Bracket = ',', string Error = CCC.ErrorMessage)
        {
            try
            {
                if (ASCII.Length <= CCC.TextLength && CC.TextControl(ASCII, Bracket == ' '))
                {
                    string Result = string.Empty;

                    if (ASCII.Contains(Bracket.ToString()))
                    {
                        string[] Letters = ASCII.Split(Bracket);

                        for (int Count = 0; Count < Letters.Length; Count++)
                        {
                            if (CC.NumberControl(Letters[Count], false, CEEIT.Int32) && Letters[Count].Length >= CCC.ASCIIMinimum && Letters[Count].Length <= CCC.ASCIIMaximum && SC.ToInt32(Letters[Count]) >= CCC.ASCIINumberMinimum && SC.ToInt32(Letters[Count]) <= CCC.ASCIINumberMaximum)
                            {
                                Result += STE.UTF8.GetString(new byte[] { SC.ToByte(Letters[Count]) }); //STE.ASCII
                            }
                            else
                            {
                                return Error;
                            }
                        }
                    }
                    else
                    {
                        if (CC.NumberControl(ASCII, false, CEEIT.Int32) && ASCII.Length >= CCC.ASCIIMinimum && ASCII.Length <= CCC.ASCIIMaximum && SC.ToInt32(ASCII) >= CCC.ASCIINumberMinimum && SC.ToInt32(ASCII) <= CCC.ASCIINumberMaximum)
                        {
                            Result = STE.UTF8.GetString(new byte[] { SC.ToByte(ASCII) }); //STE.ASCII
                        }
                        else
                        {
                            return Error;
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
                return Error + CCC.ErrorTitle + "UE-CHAR1!)";
            }
        }

        #endregion
    }
}