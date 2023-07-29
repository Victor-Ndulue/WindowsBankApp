using System.ComponentModel.DataAnnotations;

namespace Models
{
    public abstract class BaseEntity
    {
        [Key]
        public byte Id { get; set; }
        public string CreatedBy { get; set; } 
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow.Date;
        public string ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }
    }
}