using KumaravelAssesment.Services;
using KumaravelAssesment.Services.Interfaces;
using System.Runtime.CompilerServices;

namespace KumaravelAssesment
{
    internal static class DependencyRegisterService
    {
        public static void RegisterServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IImageService, ImageService>();
            builder.Services.AddScoped<IplugginService, PlugginService>();
        }
    }
}
