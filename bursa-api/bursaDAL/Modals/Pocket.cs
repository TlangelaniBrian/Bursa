using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Modals
{
    public readonly record struct PocketId(Guid Value)
    {
        public static PocketId Empty => new(Guid.Empty);
        public static PocketId NewPocketId() => new(Guid.NewGuid());
        public static PocketId ParsePocketId(string id) => new(Guid.Parse(id));
    }
    public class Pocket
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public PocketId Id { get; set; } = PocketId.Empty;
        [MaxLength(300)]
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        [Display(Name = "Beneficiary")]
        public UserId BeneficiaryId { get; set; }
        [ForeignKey("BeneficiaryId")]
        public virtual User? Beneficiary { get; set; }
        public LivingArrangement LivingArrangement { get; set; }
        public DateTime CreateTimestamp { get; set; } = DateTime.Now;
        public DateTime UpdateTimestamp { get; set; } = DateTime.Now;
        public virtual ICollection<Allowance> Allowances { get; set; } = [];
    }
}
