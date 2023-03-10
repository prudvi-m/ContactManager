using Microsoft.EntityFrameworkCore;

namespace ContactManager.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                 new Category { CategoryId = 1, Name = "Family" },
                 new Category { CategoryId = 2, Name = "Friend" },
                 new Category { CategoryId = 3, Name = "Work" },
                 new Category { CategoryId = 4, Name = "Other" }
             );

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    FirstName = "Delores",
                    LastName = "Del RIo",
                    Phone = "555-987-6543",
                    Email = "delores@hotmail.com",
                    CategoryId = 2
                },
                new Contact
                {
                    ContactId = 2,
                    FirstName = "Efren",
                    LastName = "Herrera",
                    Phone = "555-456-7890",
                    Email = "efren@hotmail.com",
                    CategoryId = 3
                },
                new Contact
                {
                    ContactId = 3,
                    FirstName = "Jun",
                    LastName = "Zuo",
                    Phone = "7085344539",
                    Email = "jzuo.govst.edu",
                    CategoryId = 3
                },
                new Contact
                {
                    ContactId = 4,
                    FirstName = "Mary Ellen",
                    LastName = "Walton",
                    Phone = "555-123-4567",
                    Email = "maryellen@yahoo.com",
                    CategoryId = 1
                }
            );
        }
    }
}
