namespace WebWorkshopManager.Shared.Models
{
    public class JobItemDto : BaseDto
    {
        public int JobItemId { get; set; }

        public ProductDto Product { get; set; }

        public string Description { get; set; }

        public decimal Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public int JobId { get; set; }
    }
}
