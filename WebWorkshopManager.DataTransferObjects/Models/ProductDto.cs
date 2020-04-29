using WebWorkshopManager.Shared.ENUMS;

namespace WebWorkshopManager.Shared.Models
{
    public class ProductDto : BaseDto
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public PRODUCT_TYPE ProductType { get; set; }

        public decimal QuantityInStock { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
