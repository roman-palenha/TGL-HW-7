namespace RelationshipApi.Database.OneToOne
{
    public class Test
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
    }
}
