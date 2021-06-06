using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EAD.Server.Models
{
    public partial class job_portalContext : DbContext
    {
        public job_portalContext()
        {
        }

        public job_portalContext(DbContextOptions<job_portalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobApplication> JobApplications { get; set; }
        public virtual DbSet<JobResume> JobResumes { get; set; }
        public virtual DbSet<Seeker> Seekers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=job_portal;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.AddressId).HasColumnName("Address_id");

                entity.Property(e => e.City)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Country)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.HouseNo).HasColumnName("house_no");

                entity.Property(e => e.StreetNo).HasColumnName("street_no");

                entity.Property(e => e.Town)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("town");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("company");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("company_name");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__company__user_id__34C8D9D1");
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.ToTable("Education");

                entity.Property(e => e.EducationId).HasColumnName("Education_id");

                entity.Property(e => e.JobResumeId).HasColumnName("Job_Resume_id");

                entity.Property(e => e.Qualification)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.JobResume)
                    .WithMany(p => p.Educations)
                    .HasForeignKey(d => d.JobResumeId)
                    .HasConstraintName("FK__Education__Job_R__2A4B4B5E");
            });

            modelBuilder.Entity<Experience>(entity =>
            {
                entity.ToTable("Experience");

                entity.Property(e => e.ExperienceId).HasColumnName("Experience_id");

                entity.Property(e => e.Descriptions)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.JobResumeId).HasColumnName("Job_Resume_id");

                entity.HasOne(d => d.JobResume)
                    .WithMany(p => p.Experiences)
                    .HasForeignKey(d => d.JobResumeId)
                    .HasConstraintName("FK__Experienc__Job_R__2D27B809");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job");

                entity.Property(e => e.JobId).HasColumnName("Job_id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.JobDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Job_Desc");

                entity.Property(e => e.JobTilte)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Job_tilte");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK__Job__company_id__37A5467C");
            });

            modelBuilder.Entity<JobApplication>(entity =>
            {
                entity.ToTable("Job_Application");

                entity.Property(e => e.JobApplicationId).HasColumnName("Job_Application_id");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_time");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.SeekerId).HasColumnName("seeker_id");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobApplications)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK__Job_Appli__job_i__3B75D760");

                entity.HasOne(d => d.Seeker)
                    .WithMany(p => p.JobApplications)
                    .HasForeignKey(d => d.SeekerId)
                    .HasConstraintName("FK__Job_Appli__seeke__3A81B327");
            });

            modelBuilder.Entity<JobResume>(entity =>
            {
                entity.ToTable("Job_Resume");

                entity.Property(e => e.JobResumeId).HasColumnName("Job_Resume_id");
            });

            modelBuilder.Entity<Seeker>(entity =>
            {
                entity.ToTable("seeker");

                entity.Property(e => e.SeekerId).HasColumnName("seeker_id");

                entity.Property(e => e.AddressId).HasColumnName("Address_id");

                entity.Property(e => e.FatherName)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("father_name");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.JobResumeId).HasColumnName("Job_Resume_id");

                entity.Property(e => e.LastName)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Seekers)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK__seeker__Address___30F848ED");

                entity.HasOne(d => d.JobResume)
                    .WithMany(p => p.Seekers)
                    .HasForeignKey(d => d.JobResumeId)
                    .HasConstraintName("FK__seeker__Job_Resu__31EC6D26");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Seekers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__seeker__user_id__300424B4");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.UserName, "UQ__users__7C9273C4619C3B2E")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("user_name");

                entity.Property(e => e.UserPass)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("user_pass");

                entity.Property(e => e.UserType).HasColumnName("user_type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
