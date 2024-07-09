using Furion;
using System.Reflection;

namespace 景区系统.Web.Entry;

public class SingleFilePublish : ISingleFilePublish
{
    public Assembly[] IncludeAssemblies()
    {
        return Array.Empty<Assembly>();
    }

    public string[] IncludeAssemblyNames()
    {
        return new[]
        {
            "景区系统.Application",
            "景区系统.Core",
            "景区系统.EntityFramework.Core",
            "景区系统.Web.Core"
        };
    }
}