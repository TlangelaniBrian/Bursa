using System.ComponentModel.DataAnnotations;
using static bursaDAL.Classes.Constants;
using System.ComponentModel.DataAnnotations.Schema;

namespace bursaDAL.Modals
{
    
    public readonly record struct BursaryId(Guid Value)
    {
        public static BursaryId Empty => new(Guid.Empty);
        public static BursaryId NewBursaryID() => new(Guid.NewGuid());
        public static BursaryId ParseBursaryId(string id) => new(Guid.Parse(id));
    }
    public class Bursary
    {
        [Key]
        public BursaryId Id { get; set; } = BursaryId.Empty;
        public BursaryType Type { get; set; }
        public VarificationStatus StatusCode { get; set; }
        public string? Notes { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public string? Image { get; set; }
        public DateTime CreateTimestamp { get; set; }
        public UserId UpdatedBy { get; set; } = UserId.Empty;
        public DateTime UpdatedTimestamp { get; set; }
        public bool IsActive { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalAmount { get; set; }

        [Display(Name = "FinancingInstitution")]
        public FinancingInstitutionId FinancingInstitutionId { get; set; } = FinancingInstitutionId.Empty;
        [ForeignKey("FinancingInstitutionId")]
        public virtual FinancingInstitution? FinancingInstitution { get; set; }
    }
}
