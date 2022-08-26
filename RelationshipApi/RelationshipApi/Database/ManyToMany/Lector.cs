namespace RelationshipApi.Database.ManyToMany
{
    public class Lector
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}
