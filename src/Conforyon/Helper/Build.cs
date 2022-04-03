#region Imports

using STSB = System.Text.StringBuilder;

#endregion

namespace Conforyon.Helper
{
    /// <summary>
    /// 
    /// </summary>
    internal class Build
    {
        #region Build

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <returns></returns>
        public static STSB Builder(byte[] Result)
        {
            STSB Builder = new();

            for (int i = 0; i < Result.Length; i++)
            {
                Builder.Append(Result[i].ToString("x2"));
            }

            return Builder;
        }

        #endregion
    }
}