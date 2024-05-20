using System.ComponentModel.DataAnnotations;
using static bursaDAL.Classes.Constants;
using System.ComponentModel.DataAnnotations.Schema;

namespace bursaDAL.Modals
{
    public readonly record struct AllowanceId(Guid Value)
    {
        public static AllowanceId Empty => new(Guid.Empty);
        public static AllowanceId NewAllowanceId() => new(Guid.NewGuid());
        public static AllowanceId ParseAllowanceId(string id) => new(Guid.Parse(id));
    }

    public class Allowance
    {
        [Key]
        public AllowanceId Id { get; set; } = AllowanceId.Empty;
        public bool IsActive { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }
        public int TotalNumberPayments { get; set; }
        public int TotalNumberPaymentsMade { get; set; }
        public DateTime StartTimestamp { get; set; }
        public DateTime EndTimestamp { get; set; }
        public string? Name { get; set; }
        public PaymentCycle PaymentCycle { get; set; }
        [Display(Name = "AllowanceType")]
        public AllowanceTypeId AllowanceTypeId { get; set; } = AllowanceTypeId.Empty;
        [ForeignKey("AllowanceTypeId")]
        public virtual AllowanceType? AllowanceType { get; set; }
        [Display(Name = "Bursary")]
        public BursaryId BursaryId { get; set; } = BursaryId.Empty;
        [ForeignKey("BursaryId")]
        public virtual Bursary? Bursary { get; set; }
    }
}
