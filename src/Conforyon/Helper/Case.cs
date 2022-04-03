#region Imports

using STSB = System.Text.StringBuilder;

#endregion

namespace Conforyon.Helper
{
    /// <summary>
    /// 
    /// </summary>
    internal class Case
    {
        #region Case

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <param name="Case"></param>
        /// <returns></returns>
        public static string Format(STSB Result, bool Case)
        {
            return Format($"{Result}", Case);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <param name="Case"></param>
        /// <returns></returns>
        public static string Format(object Result, bool Case)
        {
            return Format($"{Result}", Case);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <param name="Case"></param>
        /// <returns></returns>
        public static string Format(string Result, bool Case)
        {
            return Case == false ? Result.ToLowerInvariant() : Result.ToUpperInvariant();
        }

        #endregion
    }
}