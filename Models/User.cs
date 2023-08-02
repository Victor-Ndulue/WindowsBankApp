using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class User:BaseEntity
    {
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public byte[] PasswordSalt { get; set;}
        public byte[] PasswordHash { get; set;}
        public IEnumerable<Account> Accounts { get; set; }
    }
}
