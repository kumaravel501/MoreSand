using KumaravelAssesment.Models;
using KumaravelAssesment.Services.Interfaces;

namespace KumaravelAssesment.Services
{
    public class ImageService : IImageService
    {
        public  Task<byte[]> ManipulateImage(List<IFormFile> images, EffectModel model)
        {
            try
            {
                //here you can do the logic for manipulating image based on the style send
                return Task.FromResult(new byte[0]);
            } catch (Exception ex)
            {
                throw new Exception("Failed in Image manipulation due to" + ex.Message.ToString());
            }
        }
    }
}
