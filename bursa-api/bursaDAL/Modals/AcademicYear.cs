using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static bursaDAL.Classes.Constants;

namespace bursaDAL.Modals
{
    public readonly record struct AcademicYearId(Guid Value)
    {
        public static AcademicYearId Empty => new(Guid.Empty);
        public static AcademicYearId NewAcademicYearId() => new(Guid.NewGuid());
        public static AcademicYearId ParseAcademicYearId(string id) => new(Guid.Parse(id));
    }
    public class AcademicYear
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public AcademicYearId Id { get; set; } = AcademicYearId.Empty;
        public AcademicPeriod Period { get; set; }
        public int Year { get; set; }
        [Display(Name = "Institution")]
        public InstitutionId InstitutionId { get; set; }
        [ForeignKey("InstitutionId")]
        public virtual Institution? Institution { get; set; }
        public DateTime CreatedTimestamp { get; set; } = DateTime.Now;
    }
}
