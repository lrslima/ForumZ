using ForumZ.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ForumZ.Infraestructure.Context
{
    public class MyDbContext : IdentityDbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<Answers> Answers { get; set; }

        public DbSet<Topic> Topic { get; set; }

        protected override void OnModelCreating(ModelBuilder moodelbuilder)
        {
            moodelbuilder.Entity<Topic>().HasOne(x => x.CreatedBy);
            moodelbuilder.Entity<Topic>().HasOne(x => x.ClosedBy);
            moodelbuilder.Entity<Users>().HasMany(x => x.Topics);

        }

    }
}
