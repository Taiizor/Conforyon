#region Imports

using Conforyon.Constant;
using System.IO;

#endregion

namespace Conforyon.Board
{
    /// <summary>
    /// 
    /// </summary>
    public class ClipBoard
    {
        #region ClipBoard
        private static string Board = string.Empty;

        private static byte[] Audio = System.Array.Empty<byte>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        public static void CopyText(string Text)
        {
            try
            {
                Board = Text;
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
                CopyAudio(File.ReadAllBytes(Path));
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
                Audio = Bytes;
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
        public static string GetText(bool Clear = false, string Back = Constants.EmptyMessage, string Error = Constants.ErrorMessage)
        {
            try
            {
                string Text = Board;

                if (Clear)
                {
                    Board = string.Empty; ;
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
                return Error + Constants.ErrorTitle + "BD-PT1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Clear"></param>
        public static Stream GetAudio(bool Clear = false)
        {
            try
            {
                Stream Stream = new MemoryStream(Audio);


                if (Clear)
                {
                    Audio = System.Array.Empty<byte>();
                }

                return Stream;
            }
            catch
            {
                return Stream.Null;
            }
        }
        #endregion
    }
}