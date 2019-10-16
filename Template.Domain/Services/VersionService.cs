using System.Reflection;
using Template.Domain.Contracts;

namespace Template.Domain.Services
{
    public class VersionService : ITellVersions
    {
        public string GetVersion()
        {
            return Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
        }
    }
}