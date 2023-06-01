using System.Reflection;
using System.Runtime.InteropServices;

namespace Magic8Ball.WFClient;

/// <summary>
/// C# Extension Utility functions
/// </summary>
[ComVisible(false)]
public class Utils
{
    private static string? _Name;
    private static string? _Title;
    private static Version? _Version = null;
    private static string? _Copyright;
    private static string? _Company;
    private static string? _Description;
    private static string? _UserId;

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
                AssemblyName assemblyName = entryAssembly.GetName();
                _Name = assemblyName.Name
                     ?? throw new Exception($"Unknown assembly simple name for '{assemblyName.FullName}'");
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
                AssemblyName assemblyName = entryAssembly.GetName();
                _Version = assemblyName.Version
                     ?? throw new Exception($"Unknown assembly version for '{assemblyName.FullName}'");
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
        Console.WriteLine($"{Utils.Title}: {Message}");
        //Debug.Flush();
    }

    /// <summary>
    /// Log a .NET exception and descriptive message to debug output
    /// </summary>
    /// <param name="Ex">The .NET exception to log</param>
    /// <param name="Message">Descriptive text regarding the cause or operation that caused the exception</param>
    public static void LogErr(Exception Ex, string Message)
    {
        // Log a .NET exception and descriptive message to debug output
        Console.WriteLine($"{Utils.Title} Exception occurred: '{Message}'");
        Console.WriteLine($"Exception source: '{Ex.Source}', HRESULT: 0x{Ex.HResult:X}");
        Exception? inner = Ex.InnerException;
        if (null != inner)
        {
            Console.WriteLine($"Inner exception: '{inner.Message}'");
            Console.WriteLine($"Inner exception source: '{inner.Source}', HRESULT: 0x{inner.HResult:X}");
        }
        Console.WriteLine($"Exception details: {Ex}");
        //Debug.Flush();
    }
}
