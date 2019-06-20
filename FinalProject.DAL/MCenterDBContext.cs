namespace FinalProject.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MCenterDBContext : DbContext
    {
        public MCenterDBContext()
            : base("name=MCenterDBContext")
        {
        }

        public virtual DbSet<attendance> attendances { get; set; }
        public virtual DbSet<course> courses { get; set; }
        public virtual DbSet<courses_category> courses_category { get; set; }
        public virtual DbSet<instructor> instructors { get; set; }
        public virtual DbSet<instructor_phone> instructor_phone { get; set; }
        public virtual DbSet<lab> labs { get; set; }
        public virtual DbSet<news> news { get; set; }
        public virtual DbSet<news_type> news_type { get; set; }
        public virtual DbSet<parenter> parenters { get; set; }
        public virtual DbSet<parenters_phones> parenters_phones { get; set; }
        public virtual DbSet<qualification> qualifications { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<service> services { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<user_course> user_course { get; set; }
        public virtual DbSet<user_data> user_data { get; set; }
        public virtual DbSet<user_phone> user_phone { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<course>()
                .HasMany(e => e.attendances)
                .WithRequired(e => e.course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<course>()
                .HasMany(e => e.user_course)
                .WithRequired(e => e.course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<courses_category>()
                .HasMany(e => e.courses)
                .WithRequired(e => e.courses_category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<instructor>()
                .HasMany(e => e.instructor_phone)
                .WithRequired(e => e.instructor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<instructor>()
                .HasMany(e => e.qualifications)
                .WithMany(e => e.instructors)
                .Map(m => m.ToTable("instructor_qualifications").MapLeftKey("instructor_id").MapRightKey("qualification_id"));

            modelBuilder.Entity<parenter>()
                .HasMany(e => e.parenters_phones)
                .WithRequired(e => e.parenter)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<role>()
                .HasMany(e => e.user_data)
                .WithRequired(e => e.role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<service>()
                .HasMany(e => e.courses)
                .WithRequired(e => e.service)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<service>()
                .HasMany(e => e.labs)
                .WithRequired(e => e.service)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user_data>()
                .HasMany(e => e.attendances)
                .WithRequired(e => e.user_data)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user_data>()
                .HasMany(e => e.user_course)
                .WithRequired(e => e.user_data)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user_data>()
                .HasMany(e => e.user_phone)
                .WithRequired(e => e.user_data)
                .WillCascadeOnDelete(false);
        }
    }
}
