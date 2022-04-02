#region Imports

using CCC = Conforyon.Constant.Constants;
using CVC = Conforyon.Value.Caches;

#endregion

namespace Conforyon.Board
{
    /// <summary>
    /// 
    /// </summary>
    public class Text
    {
        #region Text

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        public static void Copy(object Value)
        {
            Copy($"{Value}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Number"></param>
        public static void Copy(int Number)
        {
            Copy($"{Number}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        public static void Copy(string Text)
        {
            try
            {
                CVC.Board = Text;
            }
            catch
            {
                return;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Clear"></param>
        /// <param name="Back"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string Paste(bool Clear = false, string Back = CCC.EmptyMessage, string Error = CCC.ErrorMessage)
        {
            try
            {
                string Text = CVC.Board;

                if (Clear)
                {
                    CVC.Board = string.Empty;
                }

                if (string.IsNullOrEmpty(Text))
                {
                    return Back;
                }
                else
                {
                    return Text;
                }
            }
            catch
            {
                return Error + CCC.ErrorTitle + "BD-TP1!)";
            }
        }

        #endregion
    }
}