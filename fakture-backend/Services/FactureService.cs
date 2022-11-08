using AutoMapper;
using fakture_backend.Data;
using fakture_backend.Dtos;
using fakture_backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
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

        public async Task<ServiceResponse<List<GetAllFactureDto>>> AddFacture(AddFactureDto newFacture)
        {
            ServiceResponse<List<GetAllFactureDto>> response = new ServiceResponse<List<GetAllFactureDto>>();
            try
            {
                Facture facture = _mapper.Map<Facture>(newFacture);
                await _context.Facture.AddAsync(facture);
                await _context.SaveChangesAsync();
                List<Facture> factures = await _context.Facture.Include(x => x.Artikli).ToListAsync();
                response.Data = _mapper.Map<List<GetAllFactureDto>>(factures).ToList();
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetAllFactureDto>>> DeleteFacture(int id)
        {
            ServiceResponse<List<GetAllFactureDto>> response = new ServiceResponse<List<GetAllFactureDto>>();
            try
            {
                Facture facture = await _context.Facture.FirstOrDefaultAsync(x => x.Id == id);
                _context.Facture.Remove(facture);
                await _context.SaveChangesAsync();
                List<Facture> factures = await _context.Facture.Include(x => x.Artikli).ToListAsync();
                response.Data = _mapper.Map<List<GetAllFactureDto>>(factures).ToList();
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetAllFactureDto>>> GetAllFacture()
        {
            ServiceResponse<List<GetAllFactureDto>> response = new ServiceResponse<List<GetAllFactureDto>>();
            List<Facture> facture = await _context.Facture.Include(x => x.Artikli).ToListAsync();
            response.Data = _mapper.Map<List<GetAllFactureDto>>(facture).ToList();
            return response;
        }

        public async Task<ServiceResponse<GetAllFactureDto>> GetFactureById(int id)
        {
            ServiceResponse<GetAllFactureDto> response = new ServiceResponse<GetAllFactureDto>();
            Facture facture = await _context.Facture.Include(x => x.Artikli).FirstOrDefaultAsync(x => x.Id == id);
            response.Data = _mapper.Map<GetAllFactureDto>(facture);
            return response;
        }

        public async  Task<ServiceResponse<GetAllFactureDto>> UpdateFacture(UpdateFactureDtocs updatedFacture)
        {
            ServiceResponse<GetAllFactureDto> response = new ServiceResponse<GetAllFactureDto>();
            try
            {
                Facture facture = await _context.Facture.Include(x => x.Artikli).FirstOrDefaultAsync(x => x.Id == updatedFacture.Id);
                facture.Datum = updatedFacture.Datum;
                facture.Partner = updatedFacture.Partner;
                facture.IznosBezPdv = updatedFacture.IznosBezPdv;
                facture.IznosSaRabatomBezPdv = updatedFacture.IznosSaRabatomBezPdv;
                facture.Rabat = updatedFacture.Rabat;
                facture.PostoRabata = updatedFacture.PostoRabata;
                facture.Pdv = updatedFacture.Pdv;
                facture.Ukupno = updatedFacture.Ukupno;
                facture.Artikli = updatedFacture.Artikli;
                _context.Update(facture);
                await _context.SaveChangesAsync();
                response.Data = _mapper.Map<GetAllFactureDto>(facture);
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message=ex.Message;
            }
            return response;
        }
    }
}
