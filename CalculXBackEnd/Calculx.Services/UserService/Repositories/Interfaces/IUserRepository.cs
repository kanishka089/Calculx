using CalculX.Base.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Entities;

namespace UserService.Repositories.Interfaces
{
    public interface IUserRepository: IGenericRepository<User>
    {
        Task<User> GetUserByEmailAsync(string email);
    }
}
