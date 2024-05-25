using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Modals
{

    public readonly record struct ResidenceId(Guid Value)
    {
        public static ResidenceId Empty => new(Guid.Empty);
        public static ResidenceId NewResidenceId() => new(Guid.NewGuid());
        public static ResidenceId ParseResidenceId(string id) => new(Guid.Parse(id));
    }
    public class Residence
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public ResidenceId Id { get; set; } = ResidenceId.Empty;
        [Display(Name = "Resident")]
        public UserId ResidentId { get; set; } = UserId.Empty;
        [ForeignKey("ResidentId")]
        public virtual User? Resident { get; set; }
        public LivingArrangement LivingArrangement { get; set; }
        public Uri? LeaseUrl { get; set; }
        [MaxLength(300)]
        public string Address { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public VerificationStatus ResidenceVerificationStatus { get; set; }
        public DateTime CreateTimestamp { get; set; } = DateTime.Now;
        public DateTime UpdatedTimestamp { get; set; } = DateTime.Now;
        public bool? IsAccredited { get; set; }
        [MaxLength(300)]
        public string? LandLordName { get; set; }
        [MaxLength(30)]
        public string? LandLordPhone { get; set; }
        [MaxLength(150)]
        [EmailAddress]
        public string? LandLordEmail { get; set; }
        public DateTime EndTimestamp { get; set; } = DateTime.UtcNow;
        public DateTime StartTimestamp { get; set; } = DateTime.UtcNow;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalCost { get; set; }
    }
}
