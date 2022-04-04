#region Imports

using SSCCM = System.Security.Cryptography.CipherMode;

#endregion

namespace Conforyon.Constant
{
    /// <summary>
    /// 
    /// </summary>
    internal class Constants
    {
        #region Constants

        /// <summary>
        /// 
        /// </summary>
        public const string ErrorTitle = " (CN-";

        /// <summary>
        /// 
        /// </summary>
        public const string ErrorMessage = "Error!";

        /// <summary>
        /// 
        /// </summary>
        public const string EmptyMessage = "Empty!";

        /// <summary>
        /// 
        /// </summary>
        public const string CultureName = "en-GB";

        /// <summary>
        /// 
        /// </summary>
        public const string FormatValue = "{0}->{1}->{2}->{3}";

        /// <summary>
        /// 
        /// </summary>
        public const string IV = "QxQsRoZQws61N46H";

        /// <summary>
        /// 
        /// </summary>
        public const string Key = "uS830kWPrPSPyZK0pS7Pgw3wP3SvLOGr";

        /// <summary>
        /// 
        /// </summary>
        public const SSCCM Mode = SSCCM.CBC;

        /// <summary>
        /// 
        /// </summary>
        public const int VariableLength = 15;

        /// <summary>
        /// 
        /// </summary>
        public const int PostCommaMinimum = 0;

        /// <summary>
        /// 
        /// </summary>
        public const int PostCommaMaximum = 99;

        /// <summary>
        /// 
        /// </summary>
        public const int ASCIIMinimum = 1;

        /// <summary>
        /// 
        /// </summary>
        public const int ASCIIMaximum = 3;

        /// <summary>
        /// 
        /// </summary>
        public const int ASCIINumberMinimum = 0;

        /// <summary>
        /// 
        /// </summary>
        public const int ASCIINumberMaximum = 255;

        /// <summary>
        /// 
        /// </summary>
        public const int IVLength = 16;

        /// <summary>
        /// 
        /// </summary>
        public const int KeyLength = 32;

        /// <summary>
        /// 
        /// </summary>
        public const int TextLength = 32767;

        #endregion
    }
}