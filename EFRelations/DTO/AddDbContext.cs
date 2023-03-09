using EFRelations.DTO.ManyToMany;
using EFRelations.DTO.OneToMany;
using EFRelations.DTO.OneToOne;
using Microsoft.EntityFrameworkCore;

namespace EFRelations.DTO
{
    public class AddDbContext : DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options) :base(options)
        {

        }

        public DbSet<Student> Student { get; set; }
        public DbSet<StudentAddress> StudentAddress { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Genre> Genre { get; set; }
    }
}
