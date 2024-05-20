using System.ComponentModel.DataAnnotations.Schema;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Modals
{
    public readonly record struct PaymentHistroyId(Guid Value)
    {
        public static PaymentHistroyId Empty => new(Guid.Empty);
        public static PaymentHistroyId NewPaymentHistroyId() => new(Guid.NewGuid());
        public static PaymentHistroyId ParsePaymentHistroyId(string id) => new(Guid.Parse(id));
    }
    public class PaymentHistroy
    {
        public PaymentHistroyId Id { get; set; } = PaymentHistroyId.Empty;
        public UserId UserId { get; set; } = UserId.Empty;
        public string? PaymentRef { get; set; }
        public AllowanceId AllowanceId { get; set; }
        [ForeignKey("AllowanceId")]
        public virtual Allowance? Allowance { get; set; }
        public PaymentStatusCode PaymentStatus { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PaymentAmount { get; set; }
        public string? PaymentDescription { get; set; }
        public string? PaymentTimestamp { get; set; }
        public string? PaymentMadeBy { get; set; }
    }
}
