using KumaravelAssesment.Models;
using KumaravelAssesment.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KumaravelAssesment.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    //Made this internal as you mentioned its should not accessbile to client or another server
    internal class PluginController : ControllerBase
    {
        IplugginService _plugginService;
       public PluginController(IplugginService plugginService) {
            _plugginService = plugginService;
        }

        [Route("Pluggins")]
        [HttpGet]
        public async Task<IActionResult> GetPluggins()
        {
            try
            {
                var result = await _plugginService.GetPluggins();
                return Ok(result);
            } catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex}");
            }
        }

        [Route("Add")]
        [HttpPost]
        public async Task<IActionResult> AddPlugging([FromBody] PlugginModel model)
        {
            try
            {
                var result = await _plugginService.Addpluggin(model);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Adding pluggin Error: {ex}");
            }
        }
        [Route("Delete")]
        [HttpDelete]
        public async Task<IActionResult> DeletePluggin(int id)
        {
            try
            {
                var result = await _plugginService.DeletePluginModel(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"delete pluggin Error: {ex}");
            }
        }
    }
}
