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
        public AllowanceTypeId Id { get; set; } = AllowanceTypeId.Empty;
        public required string Name { get; set; }
    }
}
