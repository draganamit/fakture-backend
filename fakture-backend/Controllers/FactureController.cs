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
        private readonly IFactureService _factureService1;

        public FactureController(IFactureService factureService1)
        {
            _factureService1 = factureService1;
        }
        
        [HttpGet("GetAllFacture")]
        public async Task<IActionResult> GetAllFacture()
        {
            ServiceResponse<List<GetAllFactureDto>> response = await _factureService1.GetAllFacture();
            if (response.Data == null)
            {
               return NotFound(response);
            }
            return Ok(response);
        }
    }
}
