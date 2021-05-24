using CoreBoilerplate.Shared.Settings;
using System.Threading.Tasks;

namespace CoreBoilerplate.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();
    }
}
