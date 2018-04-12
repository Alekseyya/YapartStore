using System;
using Microsoft.AspNet.Identity.EntityFramework;
using YapartStore.DL.Context;

namespace YapartStore.DL.Entities.Identity
{
    public class CustomUserStore : UserStore<User, CustomRole, Guid,  Login, Role, Claim>
    {
        public CustomUserStore(YapartStoreContext yapartStoreContext) :base(yapartStoreContext)
        {}
    }
}
