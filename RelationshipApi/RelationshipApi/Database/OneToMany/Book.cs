namespace RelationshipApi.Database.OneToOne
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
    }
}
