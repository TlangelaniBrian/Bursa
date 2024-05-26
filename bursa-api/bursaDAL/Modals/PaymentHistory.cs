using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Modals
{
    public readonly record struct PaymentHistoryId(Guid Value)
    {
        public static PaymentHistoryId Empty => new(Guid.Empty);
        public static PaymentHistoryId NewPaymentHistoryId() => new(Guid.NewGuid());
        public static PaymentHistoryId ParsePaymentHistoryId(string id) => new(Guid.Parse(id));
    }
    public class PaymentHistory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public PaymentHistoryId Id { get; set; } = PaymentHistoryId.Empty;

        [Display(Name = "Beneficiary")]
        [MaxLength(300)]
        public required string BeneficiaryIdNumber { get; set; }

        [Display(Name = "PaymentOfficer")]
        [MaxLength(300)]
        public string? OfficerPersonnelId { get; set; }

        public AllowanceId AllowanceId { get; set; } = AllowanceId.Empty;
        [ForeignKey("AllowanceId")]
        public virtual Allowance? Allowance { get; set; }
        public PaymentStatusCode PaymentStatus { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PaymentAmount { get; set; }
        [MaxLength(300)]
        public string? PaymentRef { get; set; }
        [MaxLength(2000)]
        public string? PaymentDescription { get; set; }

        public DateTime PaymentTimestamp { get; set; } = DateTime.Now;
    }
}
