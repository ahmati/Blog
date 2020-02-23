using blog.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace blog.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Post_Category>().HasKey(sc => new { sc.PostId, sc.Category_Id });
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Post_Category> Post_Categories { get; set; }
        
        public  DbSet<Comment> Comments { get; set; }

    }
}
