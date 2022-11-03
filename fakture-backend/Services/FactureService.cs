using AutoMapper;
using fakture_backend.Data;
using fakture_backend.Dtos;
using fakture_backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fakture_backend.Services
{
    public class FactureService : IFactureService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public FactureService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<GetAllFactureDto>>> GetAllFacture()
        {
            ServiceResponse<List<GetAllFactureDto>> response = new ServiceResponse<List<GetAllFactureDto>>();
            List<Facture> facture = await _context.Facture.Include(x => x.Artikli).ToListAsync();
            response.Data = _mapper.Map<List<GetAllFactureDto>>(facture).ToList();
            return response;
        }
    }
}
