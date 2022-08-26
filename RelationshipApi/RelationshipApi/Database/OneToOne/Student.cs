namespace RelationshipApi.Database.OneToOne
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Test Test { get; set; }
    }
}
