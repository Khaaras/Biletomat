using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test.Models
{
    internal class DataBaseContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Match> Match { get; set; }
        public DbSet<Tickets> Tickets { get; set; }

        public DbSet<UserTickets> UserTickets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Tickets>()
                .HasRequired(c => c.Match)
                .WithMany()
                .HasForeignKey(x => x.MatchId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Tickets>()
                .HasRequired(c => c.User)
                .WithMany()
                .HasForeignKey(t => t.UserId);

            modelBuilder.Entity<Tickets>()
                .Property(x => x.FullName)
                .IsRequired();

            modelBuilder.Entity<UserTickets>()
                .HasRequired(c => c.User)
                .WithMany()
                .HasForeignKey(t => t.UserId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<UserTickets>()
                .HasRequired(c => c.Match)
                .WithMany()
                .HasForeignKey(t => t.MatchId)
                .WillCascadeOnDelete(true);

            base.OnModelCreating(modelBuilder);               
                
                
        }

    }


}
