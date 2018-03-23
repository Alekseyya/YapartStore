namespace YapartStore.DAL.Repositories.Base
{
    public interface IUnitOfWork
    {
        IBrandRepository BrandRepository { get; set; }
        ICategoryRepository CategoryRepository { get; set; }
        IGroupRepository GroupRepository { get; set; }
        IProductRepository ProductRepository { get; set; }
        ISectionRepository SectionRepository { get; set; }
        void Save();
    }
}
