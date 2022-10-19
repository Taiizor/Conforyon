#region Imports

using CVC = Conforyon.Value.Caches;
using SIOF = System.IO.File;
using SIOMS = System.IO.MemoryStream;
using SIOS = System.IO.Stream;

#endregion

namespace Conforyon.Board
{
    /// <summary>
    /// 
    /// </summary>
    public class Audio
    {
        #region Audio

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        public static void Copy(string Path)
        {
            try
            {
                Copy(SIOF.ReadAllBytes(Path));
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
        public static void Copy(byte[] Bytes)
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
        public static SIOS Paste(bool Clear = false)
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