using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static bursaDAL.Classes.Constants;

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
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public AllowanceId Id { get; set; } = AllowanceId.Empty;
        public bool IsActive { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }
        public int TotalNumberPayments { get; set; }
        public int TotalNumberPaymentsMade { get; set; }
        public DateTime StartTimestamp { get; set; } = DateTime.Now;
        public DateTime EndTimestamp { get; set; }
        [MaxLength(300)]
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
