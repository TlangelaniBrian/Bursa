using static bursaDAL.Classes.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Key]
        public ResidenceId Id { get; set; } = ResidenceId.Empty;
        public UserId UserId { get; set; } = UserId.Empty;
        public UserId UpdatedBy { get; set; } = UserId.Empty;
        public LivingArrangment LivingArrangment { get; set; }
        public Uri? LeaseUrl { get; set; }
        public string Address { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public VarificationStatus ResidenceVarificationStatus { get; set; }
        public DateTime CreateTimestamp { get; set; }
        public DateTime UpdatedTimestamp { get; set; }
        public bool? IsAccredited { get; set; }
        public string? LandLordName { get; set; }
        public string? LandLordPhone { get; set; }
        public string? LandLordEmail { get; set; }
        public DateTime EndTimestamp { get; set; }
        public DateTime StartTimestamp { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalCost { get; set; }


    }
}
