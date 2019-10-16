

using System.Reflection;
using Domain.Contracts;

namespace Domain.Services
{
    public class VersionService : ITellVersions
    {
        public string GetVersion()
        {
            return Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
        }
    }
}