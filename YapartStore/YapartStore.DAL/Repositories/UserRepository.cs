using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Context;
using YapartStore.DL.Entities.Identity;

namespace YapartStore.DAL.Repositories
{
     public class UserRepository : IUserRepository
     {
         private readonly YapartStoreContext _yapartStoreContext;
         private readonly UserManager<User, Guid> _userManager;
         public UserRepository(YapartStoreContext yapartStoreContext, UserManager<User, Guid> userManager)
         {
             _yapartStoreContext = yapartStoreContext;
             _userManager = userManager;
         }

        public Task<IdentityResult> CreateAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> CreateAsync(User user, string password)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> DeleteUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> FindUserAsync(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public Task<User> FindUserByGuidAsyc(User user)
        {
            throw new NotImplementedException();
        }

        public Task SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
