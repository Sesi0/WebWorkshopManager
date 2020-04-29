namespace WebWorkshopManager.Shared.Models
{
    public class CustomerDto : BaseDto
    {
        public int CustomerId { get; set; }

        public string Name { get; set; }

        public string ContactNumber { get; set; }

        public string Email { get; set; }
    }
}
