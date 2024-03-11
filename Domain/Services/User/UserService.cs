using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Domain.Helpers;
using Domain.Interfaces.User;
using Newtonsoft.Json;

namespace Domain.Services.User
{
    public class UserService : IUserService
    {
        public Models.User GetUser(int id)
        {
            if (!File.Exists(Config.LoginDetailsPath))
                throw new NullReferenceException();

            var encryptedString = File.ReadAllText(Config.LoginDetailsPath);
            var decryptedString = EncryptionHelper.Decrypt(encryptedString);
            
            var allUsers = JsonConvert.DeserializeObject<List<Models.User>>(decryptedString);
            return allUsers.FirstOrDefault(user => user.Id == id);
        }

        public List<Models.User> GetAllUsers()
        {
            if (!File.Exists(Config.LoginDetailsPath))
                return new List<Models.User>();

            var encryptedString = File.ReadAllText(Config.LoginDetailsPath);
            var decryptedString = EncryptionHelper.Decrypt(encryptedString);
            
            return JsonConvert.DeserializeObject<List<Models.User>>(decryptedString);
        }
    }
}