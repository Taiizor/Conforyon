#region Imports

using CEEDT = Conforyon.Enum.Enums.DetectType;

#endregion

namespace Conforyon.Helper
{
    /// <summary>
    /// 
    /// </summary>
    internal class Detect
    {
        #region Detect

        private static string Result => (10 / 3f).ToString();

        /// <summary>
        /// 
        /// </summary>
        public static string String
        {
            get
            {
                if (Result.Contains("."))
                {
                    return ".";
                }
                else
                {
                    return ",";
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static char Char
        {
            get
            {
                if (Result.Contains("."))
                {
                    return '.';
                }
                else
                {
                    return ',';
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static CEEDT Enum
        {
            get
            {
                if (Result.Contains("."))
                {
                    return CEEDT.Dot;
                }
                else if (Result.Contains(","))
                {
                    return CEEDT.Comma;
                }
                else
                {
                    return CEEDT.None;
                }
            }
        }

        #endregion
    }
}