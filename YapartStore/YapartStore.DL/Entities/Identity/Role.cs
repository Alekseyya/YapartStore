using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Microsoft.AspNet.Identity.EntityFramework;

namespace YapartStore.DL.Entities.Identity
{
    public class Role : IdentityUserRole<Guid>
    {}

    public class CustomRole : IdentityRole<Guid, Role>
    {
        public CustomRole() { }
        public CustomRole(string name) { Name = name; }
    }

    public class RoleConfiguration : EntityTypeConfiguration<CustomRole>
    {
        public RoleConfiguration()
        {
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(x => x.Name);
        }
    }
}
