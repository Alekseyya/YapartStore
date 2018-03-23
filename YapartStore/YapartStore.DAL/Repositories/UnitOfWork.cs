using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Context;

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
        }
        public IBrandRepository BrandRepository { get; set; }
        public ICategoryRepository CategoryRepository { get; set; }
        public IGroupRepository GroupRepository { get; set; }
        public IProductRepository ProductRepository { get; set; }
        public ISectionRepository SectionRepository { get; set; }
        public void Save()
        {
            _yapartStoreContext.SaveChanges();
        }
    }
}
