using System.Collections.Generic;
using System.IO;
using Domain.Dtos.AddLoginDetail.Save;
using Domain.Helpers;
using Domain.Interfaces.LoginDetails;
using Domain.Models;
using Newtonsoft.Json;

namespace Domain.Services.LoginDetails
{
    public class LoginDetailService : ILoginDetailService
    {
        public List<LoginDetail> GeAllLoginDetails()
        {
            if (!File.Exists(Config.LoginDetailsPath))
                return new List<LoginDetail>();

            var encryptedString = File.ReadAllText(Config.LoginDetailsPath);
            var decryptedString = EncryptionHelper.Decrypt(encryptedString);
            return JsonConvert.DeserializeObject<List<LoginDetail>>(decryptedString);
        }

        public void SaveLoginDetail(SaveLoginDetailDto loginDetailDto)
        {
            var loginDetails = GeAllLoginDetails();
            loginDetails.Add(new LoginDetail
            {
                Username = loginDetailDto.Username,
                Password = loginDetailDto.Password,
                Application = loginDetailDto.Application
            });
            
            var jsonString = JsonConvert.SerializeObject(loginDetails);
            var encryptedString = EncryptionHelper.Encrypt(jsonString);
            File.WriteAllText(Config.LoginDetailsPath, encryptedString);
        }
    }
}