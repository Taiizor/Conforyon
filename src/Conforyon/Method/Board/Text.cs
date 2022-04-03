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
        /// <param name="Number"></param>
        public static void Copy(int Number)
        {
            Copy($"{Number}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Number"></param>
        public static void Copy(double Number)
        {
            Copy($"{Number}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Number"></param>
        public static void Copy(float Number)
        {
            Copy($"{Number}");
        }

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
        /// <param name="Text"></param>
        public static void Copy(string Text)
        {
            CVC.Board = Text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Clear"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static string Paste(bool Clear = false, string Back = CCC.EmptyMessage)
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

        #endregion
    }
}