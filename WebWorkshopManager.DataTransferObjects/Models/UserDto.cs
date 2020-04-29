namespace WebWorkshopManager.Shared.Models
{
    public class UserDto : BaseDto
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public RoleDto Role { get; set; }
    }
}
