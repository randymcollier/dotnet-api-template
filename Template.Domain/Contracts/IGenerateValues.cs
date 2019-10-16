using System.Collections.Generic;
using System.Threading.Tasks;

namespace Template.Domain.Contracts
{
    public interface IGenerateValues
    {
        Task<string> GetValue(int id);
        Task<IEnumerable<string>> GetValues();
    }
}