using Microsoft.EntityFrameworkCore;
using RelationshipApi.Database.ManyToMany;
using RelationshipApi.Database.OneToOne;

namespace RelationshipApi.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        DbSet<Student> Students { get; set; }
        DbSet<Test> Tests { get; set; }
        DbSet<Author> Authors { get; set; }
        DbSet<Book> Books { get; set; }
        DbSet<Lector> Lectors { get; set; }
        DbSet<Group> Groups { get; set; }
    }
}
