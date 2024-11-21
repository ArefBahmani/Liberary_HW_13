using Liberary_HW_13.Configs;
using Liberary_HW_13.Entityes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberary_HW_13
{
    public class AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.Configuration.ConnectionString);
            base.OnConfiguring(optionsBuilder);
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(new Book { Id = 1, Titel = "C#", Writer = "Aref", Discription = "Hichi", DateTime = DateTime.Now, Pages = 1000 });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 2, Titel = "SQL", Writer = "hosein", Discription = "100 Hours Tutaial", DateTime = DateTime.Now, Pages = 100 });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 3, Titel = "Java", Writer = "javad", Discription = "salam halet khobe>?", DateTime = DateTime.Now, Pages = 2000 });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 4, Titel = "Django", Writer = "saeid", Discription = "Mamnon merc", DateTime = DateTime.Now, Pages = 1250 });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 5, Titel = "Java_Script", Writer = "masoud", Discription = "Chekhabara?", DateTime = DateTime.Now, Pages = 444 });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 6, Titel = "C++", Writer = "rasool", Discription = "Salamati to khobi?", DateTime = DateTime.Now, Pages = 10 });
            modelBuilder.ApplyConfiguration(new UserConfigs());
            modelBuilder.ApplyConfiguration(new BookConfigs());

           
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
