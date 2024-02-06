using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApp2CoreFeb6.Model
{
    public partial class CompanyContext : DbContext
    {
        public CompanyContext()
        {
        }

        public CompanyContext(DbContextOptions<CompanyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bank> Banks { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<Ddd> Ddds { get; set; } = null!;
        public virtual DbSet<Detail> Details { get; set; } = null!;
        public virtual DbSet<Emp> Emps { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<LogInCdt> LogInCdts { get; set; } = null!;
        public virtual DbSet<MyProduct> MyProducts { get; set; } = null!;
        public virtual DbSet<MyView> MyViews { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-B13B310\\SQLEXPRESS;database=Company;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bank>(entity =>
            {
                entity.HasKey(e => e.AccountNumber)
                    .HasName("PK__Bank__BE2ACD6E5FC517E9");

                entity.ToTable("Bank");

                entity.Property(e => e.AccountNumber).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AadharNo)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.PhoneNumberNavigation)
                    .WithMany(p => p.Banks)
                    .HasForeignKey(d => d.PhoneNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bank__PhoneNumbe__756D6ECB");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.Bid)
                    .HasName("PK__Books__C6D111C9D53E9D65");

                entity.Property(e => e.Bid).ValueGeneratedNever();

                entity.Property(e => e.Author)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Bname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BName");

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("class");

                entity.Property(e => e.ClassId).ValueGeneratedNever();

                entity.Property(e => e.ClassName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ddd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DDd");

                entity.Property(e => e.Addre)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("addre");

                entity.Property(e => e.Desg)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("desg");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Sal).HasColumnName("sal");
            });

            modelBuilder.Entity<Detail>(entity =>
            {
                entity.HasKey(e => e.Eno)
                    .HasName("PK__Details__C190FF898093E1A7");

                entity.Property(e => e.Eno)
                    .ValueGeneratedNever()
                    .HasColumnName("ENo");

                entity.Property(e => e.Elocation)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.JoingDate)
                    .HasColumnType("date")
                    .HasColumnName("joingDate");

                entity.HasOne(d => d.EidNavigation)
                    .WithMany(p => p.Details)
                    .HasForeignKey(d => d.Eid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Details__Eid__5FB337D6");
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("emp");

                entity.Property(e => e.Ename)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ename")
                    .IsFixedLength();

                entity.Property(e => e.Eno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("eno")
                    .IsFixedLength();

                entity.Property(e => e.Hno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("hno")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__Employee__C1971B53A126D8DB");

                entity.ToTable("Employee");

                entity.Property(e => e.Eid).ValueGeneratedNever();

                entity.Property(e => e.Desgnation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Eadd)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Eage).HasColumnName("EAge");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EName");

                entity.Property(e => e.Esal).HasColumnName("ESal");
            });

            modelBuilder.Entity<LogInCdt>(entity =>
            {
                entity.HasKey(e => e.PhoneNumber)
                    .HasName("PK__LogInCdt__85FB4E3996FAC6B6");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMailID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Passwordd)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MyProduct>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__MyProduc__C57059383F78907F");

                entity.ToTable("MyProduct");

                entity.Property(e => e.Pid).ValueGeneratedNever();

                entity.Property(e => e.Ped)
                    .HasColumnType("date")
                    .HasColumnName("PEd");

                entity.Property(e => e.Pmd)
                    .HasColumnType("date")
                    .HasColumnName("PMd");

                entity.Property(e => e.Pname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PName");
            });

            modelBuilder.Entity<MyView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("My_View");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EName");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Product__C5705938D4109CF6");

                entity.ToTable("Product");

                entity.Property(e => e.Pid).ValueGeneratedNever();

                entity.Property(e => e.Pmfd).HasColumnType("date");

                entity.Property(e => e.Pname)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StdId)
                    .HasName("PK__Students__55DCAE1FF3E7A127");

                entity.Property(e => e.StdId).ValueGeneratedNever();

                entity.Property(e => e.ClassId).HasColumnName("classId");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__Students__classI__531856C7");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasKey(e => e.SubId)
                    .HasName("PK__Subjects__4D9BB84A63E8D583");

                entity.Property(e => e.SubId).ValueGeneratedNever();

                entity.Property(e => e.SubName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
