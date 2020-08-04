#region Imports

using System.Drawing;
using System.Windows.Forms;
using static Conforyon.Conforyon;

#endregion

namespace Conforyon
{
    public static class ClipBoard
    {
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
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string PasteText(bool Clear = false, string Error = ErrorMessage)
        {
            try
            {
                IDataObject IData = Clipboard.GetDataObject();

                if (Clear)
                    Clipboard.Clear();

                if (IData.GetDataPresent(DataFormats.Text))
                    return (string)IData.GetData(DataFormats.Text);
                else
                    return "Data not found.";
            }
            catch
            {
                return Error + ErrorTitle + "1P!)";
            }
        }
    }
}