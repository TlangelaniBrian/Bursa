using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bursaDAL.Modals
{
    public readonly record struct AllowanceTypeId(Guid Value)
    {
        public static AllowanceTypeId Empty => new(Guid.Empty);
        public static AllowanceTypeId NewAllowanceTypeId() => new(Guid.NewGuid());
        public static AllowanceTypeId ParseAllowanceTypeId(string id) => new(Guid.Parse(id));
    }
    public class AllowanceType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public AllowanceTypeId Id { get; set; } = AllowanceTypeId.Empty;

        [MaxLength(300)]
        public required string Name { get; set; }
    }
}
