using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using YapartStore.DL.Entities.Identity;

namespace YapartStore.DAL.Repositories.Base
{
    public interface IUserRepository
    {
        Task<IdentityResult> CreateAsync(User user);
        Task<IdentityResult> CreateAsync(User user, string password);
        Task<User> FindUserAsync(string userName, string password);
        Task<User> FindUserByGuidAsyc(User user);
        Task<IdentityResult> DeleteUserAsync(User user);
        Task<IdentityResult> UpdateUserAsync(User user);
        Task SaveChanges();
    }
}
