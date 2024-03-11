using System.Collections.Generic;

namespace Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        
        public List<LoginDetail> LoginDetails { get; set; }
    }
}