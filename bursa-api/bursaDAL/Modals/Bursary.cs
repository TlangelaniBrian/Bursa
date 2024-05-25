using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Modals
{

    public readonly record struct BursaryId(Guid Value)
    {
        public static BursaryId Empty => new(Guid.Empty);
        public static BursaryId NewBursaryId() => new(Guid.NewGuid());
        public static BursaryId ParseBursaryId(string id) => new(Guid.Parse(id));
    }
    public class Bursary
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public BursaryId Id { get; set; } = BursaryId.Empty;
        public BursaryType Type { get; set; }
        public VerificationStatus StatusCode { get; set; }

        [MaxLength(2000)] 
        public string? Notes { get; set; } = string.Empty;

        [MaxLength(300)]
        public required string Name { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Image { get; set; }
        public DateTime CreateTimestamp { get; set; } = DateTime.Now;

        public DateTime UpdatedTimestamp { get; set; } = DateTime.Now;
        public bool IsActive { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalAmount { get; set; }

        [Display(Name = "FinancingInstitution")]
        public FinancingInstitutionId FinancingInstitutionId { get; set; } = FinancingInstitutionId.Empty;
        [ForeignKey("FinancingInstitutionId")]
        public virtual FinancingInstitution? FinancingInstitution { get; set; }
    }
}
