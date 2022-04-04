namespace Conforyon.Helper
{
    /// <summary>
    /// 
    /// </summary>
    internal class Format
    {
        #region Format

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Args"></param>
        /// <returns></returns>
        public static string Formatter(string Text, params object[] Args)
        {
            try
            {
                return string.Format(Text, Args);
            }
            catch
            {
                return Text;
            }
        }

        #endregion
    }
}