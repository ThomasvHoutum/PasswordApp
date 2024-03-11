namespace Domain.Models
{
    public class MasterPassword
    {
        public int Id { get; set; }
        
        public int UserId { get; set; }
        
        public string Password { get; set; }
    }
}