#region Imports

using Conforyon.Constant;
using System.IO;
using System.Windows.Forms;

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
        /// <param name="Copy"></param>
        public static void CopyText(string Text, bool Copy = true)
        {
            try
            {
                Clipboard.SetDataObject(Text, Copy);
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
                Clipboard.SetAudio(Bytes);
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
                IDataObject IData = Clipboard.GetDataObject();

                if (Clear)
                {
                    Clipboard.Clear();
                }

                if (IData.GetDataPresent(DataFormats.Text))
                {
                    return IData.GetData(DataFormats.Text) as string;
                }
                else
                {
                    return Back;
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
                Stream Audio = Clipboard.GetAudioStream();

                if (Clear)
                {
                    Clipboard.Clear();
                }

                return Audio;
            }
            catch
            {
                return Stream.Null;
            }
        }
        #endregion
    }
}