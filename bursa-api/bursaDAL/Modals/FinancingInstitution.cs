using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Modals
{
    public readonly record struct FinancingInstitutionId(Guid Value)
    {
        public static FinancingInstitutionId Empty => new(Guid.Empty);
        public static FinancingInstitutionId NewFinancingInstitutionId() => new(Guid.NewGuid());
        public static FinancingInstitutionId ParseFinancingInstitutionId(string id) => new(Guid.Parse(id));
    }

    public class FinancingInstitution
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public FinancingInstitutionId Id { get; set; } = FinancingInstitutionId.Empty;

        [MaxLength(300)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(2000)]
        public string Description { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Image { get; set; }
        public InstitutionCategory Category { get; set; }
        public DateTime CreateTimestamp { get; set; } = DateTime.Now;
        public DateTime UpdatedTimestamp { get; set; } = DateTime.Now;
        public virtual ICollection<Bursary> Bursaries { get; set; } = [];
    }
}
