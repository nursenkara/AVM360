using Identity.Domain.Entities.Authentications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Application.Services.Authentications
{
    public interface IUserService
    {
        Task<int> CreateAsync(User user, string password, string roleName);
        Task<User> GetUserByEmail(string email);
    }
}
