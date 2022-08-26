namespace RelationshipApi.Database.ManyToMany
{
    public class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Lector> Lectors { get; set; }
    }
}
