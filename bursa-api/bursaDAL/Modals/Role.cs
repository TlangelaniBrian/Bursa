using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bursaDAL.Modals
{
    public readonly record struct RoleId(Guid Value)
    {
        public static RoleId Empty => new(Guid.Empty);
        public static RoleId NewRoleId() => new(Guid.NewGuid());
        public static RoleId ParseRoleId(string id) => new(Guid.Parse(id));
    }
    public class Role
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public RoleId Id { get; set; }

        [MaxLength(100)]
        public required string Name { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; } = string.Empty;
        public virtual ICollection<Feature> Features { get; set; } = [];
    }
}
