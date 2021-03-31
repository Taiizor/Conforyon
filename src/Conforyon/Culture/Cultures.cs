#region Imports

using Conforyon.Constant;
using System.Globalization;
using System.Threading;

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
        public static CultureInfo GetCulture()
        {
            return CultureInfo.CurrentCulture;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static CultureInfo GetUICulture()
        {
            return CultureInfo.CurrentUICulture;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static CultureInfo GetThreadCulture()
        {
            return Thread.CurrentThread.CurrentCulture;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static CultureInfo GetThreadUICulture()
        {
            return Thread.CurrentThread.CurrentUICulture;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string GetCultureName(string Error = Constants.ErrorMessage)
        {
            try
            {
                return CultureInfo.CurrentCulture.Name;
            }
            catch
            {
                return Error + Constants.ErrorTitle + "CS-GCN1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string GetUICultureName(string Error = Constants.ErrorMessage)
        {
            try
            {
                return CultureInfo.CurrentUICulture.Name;
            }
            catch
            {
                return Error + Constants.ErrorTitle + "CS-GCN2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string GetThreadCultureName(string Error = Constants.ErrorMessage)
        {
            try
            {
                return Thread.CurrentThread.CurrentCulture.Name;
            }
            catch
            {
                return Error + Constants.ErrorTitle + "CS-GCN3!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string GetThreadUICultureName(string Error = Constants.ErrorMessage)
        {
            try
            {
                return Thread.CurrentThread.CurrentUICulture.Name;
            }
            catch
            {
                return Error + Constants.ErrorTitle + "CS-GCN4!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Override"></param>
        /// <returns></returns>
        public static bool SetCulture(string Name = Constants.CultureName, bool Override = false)
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
        public static bool SetUICulture(string Name = Constants.CultureName, bool Override = false)
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
        public static bool SetThreadCulture(string Name = Constants.CultureName, bool Override = false)
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
        public static bool SetThreadUICulture(string Name = Constants.CultureName, bool Override = false)
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
        public static bool SetCulture(CultureInfo Culture)
        {
            try
            {
                CultureInfo.CurrentCulture = Culture;
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
        public static bool SetUICulture(CultureInfo Culture)
        {
            try
            {
                CultureInfo.CurrentUICulture = Culture;
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
        public static bool SetThreadCulture(CultureInfo Culture)
        {
            try
            {
                Thread.CurrentThread.CurrentCulture = Culture;
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
        public static bool SetThreadUICulture(CultureInfo Culture)
        {
            try
            {
                Thread.CurrentThread.CurrentUICulture = Culture;
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