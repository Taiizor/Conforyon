#region Imports

using CCC = Conforyon.Constant.Constants;
using SGCI = System.Globalization.CultureInfo;
using STT = System.Threading.Thread;

#endregion

namespace Conforyon.Culture
{
    /// <summary>
    /// 
    /// </summary>
    public class Cultures
    {
        #region Cultures

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static SGCI GetCulture()
        {
            return SGCI.CurrentCulture;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static SGCI GetUICulture()
        {
            return SGCI.CurrentUICulture;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static SGCI GetThreadCulture()
        {
            return STT.CurrentThread.CurrentCulture;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static SGCI GetThreadUICulture()
        {
            return STT.CurrentThread.CurrentUICulture;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string GetCultureName(string Error = CCC.ErrorMessage)
        {
            try
            {
                return SGCI.CurrentCulture.Name;
            }
            catch
            {
                return Error + CCC.ErrorTitle + "CE-CSGCN1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string GetUICultureName(string Error = CCC.ErrorMessage)
        {
            try
            {
                return SGCI.CurrentUICulture.Name;
            }
            catch
            {
                return Error + CCC.ErrorTitle + "CE-CSGUICN1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string GetThreadCultureName(string Error = CCC.ErrorMessage)
        {
            try
            {
                return STT.CurrentThread.CurrentCulture.Name;
            }
            catch
            {
                return Error + CCC.ErrorTitle + "CE-CSGTCN1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string GetThreadUICultureName(string Error = CCC.ErrorMessage)
        {
            try
            {
                return STT.CurrentThread.CurrentUICulture.Name;
            }
            catch
            {
                return Error + CCC.ErrorTitle + "CE-CSGTUICN1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Override"></param>
        /// <returns></returns>
        public static bool SetAllCulture(string Name = CCC.CultureName, bool Override = false)
        {
            try
            {
                if (SetCulture(Name, Override) && SetUICulture(Name, Override) && SetThreadCulture(Name, Override) && SetThreadUICulture(Name, Override))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Override"></param>
        /// <returns></returns>
        public static bool SetCulture(string Name = CCC.CultureName, bool Override = false)
        {
            try
            {
                return SetCulture(new(Name, Override));
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Override"></param>
        /// <returns></returns>
        public static bool SetUICulture(string Name = CCC.CultureName, bool Override = false)
        {
            try
            {
                return SetUICulture(new(Name, Override));
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Override"></param>
        /// <returns></returns>
        public static bool SetThreadCulture(string Name = CCC.CultureName, bool Override = false)
        {
            try
            {
                return SetThreadCulture(new(Name, Override));
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Override"></param>
        /// <returns></returns>
        public static bool SetThreadUICulture(string Name = CCC.CultureName, bool Override = false)
        {
            try
            {
                return SetThreadUICulture(new(Name, Override));
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Culture"></param>
        /// <returns></returns>
        public static bool SetAllCulture(SGCI Culture)
        {
            try
            {
                if (SetCulture(Culture) && SetUICulture(Culture) && SetThreadCulture(Culture) && SetThreadUICulture(Culture))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Culture"></param>
        /// <returns></returns>
        public static bool SetCulture(SGCI Culture)
        {
            try
            {
                SGCI.CurrentCulture = Culture;
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Culture"></param>
        /// <returns></returns>
        public static bool SetUICulture(SGCI Culture)
        {
            try
            {
                SGCI.CurrentUICulture = Culture;
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Culture"></param>
        /// <returns></returns>
        public static bool SetThreadCulture(SGCI Culture)
        {
            try
            {
                STT.CurrentThread.CurrentCulture = Culture;
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Culture"></param>
        /// <returns></returns>
        public static bool SetThreadUICulture(SGCI Culture)
        {
            try
            {
                STT.CurrentThread.CurrentUICulture = Culture;
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}