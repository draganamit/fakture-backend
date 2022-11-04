using fakture_backend.Dtos;
using fakture_backend.Models;
using fakture_backend.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace fakture_backend.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class FactureController : ControllerBase
    {
        private readonly IFactureService _factureService;

        public FactureController(IFactureService factureService)
        {
            _factureService = factureService;
        }
        
        [HttpGet("GetAllFacture")]
        public async Task<IActionResult> GetAllFacture()
        {
            ServiceResponse<List<GetAllFactureDto>> response = await _factureService.GetAllFacture();
            if (response.Data == null)
            {
               return NotFound(response);
            }
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFacture(int id)
        {
            ServiceResponse<List<GetAllFactureDto>> response = await _factureService.DeleteFacture(id);
            if(response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
