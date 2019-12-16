using Simple_Shop.Domain.Entities.Exceptions;
using System;

namespace Simple_Shop.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int ProductTypeId { get; set; }
        public bool Imported { get; set; }
        public bool Taxable => ProductType == ProductType.Taxable;
        public ProductType ProductType => (ProductType)ProductTypeId;
        public decimal ImportFee => Imported ? Math.Ceiling((Price * .05M) * 20) / 20 : 0;
        public decimal Tax => Taxable ? Math.Ceiling((Price * .1M) * 20) / 20 : 0;
        public decimal TotalPrice => Price + ImportFee + Tax;

        public void Validate()
        {
            if (Price <= 0 || ProductTypeId <= 0 || string.IsNullOrWhiteSpace(Title))
            {
                throw new ProductInvalidException();
            }
        }
    }
}
