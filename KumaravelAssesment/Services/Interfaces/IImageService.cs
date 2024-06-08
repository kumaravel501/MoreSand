using KumaravelAssesment.Models;

namespace KumaravelAssesment.Services.Interfaces
{
    public interface IImageService
    {
        Task<byte[]> ManipulateImage(List<IFormFile> imageSource, EffectModel model);
    }
}
