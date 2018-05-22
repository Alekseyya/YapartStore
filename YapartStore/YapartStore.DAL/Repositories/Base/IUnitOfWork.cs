namespace YapartStore.DAL.Repositories.Base
{
    public interface IUnitOfWork
    {
        IBrandRepository BrandRepository { get; set; }
        ICategoryRepository CategoryRepository { get; set; }
        IGroupRepository GroupRepository { get; set; }
        IProductRepository ProductRepository { get; set; }
        ISectionRepository SectionRepository { get; set; }
        IPictureRepository PictureRepository { get; set; }
        IOrderRepository OrderRepository { get; set; }
        IOrderItemRepository OrderItemRepository { get; set; }

        IUserRepository UserRepository { get; set; }
        IRoleRepository RoleRepository { get; set; }

        void Save();
    }
}
