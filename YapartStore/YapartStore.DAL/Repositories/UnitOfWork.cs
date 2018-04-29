using System;
using Microsoft.AspNet.Identity;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Context;
using YapartStore.DL.Entities.Identity;

namespace YapartStore.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly YapartStoreContext _yapartStoreContext;
        public UnitOfWork()
        {
            _yapartStoreContext = new YapartStoreContext();
            BrandRepository = new BrandRepository(_yapartStoreContext);
            CategoryRepository = new CategoryRepository(_yapartStoreContext);
            GroupRepository = new GroupRepository(_yapartStoreContext);
            SectionRepository = new SectionRepository(_yapartStoreContext);
            ProductRepository = new ProductRepository(_yapartStoreContext);
            PictureRepository = new PictureRepository(_yapartStoreContext);
            UserRepository = new UserRepository(_yapartStoreContext,
                new UserManager<User, Guid>
                (
                    new CustomUserStore(_yapartStoreContext)
                ));
            RoleRepository = new RoleRepository(_yapartStoreContext,
                new RoleManager<CustomRole, Guid>
                (
                   new CustomRoleStore(_yapartStoreContext)
                ));
        }
        public IBrandRepository BrandRepository { get; set; }
        public ICategoryRepository CategoryRepository { get; set; }
        public IGroupRepository GroupRepository { get; set; }
        public IProductRepository ProductRepository { get; set; }
        public ISectionRepository SectionRepository { get; set; }
        public IPictureRepository PictureRepository { get; set; }

        public IUserRepository UserRepository { get; set; }
        public IRoleRepository RoleRepository { get; set; }

        public void Save()
        {
            _yapartStoreContext.SaveChanges();
        }
    }
}
