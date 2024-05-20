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
        public RoleId Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public virtual ICollection<Feature> Features { get; set; } = [];
    }
}
