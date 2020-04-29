namespace WebWorkshopManager.Shared.Models
{
    public class CarDto : BaseDto
    {
        public int CarId { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public EngineDto Engine { get; set; }

        public string EngineNumber { get; set; }

        public string Vin { get; set; }

        public int Year { get; set; }

        public string LicensePlate { get; set; }

        public decimal Mileage { get; set; }
    }
}
