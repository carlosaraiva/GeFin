using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GEFin.Model;

namespace GEFin.Application.Interfaces
{
    public interface IUserApplication
    {
         Task<User> Add(User user);

         Task<bool> Delete(Guid id);

         Task<bool> SetToAdmin(Guid id);

         Task<IEnumerable<User>> Get();

         Task<User> GetBy(Guid id);

         Task<User> GetBy(string email);

         Task<bool> checkUserExistsBy(string email);

         Task<bool> SaveAll();
    }
}