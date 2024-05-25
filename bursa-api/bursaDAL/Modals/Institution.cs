using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bursaDAL.Modals
{
    public readonly record struct InstitutionId(Guid Value)
    {
        public static InstitutionId Empty => new(Guid.Empty);
        public static InstitutionId NewInstitutionId() => new(Guid.NewGuid());
        public static InstitutionId ParseInstitutionId(string id) => new(Guid.Parse(id));
    }
    public class Institution
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public InstitutionId Id { get; set; } = InstitutionId.Empty;
        [MaxLength(300)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(2000)]
        public string Description { get; set; } = string.Empty;
        [MaxLength(500)]
        public string? Image { get; set; }
        public DateTime CreateTimestamp { get; set; } = DateTime.Now;

        public DateTime UpdatedTimestamp { get; set; } = DateTime.Now;
        [MaxLength(30)]
        public string? PhoneContactDetails { get; set; }
        [MaxLength(150)]
        [EmailAddress]
        public string? EmailContactDetails { get; set; }
    }
}
