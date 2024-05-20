namespace bursaDAL.Modals
{
    public readonly record struct FeatureId(Guid Value)
    {
        public static FeatureId Empty => new(Guid.Empty);
        public static FeatureId NewFeatureId() => new(Guid.NewGuid());
        public static FeatureId ParseFeatureId(string id) => new(Guid.Parse(id));
    }
    public class Feature
    {
        public FeatureId Id { get; set; } = FeatureId.Empty;
        public required string Name { get; set; }
        public required string Access { get; set; }
        public bool IsActive { get; set; }
    }
}
