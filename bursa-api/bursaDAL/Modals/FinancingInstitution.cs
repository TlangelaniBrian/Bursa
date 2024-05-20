using System.ComponentModel.DataAnnotations;

namespace bursaDAL.Modals
{
    public readonly record struct FinancingInstitutionId(Guid Value)
    {
        public static FinancingInstitutionId Empty => new(Guid.Empty);
        public static FinancingInstitutionId NewFinancingInstitutionID() => new(Guid.NewGuid());
        public static FinancingInstitutionId ParseFinancingInstitutionId(string id) => new(Guid.Parse(id));
    }

    public class FinancingInstitution
    {
        [Key]
        public FinancingInstitutionId Id { get; set; } = FinancingInstitutionId.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? Image { get; set; }
        public string? Category { get; set; } // ie corp vs family vs government
        public UserId UpdatedBy { get; set; } = UserId.Empty;
        public DateTime CreateTimestamp { get; set; }
        public DateTime UpdatedTimestamp { get; set; }
        public virtual ICollection<Bursary> Bursaries { get; set; } = [];
    }
}
