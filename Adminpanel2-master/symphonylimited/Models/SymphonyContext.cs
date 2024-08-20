using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace symphonylimited.Models;

public partial class SymphonyContext : DbContext
{
    public SymphonyContext()
    {
    }

    public SymphonyContext(DbContextOptions<SymphonyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<About> Abouts { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<EntranceStudent> EntranceStudents { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<Fee> Fees { get; set; }

    public virtual DbSet<RegisteredStudent> RegisteredStudents { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=symphony;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<About>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("about");

            entity.Property(e => e.Discription).HasColumnName("discription");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.Title).HasColumnName("title");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("contact");

            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.BranchDetails).HasColumnName("branch_details");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Image).HasColumnName("image");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("courses");

            entity.Property(e => e.Discription).HasColumnName("discription");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.Fees)
                .HasMaxLength(50)
                .HasColumnName("fees");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.Title).HasColumnName("title");
        });

        modelBuilder.Entity<EntranceStudent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("entrance_students");

            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.PhoneNo).HasColumnName("phone_no");
            entity.Property(e => e.Result)
                .HasMaxLength(50)
                .HasColumnName("result");
            entity.Property(e => e.RollNo).HasColumnName("roll_no");
        });

        modelBuilder.Entity<Exam>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("exam");

            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.ExamId).HasColumnName("exam_id");
            entity.Property(e => e.ResultDate)
                .HasColumnType("date")
                .HasColumnName("result_date");
            entity.Property(e => e.Time).HasColumnName("time");
            entity.Property(e => e.Venue)
                .HasMaxLength(50)
                .HasColumnName("venue");
        });

        modelBuilder.Entity<Fee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fees");

            entity.Property(e => e.CourseId).HasColumnName("course_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.StdId).HasColumnName("std_id");
        });

        modelBuilder.Entity<RegisteredStudent>(entity =>
        {
            entity.ToTable("registered_students");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.CourseId).HasColumnName("course_id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FeeStatus)
                .HasMaxLength(50)
                .HasColumnName("fee_status");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.PhoneNo).HasColumnName("phone_no");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC0729578D34");

            entity.ToTable("users");

            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Username).HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
