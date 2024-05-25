using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bursaDAL.Modals
{
    public readonly record struct BursaryBeneficiaryId(Guid Value)
    {
        public static BursaryBeneficiaryId Empty => new(Guid.Empty);
        public static BursaryBeneficiaryId NewBursaryBeneficiaryId() => new(Guid.NewGuid());
        public static BursaryBeneficiaryId ParseBursaryBeneficiaryId(string id) => new(Guid.Parse(id));
    }
    public class BursaryBeneficiary
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public BursaryBeneficiaryId Id { get; set; } = BursaryBeneficiaryId.Empty;
        public BursaryId BursaryId { get; set; } = BursaryId.Empty;
        public DateTime CreateTimestamp { get; set; } = DateTime.Now;
        public virtual Bursary? Bursary { get; set; }
        [Display(Name = "Beneficiary")]
        public UserId BeneficiaryId { get; set; } = UserId.Empty;
        [ForeignKey("BeneficiaryId")]
        public virtual User? Beneficiary { get; set; }
    }
}
