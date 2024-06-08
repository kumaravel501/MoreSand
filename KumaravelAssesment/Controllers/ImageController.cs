using KumaravelAssesment.Models;
using KumaravelAssesment.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KumaravelAssesment.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    //Made this internal as you mentioned its should not accessbile to client or another server
    internal class ImageController : ControllerBase
    {
        private IImageService _imageService;
        public ImageController(IImageService imageService) 
        {
            _imageService = imageService;
        }

        [HttpPost]
        [Route("Upload")]
        public async Task<IActionResult> ManipulateImage(List<IFormFile> images, [FromForm] EffectModel model)
        {
            try
            {
                var result = await _imageService.ManipulateImage(images, model);
                return File(result, "png/jpeg");
            } catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }
    }
}
