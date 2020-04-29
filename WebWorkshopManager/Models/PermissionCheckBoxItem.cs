using WebWorkshopManager.Shared.ENUMS;

namespace WebWorkshopManager.Web.Models
{
    public class PermissionCheckBoxItem
    {
        public string Label { get; set; }

        public PERMISSION Permission { get; set; }

        public bool IsChecked { get; set; }
    }
}
