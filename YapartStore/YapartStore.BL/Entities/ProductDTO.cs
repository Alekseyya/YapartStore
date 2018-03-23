namespace YapartStore.BL.Entities
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Descriptions { get; set; }
        public decimal Price { get; set; }
        public string Article { get; set; }
        public BrandDTO Brand { get; set; }
        public CategoryDTO Category { get; set; }
    }

}