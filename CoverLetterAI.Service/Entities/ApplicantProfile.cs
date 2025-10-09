using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoverLetterAI.Service.Entities
{
    [Table("ApplicantProfile")]
    public class ApplicantProfile
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string FullAddress { get; set; } = string.Empty;
        public string Profession { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string MyBackground { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int UserId { get; set; }
    }
}
