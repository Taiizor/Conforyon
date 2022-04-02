#region Imports

using CCC = Conforyon.Constant.Constants;
using CVC = Conforyon.Value.Caches;
using SIOF = System.IO.File;
using SIOS = System.IO.Stream;
using SIOMS = System.IO.MemoryStream;

#endregion

namespace Conforyon.Board
{
    /// <summary>
    /// 
    /// </summary>
    public class ClipBoard
    {
        #region ClipBoard

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        public static void CopyText(string Text)
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
        /// <param name="Path"></param>
        public static void CopyAudio(string Path)
        {
            try
            {
                CopyAudio(SIOF.ReadAllBytes(Path));
            }
            catch
            {
                return;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Bytes"></param>
        public static void CopyAudio(byte[] Bytes)
        {
            try
            {
                CVC.Audio = Bytes;
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
        public static string GetText(bool Clear = false, string Back = CCC.EmptyMessage, string Error = CCC.ErrorMessage)
        {
            try
            {
                string Text = CVC.Board;

                if (Clear)
                {
                    CVC.Board = string.Empty; ;
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
                return Error + CCC.ErrorTitle + "BD-PT1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Clear"></param>
        public static SIOS GetAudio(bool Clear = false)
        {
            try
            {
                SIOS Stream = new SIOMS(CVC.Audio);


                if (Clear)
                {
                    CVC.Audio = System.Array.Empty<byte>();
                }

                return Stream;
            }
            catch
            {
                return SIOS.Null;
            }
        }
        #endregion
    }
}