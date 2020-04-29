using WebWorkshopManager.Shared.ENUMS;

namespace WebWorkshopManager.Shared.Models
{
    public class EngineDto : BaseDto
    {
        public int EngineId { get; set; }

        public string Name { get; set; }

        public int HorsePower { get; set; }

        public FUEL_TYPE FuelType { get; set; }
    }
}
