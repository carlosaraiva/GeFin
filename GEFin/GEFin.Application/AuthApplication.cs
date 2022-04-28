using System.Threading.Tasks;
using GEFin.Application.Interfaces;
using GEFin.Model;
using GEFin.Repository;
using GEFin.Repository.Interfaces;

namespace GEFin.Application
{
    public class AuthApplication : IAuthApplication
    {
        private readonly IUserRepository _userRepository;
        private readonly IBCryptApplication _bCryptApplication;
        public AuthApplication(IUserRepository userRepository, IBCryptApplication bCryptApplication)
        {
            this._bCryptApplication = bCryptApplication;
            this._userRepository = userRepository;
        }

        public async Task<User> Login(string email, string password)
        {
            User user = await this._userRepository.GetBy(email);

            if (user == null)
                return null;

            if (!this._bCryptApplication.ValidatePassword(password, user.Password))
                return null;

            return user;
        }
    }
}