namespace Simple_Shop.Domain.DataModels
{
    public class ProductDTO : BaseDTO
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public bool Imported { get; set; }
        public int ProductTypeId { get; set; }
    }
}
