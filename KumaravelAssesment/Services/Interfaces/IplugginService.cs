using KumaravelAssesment.Models;

namespace KumaravelAssesment.Services.Interfaces
{
    public interface IplugginService
    {
        Task<List<PlugginModel>> GetPluggins();
        Task<bool> Addpluggin(PlugginModel model);
        Task<bool> DeletePluginModel(int plugginId);
    }
}
