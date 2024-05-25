using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bursaDAL.Modals
{
    public readonly record struct ActivityLogId(Guid Value)
    {
        public static ActivityLogId Empty => new(Guid.Empty);
        public static ActivityLogId NewAcademicYearId() => new(Guid.NewGuid());
        public static ActivityLogId ParseAcademicYearId(string id) => new(Guid.Parse(id));
    }
    public class ActivityLog
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public ActivityLogId Id { get; set; } = ActivityLogId.Empty;
        [MaxLength(1000)]
        public string? Activity { get; set; }
        public DateTime CreatedTimestamp { get; set; } = DateTime.Now;
        [Display(Name = "UpdatedBy")]
        public UserId UserId { get; set; } = UserId.Empty;
        [ForeignKey("UserId")]
        public virtual User? UpdatedBy { get; set; }
    }
}
