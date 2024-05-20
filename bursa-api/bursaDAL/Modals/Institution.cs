using System.ComponentModel.DataAnnotations;

namespace bursaDAL.Modals
{
    public readonly record struct InstitutionId(Guid Value) {
        public static InstitutionId Empty => new(Guid.Empty);
        public static InstitutionId NewInstitutionId() => new(Guid.NewGuid());
        public static InstitutionId CreateInstitutionId(Guid id) => new(id);
        public static InstitutionId ParseInstitutionId(string id) => new(Guid.Parse(id));
    }
    public class Institution
    {
        [Key]
        public InstitutionId Id { get; set; } = InstitutionId.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? Image { get; set; }
        public DateTime CreateTimestamp { get; set; }
        public UserId UpdatedById { get; set; } = UserId.Empty;
        public DateTime UpdatedTimestamp { get; set; }
        public string? PhoneContactDetails { get; set; }
        public string? EmailContactDetails { get; set; }
    }
}
