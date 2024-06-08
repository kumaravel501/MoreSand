using KumaravelAssesment.Models;
using KumaravelAssesment.Services.Interfaces;
using Newtonsoft.Json;

namespace KumaravelAssesment.Services
{
    public class PlugginService : IplugginService
    {
        private string filePath = string.Empty;
        private List<PlugginModel> models;
        public PlugginService(IWebHostEnvironment environment) {

            filePath = Path.Combine(environment.ContentRootPath, @"Data\", "pluggin.json");
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                content = content.Replace("\r\n", "").Trim();
                if (!string.IsNullOrWhiteSpace(content) && content != "{}")
                {
                    models = JsonConvert.DeserializeObject<List<PlugginModel>>(content);
                }
                else
                    models = new List<PlugginModel>();
            }
            else
            {
                models = new List<PlugginModel>();
            }
        }

        public Task<List<PlugginModel>> GetPluggins()
        {
            return Task.FromResult(models);
        }
        public Task<bool> Addpluggin(PlugginModel model)
        {
            models.Add(model);
            var result = SaveChanges();
            return Task.FromResult(result);
        }
        public Task<bool> DeletePluginModel(int plugginId)
        {
            var model = models.FirstOrDefault(m => m.PlugginId == plugginId);
            var result = false;
            if (model != null)
            {
                models.Remove(model);
                result = SaveChanges();
            }
            return Task.FromResult(result);
        }
        private bool SaveChanges()
        {
            try
            {
                string json = JsonConvert.SerializeObject(models);
                File.WriteAllText(filePath, json);
                return true;
            } catch
            {
                return false;
            }
        }
    }
}
