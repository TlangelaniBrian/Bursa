using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bursaDAL.Modals
{
    public readonly record struct BursaryOfficerId(Guid Value)
    {
        public static BursaryOfficerId Empty => new(Guid.Empty);
        public static BursaryOfficerId NewBursaryOfficerId() => new(Guid.NewGuid());
        public static BursaryOfficerId ParseBursaryOfficerId(string id) => new(Guid.Parse(id));
    }
    public class BursaryOfficer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public BursaryOfficerId Id { get; set; } = BursaryOfficerId.Empty;
        public BursaryId BursaryId { get; set; } = BursaryId.Empty;
        public virtual Bursary? Bursary { get; set; }
        [Display(Name = "Officer")]
        public UserId OfficerId { get; set; } = UserId.Empty;
        [ForeignKey("OfficerId")]
        public virtual User? Officer { get; set; }
        public DateTime CreateTimestamp { get; set; } = DateTime.Now;
    }
}
