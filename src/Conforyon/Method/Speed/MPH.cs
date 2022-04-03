#region Imports

using Conforyon.Constant;
using Conforyon.Value;
using System;
using CC = Conforyon.Cores;
using CCC = Conforyon.Constant.Constants;
using CEEMT = Conforyon.Enum.Enums.MethodType;
using CVV = Conforyon.Value.Values;
using SC = System.Convert;

#endregion

namespace Conforyon.Speed
{
    /// <summary>
    /// 
    /// </summary>
    public class MPH
    {
        #region MPH

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Miles"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Text"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string KPH(string Miles, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = CCC.ErrorMessage)
        {
            try
            {
                if (Miles.Length <= CCC.VariableLength && CC.NumberControl(Miles) && !Miles.StartsWith("0") && PostComma >= CCC.PostCommaMinimum && PostComma <= CCC.PostCommaMaximum && CC.TextControl(Miles))
                {
                    double Kilometers = SC.ToDouble(Miles) * SC.ToDouble(CVV.GetValue(CEEMT.Speed, "MPH", "KPH", Error));

                    string Result = CC.ResultFormat(Kilometers, Decimal, Comma, PostComma, Error);

                    if (Text)
                    {
                        Result = $"{Kilometers} KPH";
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
                return Error + CCC.ErrorTitle + "SD-KPH1!)";
            }
        }

        #endregion
    }
}