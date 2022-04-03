#region Imports

using STE = System.Text.Encoding;

#endregion

namespace Conforyon.Helper
{
    /// <summary>
    /// 
    /// </summary>
    internal class Byte
    {
        #region Byte

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static byte[] Bytes(string Text)
        {
            return STE.UTF8.GetBytes(Text);
        }

        #endregion
    }
}