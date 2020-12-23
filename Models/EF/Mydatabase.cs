namespace Models.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Mydatabase : DbContext
    {
        public Mydatabase()
            : base("name=Mydatabase")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<LevelTA> LevelTAs { get; set; }
        public virtual DbSet<ProfileTA> ProfileTAs { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Suggest> Suggests { get; set; }
        public virtual DbSet<TypeTA> TypeTAs { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Pass)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Questions)
                .WithOptional(e => e.Account)
                .HasForeignKey(e => e.Username_FK);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Units)
                .WithOptional(e => e.Account)
                .HasForeignKey(e => e.Account_ID_FK);

            modelBuilder.Entity<Lesson>()
                .HasMany(e => e.Questions)
                .WithOptional(e => e.Lesson)
                .HasForeignKey(e => e.Lesson_ID_FK);

            modelBuilder.Entity<Lesson>()
                .HasMany(e => e.Units)
                .WithOptional(e => e.Lesson)
                .HasForeignKey(e => e.Lesson_ID_FK);

            modelBuilder.Entity<LevelTA>()
                .HasMany(e => e.Lessons)
                .WithOptional(e => e.LevelTA)
                .HasForeignKey(e => e.Level_ID_FK);

            modelBuilder.Entity<ProfileTA>()
                .Property(e => e.Pro_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ProfileTA>()
                .Property(e => e.Pro_Phone)
                .IsUnicode(false);

            modelBuilder.Entity<ProfileTA>()
                .Property(e => e.Pro_website)
                .IsUnicode(false);

            modelBuilder.Entity<ProfileTA>()
                .Property(e => e.Pro_Fax)
                .IsUnicode(false);

            modelBuilder.Entity<ProfileTA>()
                .HasOptional(e => e.Account)
                .WithRequired(e => e.ProfileTA);

            modelBuilder.Entity<Question>()
                .Property(e => e.Username_FK)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.Suggests)
                .WithOptional(e => e.Question)
                .HasForeignKey(e => e.Ques_ID_FK);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.Role_ID_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypeTA>()
                .HasMany(e => e.Questions)
                .WithOptional(e => e.TypeTA)
                .HasForeignKey(e => e.Type_ID_FK);

            modelBuilder.Entity<Unit>()
                .Property(e => e.Account_ID_FK)
                .IsUnicode(false);
        }
    }
}
