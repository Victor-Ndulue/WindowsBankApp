using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class User:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set;}
        [DataType(DataType.PhoneNumber)] 
        public string PhoneNumber { get; set;}
        [DataType(DataType.Password)] 
        public string Password { get; set;}
        public IEnumerable<Account> Accounts { get; set; }
    }
}
