using DemoApp.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoApp.Service
{
    public interface IUserMasterService
    {
        UserMasters Authenticate(string username, string password);
        IEnumerable<UserMasters> GetAll();

        Task<bool> UserExist(string username);
        Task<User> Login(string username, string password);
        void Register(string username, byte[] passwordHash, byte[] passwordSalt);

        IEnumerable<User> GetAllUsers();
        User GetUserById(int userId);
        bool IsExist(int userId);
        void Update(User user);
    }
}
