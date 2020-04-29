using System.Threading.Tasks;
using WebWorkshopManager.ClientSide.Resources;
using WebWorkshopManager.Services.Contracts;

namespace WebWorkshopManager.Shared
{
    public static class GLOBALS
    {
        private static IRoleService roleService;

        static GLOBALS(IRoleService roleService)
        {
            GLOBALS.roleService = roleService;
        }

        public static  AppComponents AppComponents { get; set; }

        public static async Task ReloadAppComponents()
        {

        }

        public static async Task ReloadRolesAppComponent()
        {
            GLOBALS.AppComponents.Roles.Clear();

            var roles = await 
        }
    }
}
