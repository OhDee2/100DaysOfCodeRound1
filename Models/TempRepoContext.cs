using Microsoft.EntityFrameworkCore;
namespace KingdomOfRelationships.Models
{
    public class TempRepoContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Relationship> Relationships { get; set; }
        public DbSet<CharacterRelationships> CharacterRelationship { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS01;Database=master;Trusted_Connection=True;");
        }
    }
}