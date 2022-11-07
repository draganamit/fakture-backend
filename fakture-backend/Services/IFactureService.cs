using fakture_backend.Dtos;
using fakture_backend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fakture_backend.Services
{
    public interface IFactureService
    {
        public Task<ServiceResponse<List<GetAllFactureDto>>> GetAllFacture();
        public Task<ServiceResponse<List<GetAllFactureDto>>> DeleteFacture(int id);
        public Task<ServiceResponse<GetAllFactureDto>> GetFactureById(int id);
        public Task<ServiceResponse<List<GetAllFactureDto>>> AddFacture(AddFactureDto newFacture);
        public Task<ServiceResponse<GetAllFactureDto>> UpdateFacture(UpdateFactureDtocs updatedFacture);
    }
}
