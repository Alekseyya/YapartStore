
using System;
using Microsoft.AspNet.Identity.EntityFramework;
using YapartStore.DL.Context;

namespace YapartStore.DL.Entities.Identity
{
    public class CustomRoleStore : RoleStore<CustomRole, Guid, Role>
    {
        public CustomRoleStore(YapartStoreContext yapartStoreContext)
            : base(yapartStoreContext)
        {
        }
    }
}
