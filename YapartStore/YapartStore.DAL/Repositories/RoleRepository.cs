using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Context;
using YapartStore.DL.Entities.Identity;

namespace YapartStore.DAL.Repositories
{
    public class RoleRepository: IRoleRepository
    {
        private readonly YapartStoreContext _yapartStoreContext;
        private readonly RoleManager<CustomRole, Guid> _roleManager;
        
        public RoleRepository(YapartStoreContext yapartStoreContext, RoleManager<CustomRole, Guid> roleManager)
        {
            _yapartStoreContext = yapartStoreContext;
            _roleManager = roleManager;
        }
    }
}
