using Microsoft.EntityFrameworkCore;
using MOM.Application.Infrastructure.Services;
using MOM.Domain.Common.Relationship.isa95.HierarchyScope;
using MOM.Domain.Common.Relationship.isa95.Person;
using MOM.Domain.Common.Relationship.isa95.PersonnelClass;
using MOM.Domain.isa95.CommonObjectModels;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
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

        public DbSet<HierarchyScope> HierarchyScopes { get; set; }
        public DbSet<HierarchyScopeContainsRelationship> HierarchyScopeContainsRelationship { get; set; }

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