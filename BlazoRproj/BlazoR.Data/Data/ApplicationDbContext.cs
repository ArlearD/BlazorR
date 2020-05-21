using BlazoR.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazoR.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        {
        }


        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Post>()
                .HasMany(c => c.Comments)
                .WithOne(p => p.Post)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Comment>()
                .HasOne(p => p.Post)
                .WithMany(c => c.Comments);
            base.OnModelCreating(builder);
        }
    }
}
