using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Microsoft.AspNet.Identity.EntityFramework;

namespace YapartStore.DL.Entities.Identity
{
    public class User : IdentityUser<Guid, Login, Role, Claim>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
    }
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(x => x.FirstName);
            Property(x => x.LastName);
            Property(x => x.Age).IsOptional();
            Property(x => x.Gender);
        }
    }
}
