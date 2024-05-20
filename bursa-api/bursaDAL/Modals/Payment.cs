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
        public PaymentId Id { get; set; }
        public int NumberOfPeriodPaid { get; set; } 
        public UserId BeneficiaryId { get; set; }
        public UserId PaymentMadeById { get; set; }
        public AllowanceId PaymentTypeId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }
        public string? PaymentDescription { get; set; }
        public PaymentStatusCode PaymentStatus { get; set; }
        public DateTime CreateTimestamp { get; set; }
        public DateTime UpdatedTimestamp { get; set; }
        public DateTime PaymentTimestamp { get; set; }
        [Display(Name = "Pocket")]
        public PocketId PocketId { get; set; }
        [ForeignKey("PocketId")]
        public virtual Pocket? Pocket { get; set; }
        [Display(Name = "Allowance")]
        public AllowanceId AllowanceId { get; set; }
        [ForeignKey("AllowanceId")]
        public virtual Allowance? Allowance { get; set; }
    }
}
