using fakture_backend.Models;
using System.Threading.Tasks;

namespace fakture_backend
{
    public interface IAuthRepository
    {
        public Task<ServiceResponse<int>> Register(User user, string password);
    }
}
