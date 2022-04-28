using System.Threading.Tasks;
using GEFin.Model;

namespace GEFin.Application.Interfaces
{
    public interface IAuthApplication
    {
        Task<User> Login(string email, string password);
    }
}