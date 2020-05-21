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


        public DbSet<Post> Posts { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Post>().HasKey(i => i.Id);
            base.OnModelCreating(builder);
        }
    }
}
