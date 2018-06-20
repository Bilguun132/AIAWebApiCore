using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AIAWebApiCore.Models
{
    public partial class AIAContext : DbContext
    {
        public AIAContext()
        {
        }

        public AIAContext(DbContextOptions<AIAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agent> Agent { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Policy> Policy { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=nusisemgameserver.database.windows.net,1433;initial catalog=AIA;persist security info=True;user id=isemadmin;password=ISE_Admin@12345;MultipleActiveResultSets=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agent>(entity =>
            {
                entity.ToTable("AGENT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgentId).HasColumnName("AGENT_ID");

                entity.Property(e => e.Email).HasColumnName("EMAIL");

                entity.Property(e => e.FirstName).HasColumnName("FIRST_NAME");

                entity.Property(e => e.LastName).HasColumnName("LAST_NAME");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("CUSTOMER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS_2")
                    .HasMaxLength(255);

                entity.Property(e => e.AgentId).HasColumnName("AGENT_ID");

                entity.Property(e => e.Anniversary)
                    .HasColumnName("ANNIVERSARY")
                    .HasMaxLength(255);

                entity.Property(e => e.BizAddress)
                    .HasColumnName("BIZ_ADDRESS")
                    .HasMaxLength(255);

                entity.Property(e => e.BizCountry)
                    .HasColumnName("BIZ_COUNTRY")
                    .HasMaxLength(255);

                entity.Property(e => e.BizPostalCode)
                    .HasColumnName("BIZ_POSTAL_CODE")
                    .HasMaxLength(255);

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(255);

                entity.Property(e => e.Country1)
                    .HasColumnName("COUNTRY_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Country2)
                    .HasColumnName("COUNTRY_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email1)
                    .HasColumnName("EMAIL_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Email2)
                    .HasColumnName("EMAIL_2")
                    .HasMaxLength(255);

                entity.Property(e => e.FamilyOf)
                    .HasColumnName("FAMILY_OF")
                    .HasMaxLength(255);

                entity.Property(e => e.FaxHome)
                    .HasColumnName("FAX_HOME")
                    .HasMaxLength(255);

                entity.Property(e => e.Gender)
                    .HasColumnName("GENDER")
                    .HasMaxLength(255);

                entity.Property(e => e.Handphone1)
                    .HasColumnName("HANDPHONE_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Handphone2)
                    .HasColumnName("HANDPHONE_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Hobbies)
                    .HasColumnName("HOBBIES")
                    .HasMaxLength(255);

                entity.Property(e => e.HomeTel1)
                    .HasColumnName("HOME_TEL_1")
                    .HasMaxLength(255);

                entity.Property(e => e.HomeTel2)
                    .HasColumnName("HOME_TEL_2")
                    .HasMaxLength(255);

                entity.Property(e => e.IcNumber)
                    .HasColumnName("IC_NUMBER")
                    .HasMaxLength(255);

                entity.Property(e => e.LanguageSpoken)
                    .HasColumnName("LANGUAGE_SPOKEN")
                    .HasMaxLength(255);

                entity.Property(e => e.LastContact)
                    .HasColumnName("LAST_CONTACT")
                    .HasMaxLength(255);

                entity.Property(e => e.MaritalStatus)
                    .HasColumnName("MARITAL_STATUS")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Nationality)
                    .HasColumnName("NATIONALITY")
                    .HasMaxLength(255);

                entity.Property(e => e.Occupation)
                    .HasColumnName("OCCUPATION")
                    .HasMaxLength(255);

                entity.Property(e => e.OfficeDid)
                    .HasColumnName("OFFICE_DID")
                    .HasMaxLength(255);

                entity.Property(e => e.OfficeFax)
                    .HasColumnName("OFFICE_FAX")
                    .HasMaxLength(255);

                entity.Property(e => e.OfficeTel)
                    .HasColumnName("OFFICE_TEL")
                    .HasMaxLength(255);

                entity.Property(e => e.OtherSource)
                    .HasColumnName("OTHER_SOURCE")
                    .HasMaxLength(255);

                entity.Property(e => e.Pager)
                    .HasColumnName("PAGER")
                    .HasMaxLength(255);

                entity.Property(e => e.PostalCode1).HasColumnName("POSTAL_CODE_1");

                entity.Property(e => e.PostalCode2)
                    .HasColumnName("POSTAL_CODE_2")
                    .HasMaxLength(255);

                entity.Property(e => e.PreferredName)
                    .HasColumnName("PREFERRED_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Race)
                    .HasColumnName("RACE")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferredSource)
                    .HasColumnName("REFERRED_SOURCE")
                    .HasMaxLength(255);

                entity.Property(e => e.Relationship)
                    .HasColumnName("RELATIONSHIP")
                    .HasMaxLength(255);

                entity.Property(e => e.Remark)
                    .HasColumnName("REMARK")
                    .HasMaxLength(255);

                entity.Property(e => e.Smoker)
                    .HasColumnName("SMOKER")
                    .HasMaxLength(255);

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(255);

                entity.Property(e => e.Website)
                    .HasColumnName("WEBSITE")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.AgentId)
                    .HasConstraintName("FK_CUSTOMER_AGENT");
            });

            modelBuilder.Entity<Policy>(entity =>
            {
                entity.ToTable("POLICY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Benefits).HasColumnName("BENEFITS");

                entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.Name).HasColumnName("NAME");

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Policy)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_POLICY_CUSTOMER");
            });
        }
    }
}
