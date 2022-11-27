using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BusinessObject.Models;

public partial class PeTestContext : DbContext
{
    public PeTestContext()
    {
    }

    public PeTestContext(DbContextOptions<PeTestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CandidateProfile> CandidateProfiles { get; set; }

    public virtual DbSet<Hraccount> Hraccounts { get; set; }

    public virtual DbSet<JobPosting> JobPostings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server =(local); database = PE_TEST;uid=sa;pwd=123; Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CandidateProfile>(entity =>
        {
            entity.HasKey(e => e.CandidateId);

            entity.ToTable("CandidateProfile");

            entity.Property(e => e.CandidateId).HasColumnName("CandidateID");
            entity.Property(e => e.Birthday).HasColumnType("date");
            entity.Property(e => e.Fullname)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.PostingId).HasColumnName("PostingID");
            entity.Property(e => e.ProfileShortDescription).HasMaxLength(50);
            entity.Property(e => e.ProfileUrl)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("ProfileURL");

            entity.HasOne(d => d.Posting).WithMany(p => p.CandidateProfiles)
                .HasForeignKey(d => d.PostingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CandidateProfile_JobPosting");
        });

        modelBuilder.Entity<Hraccount>(entity =>
        {
            entity.HasKey(e => e.Email);

            entity.ToTable("HRAccount");

            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.MemberRole)
                .IsRequired()
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(30)
                .IsFixedLength();
        });

        modelBuilder.Entity<JobPosting>(entity =>
        {
            entity.HasKey(e => e.PostingId);

            entity.ToTable("JobPosting");

            entity.Property(e => e.PostingId).HasColumnName("PostingID");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.JobPostingTitle)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.PostedDate).HasColumnType("date");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
