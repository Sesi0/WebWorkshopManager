using System.Collections.Generic;

namespace WebWorkshopManager.Shared.Models
{
    public abstract class BaseDto
    {
        public ICollection<string> Errors { get; set; }
    }
}
