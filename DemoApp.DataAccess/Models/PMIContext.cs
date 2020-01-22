using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DemoApp.DataAccess.Models
{
    public partial class PMIContext : DbContext
    {
        public PMIContext()
        {
        }

        public PMIContext(DbContextOptions<PMIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AtsinformationPmis> AtsinformationPmis { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<EmailTemplates> EmailTemplates { get; set; }
        public virtual DbSet<EquipmentInformationPmis> EquipmentInformationPmis { get; set; }
        public virtual DbSet<FireSystemManufacturerMasterPmis> FireSystemManufacturerMasterPmis { get; set; }
        public virtual DbSet<FireSystemPmis> FireSystemPmis { get; set; }
        public virtual DbSet<FireSystemTypeMasterPmis> FireSystemTypeMasterPmis { get; set; }
        public virtual DbSet<GeneratorInformationPmis> GeneratorInformationPmis { get; set; }
        public virtual DbSet<HvacinformationPmis> HvacinformationPmis { get; set; }
        public virtual DbSet<LetterTemplates> LetterTemplates { get; set; }
        public virtual DbSet<LetterTypes> LetterTypes { get; set; }
        public virtual DbSet<LocationAssignedToUsers> LocationAssignedToUsers { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<PmicategoryTypeMasters> PmicategoryTypeMasters { get; set; }
        public virtual DbSet<PmichecklistHistoryLogs> PmichecklistHistoryLogs { get; set; }
        public virtual DbSet<PmichecklistQuestionMasters> PmichecklistQuestionMasters { get; set; }
        public virtual DbSet<PmichecklistStatusMasters> PmichecklistStatusMasters { get; set; }
        public virtual DbSet<Pmichecklists> Pmichecklists { get; set; }
        public virtual DbSet<PmiemailLogs> PmiemailLogs { get; set; }
        public virtual DbSet<Pmihistories> Pmihistories { get; set; }
        public virtual DbSet<PmimasterTableInformations> PmimasterTableInformations { get; set; }
        public virtual DbSet<Pmimasters> Pmimasters { get; set; }
        public virtual DbSet<PmitypeMasters> PmitypeMasters { get; set; }
        public virtual DbSet<StateMasters> StateMasters { get; set; }
        public virtual DbSet<StreetMasters> StreetMasters { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserMasters> UserMasters { get; set; }
        public virtual DbSet<VwAccountsDetails> VwAccountsDetails { get; set; }
        public virtual DbSet<VwActivityDetails> VwActivityDetails { get; set; }
        public virtual DbSet<VwCircuitDetailsList> VwCircuitDetailsList { get; set; }
        public virtual DbSet<VwGetLocationListNew> VwGetLocationListNew { get; set; }
        public virtual DbSet<VwUserAuthenticate> VwUserAuthenticate { get; set; }
        public virtual DbSet<VwUserAuthenticateWithRole> VwUserAuthenticateWithRole { get; set; }
        public virtual DbSet<VwUserAuthenticateWithRolePmi> VwUserAuthenticateWithRolePmi { get; set; }
        public virtual DbSet<VwWorkflowNotificationDetail> VwWorkflowNotificationDetail { get; set; }
        public virtual DbSet<VwtaskScheduleTaskDetails> VwtaskScheduleTaskDetails { get; set; }
        public virtual DbSet<WorkFlowTypeMasters> WorkFlowTypeMasters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=NTZ-CPU-221\\SQLEXPRESS;Database=PMI; User Id=sa; password=1212;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AtsinformationPmis>(entity =>
            {
                entity.HasKey(e => e.AtsinformationPmiId);

                entity.ToTable("ATSInformationPMIs");

                entity.Property(e => e.AtsinformationPmiId).HasColumnName("ATSInformationPMI_ID");

                entity.Property(e => e.Atsmake)
                    .HasColumnName("ATSMake")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Atsmodel)
                    .HasColumnName("ATSModel")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Atsserial)
                    .HasColumnName("ATSSerial")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.EquipmentCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EquipmentType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InstalledDate).HasColumnType("datetime");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PmitypeId).HasColumnName("PMITypeID");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.HasIndex(e => e.CustomerOwnerUserId)
                    .HasName("IX_FK_Customer_UserMaster");

                entity.HasIndex(e => e.ParentCustomerId)
                    .HasName("IX_FK_Customer_Customer");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.AgentFee)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AnnualRevenue).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AttentionTo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Ben)
                    .HasColumnName("BEN")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerStatusId).HasColumnName("CustomerStatusID");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.DisplayId)
                    .HasColumnName("DisplayID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmaiId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceSubmittalEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsGtcattached).HasColumnName("IsGTCAttached");

                entity.Property(e => e.IsTtssurveyNeeded).HasColumnName("IsTTSSurveyNeeded");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.Property(e => e.PrimaryCustomerId).HasColumnName("PrimaryCustomerID");

                entity.Property(e => e.Satype)
                    .HasColumnName("SAType")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StreetAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubAccountNumber).HasMaxLength(50);

                entity.Property(e => e.Website)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CustomerOwnerUser)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CustomerOwnerUserId)
                    .HasConstraintName("FK_Customer_UserMaster");

                entity.HasOne(d => d.ParentCustomer)
                    .WithMany(p => p.InverseParentCustomer)
                    .HasForeignKey(d => d.ParentCustomerId)
                    .HasConstraintName("FK_Customer_Customer");
            });

            modelBuilder.Entity<EmailTemplates>(entity =>
            {
                entity.HasKey(e => new { e.EmailTemplateId, e.Description, e.Path });

                entity.Property(e => e.EmailTemplateId)
                    .HasColumnName("EmailTemplateID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.Subject)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TaskId).HasColumnName("TaskID");
            });

            modelBuilder.Entity<EquipmentInformationPmis>(entity =>
            {
                entity.HasKey(e => e.EquipmentInformationPmiId);

                entity.ToTable("EquipmentInformationPMIs");

                entity.Property(e => e.EquipmentInformationPmiId).HasColumnName("EquipmentInformationPMI_ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Enclosure)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EquipmentSerial)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EquipmentType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Floor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PmitypeId).HasColumnName("PMITypeID");
            });

            modelBuilder.Entity<FireSystemManufacturerMasterPmis>(entity =>
            {
                entity.ToTable("FireSystemManufacturerMasterPMIs");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Fsmanufacturer)
                    .IsRequired()
                    .HasColumnName("FSManufacturer")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<FireSystemPmis>(entity =>
            {
                entity.HasKey(e => e.FireSystemPmiId);

                entity.ToTable("FireSystemPMIs");

                entity.Property(e => e.FireSystemPmiId).HasColumnName("FireSystemPMI_ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.EquipmentCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EquipmentType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FsmanufacturerId).HasColumnName("FSManufacturerId");

                entity.Property(e => e.Fsserial)
                    .HasColumnName("FSSerial")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Fstype)
                    .HasColumnName("FSType")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InstalledDate).HasColumnType("datetime");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Pmitype).HasColumnName("PMIType");
            });

            modelBuilder.Entity<FireSystemTypeMasterPmis>(entity =>
            {
                entity.ToTable("FireSystemTypeMasterPMIs");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.FireSystemType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GeneratorInformationPmis>(entity =>
            {
                entity.HasKey(e => e.GnpmiId);

                entity.ToTable("GeneratorInformationPMIs");

                entity.Property(e => e.GnpmiId).HasColumnName("GNPMI_ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.EngineFuelType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EngineMake)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EngineModel)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EngineSerial)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EquipmentCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EquipmentType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GnKwRating)
                    .HasColumnName("Gn_KW_Rating")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GnManufacturer)
                    .HasColumnName("GN_Manufacturer")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GnSerial)
                    .HasColumnName("GN_Serial")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InstalledDate).HasColumnType("datetime");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PmitypeId).HasColumnName("PMITypeID");
            });

            modelBuilder.Entity<HvacinformationPmis>(entity =>
            {
                entity.HasKey(e => e.HvacId);

                entity.ToTable("HVACInformationPMIs");

                entity.Property(e => e.HvacId).HasColumnName("HVAC_ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.EquipmentCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EquipmentType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InstalledDate).HasColumnType("datetime");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PmitypeId).HasColumnName("PMITypeID");

                entity.Property(e => e.UnitKwrating)
                    .HasColumnName("UnitKWRating")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitManufacture)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitModel)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitSerial)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LetterTemplates>(entity =>
            {
                entity.HasKey(e => e.LetterTemplateId);

                entity.HasIndex(e => e.LetterTypeId)
                    .HasName("IX_FK_LetterTemplate_LetterTypeID");

                entity.Property(e => e.LetterTemplateId).HasColumnName("LetterTemplateID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DisplayName).HasMaxLength(50);

                entity.Property(e => e.FileName).HasMaxLength(200);

                entity.Property(e => e.LetterTypeId).HasColumnName("LetterTypeID");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.LetterType)
                    .WithMany(p => p.LetterTemplates)
                    .HasForeignKey(d => d.LetterTypeId)
                    .HasConstraintName("FK_LetterTemplate_LetterTypeID");
            });

            modelBuilder.Entity<LetterTypes>(entity =>
            {
                entity.HasKey(e => e.LetterTypeId);

                entity.Property(e => e.LetterTypeId).HasColumnName("LetterTypeID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsPmi).HasColumnName("IsPMI");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Template)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LocationAssignedToUsers>(entity =>
            {
                entity.Property(e => e.LocationAssignedToUsersId).HasColumnName("LocationAssignedToUsersID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.HasIndex(e => e.StreetId)
                    .HasName("IX_FK_Location_StreetMaster");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.BuildingFiberStatusId).HasColumnName("BuildingFiberStatusID");

                entity.Property(e => e.BuildingServiceStatusId).HasColumnName("BuildingServiceStatusID");

                entity.Property(e => e.BuildingSubTypeIds)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClliCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cllicode1)
                    .HasColumnName("CLLICode1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Demarc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ftpdemarc)
                    .HasColumnName("FTPDemarc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsLocDiverseEntry).HasColumnName("isLocDiverseEntry");

                entity.Property(e => e.IspdemarcNotes)
                    .HasColumnName("ISPDemarcNotes")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Lata)
                    .HasColumnName("LATA")
                    .IsUnicode(false);

                entity.Property(e => e.LocNote)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LocTypeId).HasColumnName("LocTypeID");

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocationRecordId).HasColumnName("LocationRecordID");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.OffNetFootageId).HasColumnName("OffNetFootageID");

                entity.Property(e => e.OspdemarcNotes)
                    .HasColumnName("OSPDemarcNotes")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ParentLocationId).HasColumnName("ParentLocationID");

                entity.Property(e => e.StreetId).HasColumnName("StreetID");

                entity.Property(e => e.ThirdPartyBuildingStatusId).HasColumnName("ThirdPartyBuildingStatusID");

                entity.Property(e => e.Ubid).HasColumnName("UBID");

                entity.Property(e => e.UpnhubStatusId).HasColumnName("UPNHubStatusID");

                entity.HasOne(d => d.Street)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.StreetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Location_StreetMaster");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.Property(e => e.DateAdded).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PublicId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Photo)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Photo_User");
            });

            modelBuilder.Entity<PmicategoryTypeMasters>(entity =>
            {
                entity.ToTable("PMICategoryTypeMasters");

                entity.HasIndex(e => e.PmitypeId)
                    .HasName("IX_FK_PMICategoryTypeMaster_PMITypeMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PmimasterId).HasColumnName("PMIMasterID");

                entity.Property(e => e.PmitypeId).HasColumnName("PMITypeID");

                entity.HasOne(d => d.Pmitype)
                    .WithMany(p => p.PmicategoryTypeMasters)
                    .HasForeignKey(d => d.PmitypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PMICategoryTypeMaster_PMITypeMaster");
            });

            modelBuilder.Entity<PmichecklistHistoryLogs>(entity =>
            {
                entity.ToTable("PMIChecklistHistoryLogs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryType).HasMaxLength(500);

                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PmiId).HasColumnName("PMI_ID");

                entity.Property(e => e.PmitypeId).HasColumnName("PMITypeID");

                entity.Property(e => e.Question).HasMaxLength(1000);

                entity.Property(e => e.Status).HasMaxLength(100);
            });

            modelBuilder.Entity<PmichecklistQuestionMasters>(entity =>
            {
                entity.ToTable("PMIChecklistQuestionMasters");

                entity.HasIndex(e => e.CategoryTypeId)
                    .HasName("IX_FK_PMIChecklistQuestionMaster_PMICategoryTypeMaster");

                entity.HasIndex(e => e.PmitypeId)
                    .HasName("IX_FK_PMIChecklistQuestionMaster_PMITypeMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PmitypeId).HasColumnName("PMITypeID");

                entity.Property(e => e.Question)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.CategoryTypeNavigation)
                    .WithMany(p => p.PmichecklistQuestionMasters)
                    .HasForeignKey(d => d.CategoryTypeId)
                    .HasConstraintName("FK_PMIChecklistQuestionMaster_PMICategoryTypeMaster");

                entity.HasOne(d => d.Pmitype)
                    .WithMany(p => p.PmichecklistQuestionMasters)
                    .HasForeignKey(d => d.PmitypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PMIChecklistQuestionMaster_PMITypeMaster");
            });

            modelBuilder.Entity<PmichecklistStatusMasters>(entity =>
            {
                entity.ToTable("PMIChecklistStatusMasters");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<Pmichecklists>(entity =>
            {
                entity.ToTable("PMIChecklists");

                entity.HasIndex(e => e.PmitypeId)
                    .HasName("IX_FK_PMIChecklist_PMITypeMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PmiId).HasColumnName("PMI_ID");

                entity.Property(e => e.PmitypeId).HasColumnName("PMITypeID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.StatusTypeId).HasColumnName("StatusTypeID");

                entity.HasOne(d => d.Pmitype)
                    .WithMany(p => p.Pmichecklists)
                    .HasForeignKey(d => d.PmitypeId)
                    .HasConstraintName("FK_PMIChecklist_PMITypeMaster");
            });

            modelBuilder.Entity<PmiemailLogs>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("PMIEmailLogs");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.EmailTemplateId).HasColumnName("EmailTemplateID");

                entity.Property(e => e.RenderedBcc)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.RenderedCc)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.RenderedSubject)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SentTime).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<Pmihistories>(entity =>
            {
                entity.ToTable("PMIHistories");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.NewValue).HasMaxLength(500);

                entity.Property(e => e.OldValue).HasMaxLength(500);

                entity.Property(e => e.Type).HasMaxLength(250);
            });

            modelBuilder.Entity<PmimasterTableInformations>(entity =>
            {
                entity.ToTable("PMIMasterTableInformations");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KeyColumn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValueColumn)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pmimasters>(entity =>
            {
                entity.ToTable("PMIMasters");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PmitypeMasters>(entity =>
            {
                entity.ToTable("PMITypeMasters");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PmimasterId).HasColumnName("PMIMasterID");

                entity.Property(e => e.Pmitype)
                    .IsRequired()
                    .HasColumnName("PMIType")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<StateMasters>(entity =>
            {
                entity.HasKey(e => e.StateId);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");
            });

            modelBuilder.Entity<StreetMasters>(entity =>
            {
                entity.HasKey(e => e.StreetId);

                entity.HasIndex(e => e.StateId)
                    .HasName("IX_FK_StreetMaster_StateMaster");

                entity.Property(e => e.StreetId).HasColumnName("StreetID");

                entity.Property(e => e.BuildingServiceTypeId).HasColumnName("BuildingServiceTypeID");

                entity.Property(e => e.BuildingSubTypeId).HasColumnName("BuildingSubTypeID");

                entity.Property(e => e.BuildingTypeId).HasColumnName("BuildingTypeID");

                entity.Property(e => e.Cage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cllicode)
                    .HasColumnName("CLLICode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasColumnName("COUNTY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Floor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastAuditedDate).HasColumnType("datetime");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationNote)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LocationTypeId).HasColumnName("LocationTypeID");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MarketId).HasColumnName("MarketID");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Rack)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StatusChangeNotes)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SubMarketId).HasColumnName("SubMarketID");

                entity.Property(e => e.Suite)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.StreetMasters)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_StreetMaster_StateMaster");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("date");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Interests)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Introduction)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KnownAs)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastActive).HasColumnType("date");

                entity.Property(e => e.LookingFor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordHash)
                    .HasMaxLength(500)
                    .IsFixedLength();

                entity.Property(e => e.PasswordSalt)
                    .HasMaxLength(500)
                    .IsFixedLength();

                entity.Property(e => e.Username)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserMasters>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CmsroleId).HasColumnName("CMSRoleID");

                entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("ImageURL")
                    .HasMaxLength(500);

                entity.Property(e => e.IsCiaccessAllowed).HasColumnName("IsCIAccessAllowed");

                entity.Property(e => e.IsCpaccessAllowed).HasColumnName("IsCPAccessAllowed");

                entity.Property(e => e.LastCrmloginTime)
                    .HasColumnName("LastCRMLoginTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastOssloginTime)
                    .HasColumnName("LastOSSLoginTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastTtsloginTime)
                    .HasColumnName("LastTTSLoginTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Moprole)
                    .HasColumnName("MOPRole")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.TokenCreatedOn)
                    .HasColumnName("Token_Created_On")
                    .HasColumnType("datetime");

                entity.Property(e => e.TokenId)
                    .HasColumnName("Token_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Ttsrole)
                    .HasColumnName("TTSRole")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TtsuserGroupId).HasColumnName("TTSUserGroupID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAccountsDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VW_AccountsDetails");

                entity.Property(e => e.AccountId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AccountOwner)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.AccountStatus)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Accountname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgentFee)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AnnualRevenue)
                    .HasColumnName("Annual_Revenue")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CustomerJobs)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IndustryType)
                    .IsRequired()
                    .HasColumnName("Industry_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryAddress)
                    .HasMaxLength(306)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwActivityDetails>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.TaskEmail, e.Priority });

                entity.ToTable("VW_ActivityDetails");

                entity.Property(e => e.TaskEmail)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Priority)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AssignedBy)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.AssignedTo)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.EntityValueName)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.Isactive).HasColumnName("ISActive");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwCircuitDetailsList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VW_CircuitDetailsList");

                entity.Property(e => e.ChildProductType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CircuitDetailId).HasColumnName("CircuitDetailID");

                entity.Property(e => e.CircuitStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CircuitStatusId).HasColumnName("CircuitStatusID");

                entity.Property(e => e.DarkFibersNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExistingTracker)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsColoSpaceRequired)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IsCrossConnect)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IsLocAduplicate).HasColumnName("IsLocADuplicate");

                entity.Property(e => e.IsLocAsameForSelectedProduct).HasColumnName("IsLocASameForSelectedProduct");

                entity.Property(e => e.IsLocZduplicate).HasColumnName("IsLocZDuplicate");

                entity.Property(e => e.IsTypeIirequired)
                    .IsRequired()
                    .HasColumnName("IsTypeIIRequired")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.JobOptionId).HasColumnName("JobOptionID");

                entity.Property(e => e.LocAcllicode)
                    .HasColumnName("LocACLLICode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocAduplicateData)
                    .IsRequired()
                    .HasColumnName("LocADuplicateData");

                entity.Property(e => e.LocAstreetId).HasColumnName("LocAStreetId");

                entity.Property(e => e.LocAverificationStatus).HasColumnName("LocAVerificationStatus");

                entity.Property(e => e.LocZcllicode)
                    .HasColumnName("LocZCLLICode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocZduplicateData)
                    .IsRequired()
                    .HasColumnName("LocZDuplicateData");

                entity.Property(e => e.LocZstreetId).HasColumnName("LocZStreetId");

                entity.Property(e => e.LocZverificationStatus).HasColumnName("LocZVerificationStatus");

                entity.Property(e => e.LocationA)
                    .HasMaxLength(175)
                    .IsUnicode(false);

                entity.Property(e => e.LocationAid).HasColumnName("LocationAID");

                entity.Property(e => e.LocationZ)
                    .HasMaxLength(174)
                    .IsUnicode(false);

                entity.Property(e => e.LocationZid).HasColumnName("LocationZID");

                entity.Property(e => e.OrderType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentCocircuitDetailId).HasColumnName("ParentCOCircuitDetailId");

                entity.Property(e => e.ProductType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PtpcircuitId)
                    .IsRequired()
                    .HasColumnName("PTPCircuitID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedBandwidth)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.UpdatedCircuitTypeId).HasColumnName("UpdatedCircuitTypeID");

                entity.Property(e => e.UpdatedTracker)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwGetLocationListNew>(entity =>
            {
                entity.HasKey(e => new { e.LocationRecord, e.LocationId, e.LocationName, e.StreetDescription, e.IsActive, e.StreetId, e.Auditverification, e.ValidatationStatus, e.LocStatus });

                entity.ToTable("VW_GetLocationListNew");

                entity.Property(e => e.LocationRecord)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StreetDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StreetId).HasColumnName("StreetID");

                entity.Property(e => e.Auditverification)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ValidatationStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LocStatus)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AssociatedProjects)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.BuildingFiberStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuildingServiceStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuildingServiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuildingType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClliCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cllicode1)
                    .HasColumnName("CLLICode1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasColumnName("COUNTY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Floor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ftpdemarc)
                    .HasColumnName("FTPDemarc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IspdemarcNotes)
                    .HasColumnName("ISPDemarcNotes")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.LastAuditByName)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.LastAuditDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Lata)
                    .HasColumnName("LATA")
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationTypeId).HasColumnName("LocationTypeID");

                entity.Property(e => e.LocationtypeNew).HasMaxLength(50);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Market)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpportnityAccountList)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.OrderAccountList)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.OspDermicNotes)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Rack)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StateDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusChangeNotes)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SubBuildingType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubMarket)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Suite)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThirdPartyBuildingStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpnHubStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserAuthenticate>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.DepartmentId, e.RoleId, e.IsAcceptedTermsConditions, e.UserTypeid, e.IsCpaccessAllowed, e.IsCiaccessAllowed, e.Ttsrole, e.DepartmentMasterIds, e.DepartmentMasterNames });

                entity.ToTable("VW_UserAuthenticate");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.IsCpaccessAllowed).HasColumnName("IsCPAccessAllowed");

                entity.Property(e => e.IsCiaccessAllowed).HasColumnName("IsCIAccessAllowed");

                entity.Property(e => e.Ttsrole)
                    .HasColumnName("TTSRole")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentMasterIds)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentMasterNames)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.AllPermissions)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentIds)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentNames)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.DeptWisepermissions)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupIds)
                    .HasColumnName("groupIds")
                    .HasMaxLength(500);

                entity.Property(e => e.GroupNames)
                    .HasColumnName("groupNames")
                    .HasMaxLength(4000);

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("ImageURL")
                    .HasMaxLength(500);

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleIds)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.RoleNames)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(101)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserAuthenticateWithRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId, e.UserTypeid });

                entity.ToTable("VW_UserAuthenticateWithRole");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DeptWisepermissions).IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("ImageURL")
                    .HasMaxLength(500);

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MyTeams).IsUnicode(false);

                entity.Property(e => e.MyVerticals)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleIds)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.RoleNames)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Ttsrole)
                    .HasColumnName("TTSRole")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(101)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserAuthenticateWithRolePmi>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId, e.UserTypeid });

                entity.ToTable("VW_UserAuthenticateWithRolePMI");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DeptWisepermissions).IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("ImageURL")
                    .HasMaxLength(500);

                entity.Property(e => e.LoginName)
                    .HasColumnName("loginName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MyTeams).IsUnicode(false);

                entity.Property(e => e.MyVerticals)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleIds)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.RoleNames)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Ttsrole)
                    .HasColumnName("TTSRole")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(101)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwWorkflowNotificationDetail>(entity =>
            {
                entity.HasKey(e => new { e.OpportunityType, e.CoreMarket, e.State, e.TypeIicolo, e.ParentJobId, e.CrmJobOptionId });

                entity.ToTable("VW_WorkflowNotificationDetail");

                entity.Property(e => e.OpportunityType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoreMarket)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TypeIicolo)
                    .HasColumnName("TypeIIColo")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CancelReason)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.EstimationNotes).IsUnicode(false);

                entity.Property(e => e.EstimationRequestId).HasColumnName("EstimationRequestID");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.LogicalDrawingComplete).HasColumnType("datetime");

                entity.Property(e => e.NetworkScope)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OppotunityOwner)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.OptionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TrackerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VerticalMarket)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwtaskScheduleTaskDetails>(entity =>
            {
                entity.HasKey(e => new { e.TaskScheduleId, e.WorkFlowTaskId, e.TaskId, e.TaskName, e.TrackingTaskName, e.ServiceTypeId, e.IsHold, e.DepartmentName, e.ServiceItem, e.ServiceType, e.ServiceLevelSdm, e.ServicelevelSdmgroup, e.TaskStage, e.FullTaskCode });

                entity.ToTable("VWTaskScheduleTaskDetails");

                entity.Property(e => e.TaskScheduleId).HasColumnName("TaskScheduleID");

                entity.Property(e => e.WorkFlowTaskId).HasColumnName("WorkFlowTaskID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingTaskName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceTypeId).HasColumnName("ServiceTypeID");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceItem)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceLevelSdm)
                    .HasColumnName("ServiceLevelSDM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ServicelevelSdmgroup)
                    .HasColumnName("ServicelevelSDMGroup")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaskStage)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.FullTaskCode)
                    .HasMaxLength(46)
                    .IsUnicode(false);

                entity.Property(e => e.ActualEndDate).HasColumnType("datetime");

                entity.Property(e => e.ActualStartDate).HasColumnType("datetime");

                entity.Property(e => e.CircuitGroupId).HasColumnName("CircuitGroupID");

                entity.Property(e => e.CircuitId).HasColumnName("CircuitID");

                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerTypeId).HasColumnName("CustomerTypeID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DeptGroupId).HasColumnName("DeptGroupID");

                entity.Property(e => e.DeptGroupName).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Focdate).HasColumnName("FOCDate");

                entity.Property(e => e.IsMou).HasColumnName("IsMOU");

                entity.Property(e => e.IsNa).HasColumnName("IsNA");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.JobNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailGuid)
                    .HasColumnName("MailGUID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MinimumTerm).HasColumnName("minimumTerm");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.OnHoldDate).HasColumnType("datetime");

                entity.Property(e => e.PactualInstallDate)
                    .HasColumnName("PActualInstallDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ParentTaskScheduleId).HasColumnName("ParentTaskScheduleID");

                entity.Property(e => e.PlannedEndDate).HasColumnType("datetime");

                entity.Property(e => e.PlannedStartDate).HasColumnType("datetime");

                entity.Property(e => e.PplannedInstallDate)
                    .HasColumnName("PPlannedInstallDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PtpcircuitId).HasColumnName("PTPCircuitID");

                entity.Property(e => e.ResumeDate).HasColumnType("datetime");

                entity.Property(e => e.SequenceId).HasColumnName("SequenceID");

                entity.Property(e => e.ServiceItemMasterId).HasColumnName("ServiceItemMasterID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TaskCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("TIMESTAMP")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.WebPage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WorkFlowId).HasColumnName("WorkFlowID");

                entity.Property(e => e.WorkFlowTaskStatusId).HasColumnName("WorkFlowTaskStatusID");

                entity.Property(e => e.WorkFlowTypeId).HasColumnName("WorkFlowTypeID");
            });

            modelBuilder.Entity<WorkFlowTypeMasters>(entity =>
            {
                entity.HasKey(e => e.WorkFlowTypeId);

                entity.Property(e => e.WorkFlowTypeId).HasColumnName("WorkFlowTypeID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
