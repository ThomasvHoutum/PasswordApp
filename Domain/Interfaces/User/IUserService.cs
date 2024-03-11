using System.Collections.Generic;

namespace Domain.Interfaces.User
{
    public interface IUserService
    {
        public Models.User GetUser(int id);

        public List<Models.User> GetAllUsers();
    }
}