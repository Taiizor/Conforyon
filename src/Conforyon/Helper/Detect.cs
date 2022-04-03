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

        /// <summary>
        /// 
        /// </summary>
        private static string Example => $"{10 / 3f}";

        /// <summary>
        /// 
        /// </summary>
        public static char Char
        {
            get
            {
                if (Example.Contains("."))
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
        public static object Object => Char;

        /// <summary>
        /// 
        /// </summary>
        public static string String => $"{Char}";

        /// <summary>
        /// 
        /// </summary>
        public static CEEDT Enum
        {
            get
            {
                string Result = String;

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