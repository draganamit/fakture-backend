using fakture_backend.Dtos;
using fakture_backend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fakture_backend.Services
{
    public interface IArticleService
    {
        public Task<ServiceResponse<List<GetAllFactureDto>>> DeleteArticle(int id);

    }
}
