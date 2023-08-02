using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IUserService
    {
        Task<string> UpdateUser(string oldEmail, string oldPassword, string username, string password, string email);
        Task<bool> LoginAsync(string email, string password);
        Task<string> CreateUserAccount(string username, string password, string email);
    }
}
