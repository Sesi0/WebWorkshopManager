using WebWorkshopManager.Shared.ENUMS;

namespace WebWorkshopManager.Shared.Models
{
    public class JobDto : BaseDto
    {
        public int JobId { get; set; }

        public int JobNumber { get; set; }

        public JOB_STATUS Status { get; set; }

        public UserDto Worker { get; set; }

        public CustomerDto Customer { get; set; }

        public CarDto Car { get; set; }
    }
}
