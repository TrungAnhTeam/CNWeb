namespace MTATOEIc.Models.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DATABASE : DbContext
    {
        public DATABASE()
            : base("name=Model12")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<ProfileTA> ProfileTAs { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TypeTA> TypeTAs { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasOptional(e => e.ProfileTA)
                .WithRequired(e => e.Account);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Questions)
                .WithOptional(e => e.Account)
                .HasForeignKey(e => e.Username_FK);

            modelBuilder.Entity<ProfileTA>()
                .Property(e => e.Pro_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ProfileTA>()
                .Property(e => e.Pro_Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.Username_FK)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.Role_iD_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypeTA>()
                .HasMany(e => e.Units)
                .WithRequired(e => e.TypeTA)
                .HasForeignKey(e => e.TypeTA_ID_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Unit>()
                .Property(e => e.link)
                .IsUnicode(false);

            modelBuilder.Entity<Unit>()
                .HasMany(e => e.Questions)
                .WithOptional(e => e.Unit)
                .HasForeignKey(e => e.Unit_ID_FK);
        }
    }
}
