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
    public class ArticleService : IArticleService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ArticleService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<GetAllFactureDto>>> DeleteArticle(int id)
        {
            ServiceResponse<List<GetAllFactureDto>> response = new ServiceResponse<List<GetAllFactureDto>>();
            try
            {
                Article article = await _context.Article.FirstOrDefaultAsync(x => x.Id == id);
                _context.Article.Remove(article);
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
    }
}
