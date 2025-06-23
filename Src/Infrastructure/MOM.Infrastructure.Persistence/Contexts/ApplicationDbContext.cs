using Microsoft.EntityFrameworkCore;
using MOM.Application.Infrastructure.Services;
using MOM.Domain.CodingRule;
using MOM.Domain.Common.Relationship.isa95.Equipment;
using MOM.Domain.Common.Relationship.isa95.EquipmentClass;
using MOM.Domain.Common.Relationship.isa95.HierarchyScope;
using MOM.Domain.Common.Relationship.isa95.Person;
using MOM.Domain.Common.Relationship.isa95.PersonnelClass;
using MOM.Domain.Common.Relationship.isa95.PhysicalAsset;
using MOM.Domain.Common.Relationship.isa95.PhysicalAssetClass;
using MOM.Domain.isa95.CommonObjectModels;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;
using MOM.Domain.Permission;
using MOM.Infrastructure.Persistence.Extensions;
using System.Threading;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Contexts
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IAuthenticatedUserService authenticatedUser) : DbContext(options)
    {
        #region Personnel

        public DbSet<PersonnelClass> PersonnelClasses { get; set; }
        public DbSet<PersonnelClassIncludesPropertiesOfRelationship> PersonnelClassIncludesPropertiesOfRelationships { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<PersonDefinedByRelationship> PersonDefinedByRelationship { get; set; }
        public DbSet<PersonHierarchyScopeRelRelationship> PersonHierarchyScopeRelRelationship { get; set; }

        #endregion Personnel

        #region Permission

        public DbSet<AvailablePermission> AvailablePermissions { get; set; }
        public DbSet<Button> Buttons { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<PersonnelClassPermission> PersonnelClassPermission { get; set; }
        public DbSet<OrgPermission> OrgPermission { get; set; }

        #endregion Permission

        #region HierarchyScope

        public DbSet<HierarchyScope> HierarchyScopes { get; set; }
        public DbSet<HierarchyScopeContainsRelationship> HierarchyScopeContainsRelationship { get; set; }

        #endregion HierarchyScope

        #region 编码规则

        public virtual DbSet<CodingRule> CodingRules { get; set; }
        public virtual DbSet<CodingSegment> CodingSegments { get; set; }
        public virtual DbSet<SequenceState> SequenceStates { get; set; }

        #endregion 编码规则

        #region 设备类与资产
        public DbSet<EquipmentClass> EquipmentClass { get; set; }
        public DbSet<EquipmentClassIsMadeUpOfRelationship> EquipmentClassIsMadeUpOfRelationship { get; set; }
        public DbSet<EquipmentClassIncludesPropertiesOfRelationship> EquipmentClassIncludesPropertiesOfRelationship { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<EquipmentIsMadeUpOfRelationship> EquipmentIsMadeUpOfRelationship { get; set; }

        public DbSet<PhysicalAssetClass> PhysicalAssetClass { get; set; }
        public DbSet<PhysicalAssetClassIsMadeUpOfRelationship> PhysicalAssetClassIsMadeUpOfRelationship { get; set; }
        public DbSet<PhysicalAssetClassIncludesPropertiesOfRelationship> PhysicalAssetClassIncludesPropertiesOfRelationship { get; set; }
        public DbSet<PhysicalAsset> PhysicalAsset { get; set; }
        public DbSet<PhysicalAssetIsMadeUpOfRelationship> PhysicalAssetIsMadeUpOfRelationship { get; set; }
        #endregion
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
        {
            ChangeTracker.ApplyAuditing(authenticatedUser);

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
#if DEBUG
            optionsBuilder.EnableSensitiveDataLogging();
#endif
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            this.ConfigureDecimalProperties(builder);

            base.OnModelCreating(builder);
        }
    }
}