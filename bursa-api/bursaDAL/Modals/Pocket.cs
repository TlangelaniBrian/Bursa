using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

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
        [Key]
        public PocketId Id { get; set; } = PocketId.Empty;
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        [Display(Name = "Beneficiary")]
        public UserId BeneficiaryId { get; set; }
        [ForeignKey("BeneficiaryId")]
        public virtual User? Beneficiary { get; set; }

        [Display(Name = "Residence")]
        public ResidenceId ResidenceId { get; set; }
        [ForeignKey("ResidenceId")]
        public virtual Residence? Residence { get; set; }
        public virtual ICollection<Bursary> Bursaries { get; set; } = [];
        public virtual ICollection<Allowance> Allowances { get; set; } = [];
    }
}
