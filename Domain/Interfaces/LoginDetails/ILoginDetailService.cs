using System.Collections.Generic;
using Domain.Dtos.AddLoginDetail.Save;
using Domain.Models;

namespace Domain.Interfaces.LoginDetails
{
    public interface ILoginDetailService
    {
        public List<LoginDetail> GeAllLoginDetails();

        public void SaveLoginDetail(SaveLoginDetailDto loginDetailDto);
    }
}