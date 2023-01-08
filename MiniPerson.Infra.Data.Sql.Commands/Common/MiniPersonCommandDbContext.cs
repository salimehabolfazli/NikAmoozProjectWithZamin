using Microsoft.EntityFrameworkCore;
using MiniPerson.Core.Domain.People.Entities;
using MiniPerson.Core.Domain.People.ValueObjects;
using NewCms.Infra.Data.Sql.Commands.Common;
using Zamin.Extensions.Events.Outbox.Dal.EF;

namespace MiniPerson.Infra.Data.Sql.Commands.Common
{
    public class MiniPersonCommandDbContext : BaseOutboxCommandDbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonProduct> PersonProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public MiniPersonCommandDbContext(DbContextOptions<MiniPersonCommandDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            configurationBuilder.Properties<PhoneNumber>().HaveConversion<PhoneNumberConversion>();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(builder);
        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    // configures one-to-many relationship
        //    modelBuilder.Entity<Person>()
        //        .WithMany(a => a.PhoneNumber)
        //        .HasForeignKey<Guid>(b => b.PersonId);
        //}
    }
}
