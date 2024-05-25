using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Modals
{
    public readonly record struct PaymentId(Guid Value)
    {
        public static PaymentId Empty => new(Guid.Empty);
        public static PaymentId NewPaymentId() => new(Guid.NewGuid());
        public static PaymentId ParsePaymentId(string id) => new(Guid.Parse(id));
    }

    public class Payment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public PaymentId Id { get; set; }
        public int NumberOfPeriodPaid { get; set; }
        [Display(Name = "Beneficiary")]
        public UserId BeneficiaryId { get; set; } = UserId.Empty;
        [ForeignKey("BeneficiaryId")]
        public virtual User? Beneficiary { get; set; }

        [Display(Name = "PaymentOfficer")]
        public UserId PaymentOfficerId { get; set; } = UserId.Empty;
        [ForeignKey("PaymentOfficerId")]
        public virtual User? PaymentOfficer { get; set; }

        [Display(Name = "PaymentType")]
        public AllowanceId PaymentTypeId { get; set; } = AllowanceId.Empty;
        [ForeignKey("PaymentTypeId")]
        public virtual Allowance? Allowance { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }
        [MaxLength(2000)]
        public string? PaymentDescription { get; set; }
        public PaymentStatusCode PaymentStatus { get; set; }
        public DateTime CreateTimestamp { get; set; } = DateTime.Now;
        public DateTime UpdatedTimestamp { get; set; } = DateTime.Now;
        public DateTime PaymentTimestamp { get; set; }
        [Display(Name = "Pocket")]
        public PocketId PocketId { get; set; }
    }
}
