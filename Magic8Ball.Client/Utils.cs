using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Magic8Ball.WFClient
{
    /// <summary>
    /// C# Extension Utility functions
    /// </summary>
    [ComVisible(false)]
    public class Utils
    {
        private static string _Name;
        private static string _Title;
        private static Version _Version = null;
        private static string _Copyright;
        private static string _Company;
        private static string _Description;
        private static string _UserId;

        private Utils()
        {
            // Making this constructor private ensures no one can try to create
            // an instance of this class
        }

        /// <summary>
        /// Executing Assembly Name
        /// </summary>
        public static string Name
        {
            get
            {
                // Check if Assembly Name already extracted
                if (_Name == null)
                {
                    // Get Assembly Name from currently executing assembly
                    Assembly entryAssembly = Assembly.GetExecutingAssembly();
                    _Name = entryAssembly.GetName().Name;
                }
                // Return Assembly Name
                return _Name;
            }
        }

        /// <summary>
        /// Executing Assembly Title
        /// </summary>
        public static string Title
        {
            get
            {
                // Check if Assembly Title already extracted
                if (_Title == null)
                {
                    // Get Assembly Title from currently executing assembly
                    Assembly entryAssembly = Assembly.GetExecutingAssembly();
                    object[] objectAttrs = entryAssembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                    AssemblyTitleAttribute titleAttr = (AssemblyTitleAttribute)objectAttrs[0];
                    _Title = titleAttr.Title;
                }
                // Return Assembly Title
                return _Title;
            }
        }

        /// <summary>
        /// Executing Assembly Version
        /// </summary>
        public static Version Version
        {
            get
            {
                // Check if Assembly Version already extracted
                if (_Version == null)
                {
                    // Get Assembly Version from currently executing assembly
                    Assembly entryAssembly = Assembly.GetExecutingAssembly();
                    _Version = entryAssembly.GetName().Version;
                }
                // Return Assembly Version
                return _Version;
            }
        }

        /// <summary>
        /// Executing Assembly Copyright
        /// </summary>
        public static string Copyright
        {
            get
            {
                // Check if Assembly Copyright already extracted
                if (_Copyright == null)
                {
                    // Get Assembly Copyright from currently executing assembly
                    Assembly entryAssembly = Assembly.GetExecutingAssembly();
                    object[] objectAttrs = entryAssembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                    AssemblyCopyrightAttribute copyrightAttr = (AssemblyCopyrightAttribute)objectAttrs[0];
                    _Copyright = copyrightAttr.Copyright;
                }
                // Return Assembly Copyright
                return _Copyright;
            }
        }

        /// <summary>
        /// Executing Assembly Company
        /// </summary>
        public static string Company
        {
            get
            {
                // Check if Assembly Company already extracted
                if (_Company == null)
                {
                    // Get Assembly Company from currently executing assembly
                    Assembly entryAssembly = Assembly.GetExecutingAssembly();
                    object[] objectAttrs = entryAssembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                    AssemblyCompanyAttribute companyAttr = (AssemblyCompanyAttribute)objectAttrs[0];
                    _Company = companyAttr.Company;
                }
                // Return Assembly Company
                return _Company;
            }
        }

        /// <summary>
		/// Executing Assembly Description
		/// </summary>
		public static string Description
        {
            get
            {
                // Check if Assembly Description already extracted
                if (_Description == null)
                {
                    // Get Assembly Description from currently executing assembly
                    Assembly entryAssembly = Assembly.GetExecutingAssembly();
                    object[] objectAttrs = entryAssembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                    AssemblyDescriptionAttribute descriptionAttr = (AssemblyDescriptionAttribute)objectAttrs[0];
                    _Description = descriptionAttr.Description;
                }
                // Return Assembly Description
                return _Description;
            }
        }

        /// <summary>
        /// Domain\Username
        /// </summary>
        public static string UserId
        {
            get
            {
                // Check if Domain\Username already derived
                if (_UserId == null)
                {
                    // Get Domain\Username
                    _UserId = Environment.UserDomainName + @"\" + Environment.UserName;
                }
                // Return Domain\Username
                return _UserId;
            }
        }

        /// <summary>
        /// Log a text message to debug output
        /// </summary>
        /// <param name="Message">The text message to log</param>
        public static void LogMsg(string Message)
        {
            // Log the text message to debug output
            Debug.WriteLine($"{Utils.Title}: {Message}");
            Debug.Flush();
        }

        /// <summary>
        /// Log a .NET exception and descriptive message to debug output
        /// </summary>
        /// <param name="Eek">The .NET exception to log</param>
        /// <param name="Message">Descriptive text regarding the cause or operation that caused the exception</param>
        public static void LogErr(Exception Eek, string Message)
        {
            // Log a .NET exception and descriptive message to debug output
            Debug.WriteLine($"{Utils.Title} Exception occurred: '{Message}'");
            Debug.WriteLine($"Exception source: '{Eek.Source}', HRESULT: 0x{Eek.HResult:X}");
            Exception inner = Eek.InnerException;
            if (null != inner)
            {
                Debug.WriteLine($"Inner exception: '{inner.Message}'");
                Debug.WriteLine($"Inner exception source: '{inner.Source}', HRESULT: 0x{inner.HResult:X}");
            }
            Debug.WriteLine($"Exception details: {Eek}");
            Debug.Flush();
        }
    }
}
