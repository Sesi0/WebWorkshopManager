using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace WebWorkshopManager.Web.Shared
{
    public class MainLayoutBase : LayoutComponentBase
    {
        protected bool navMenuOpened = true;
        protected bool navMinified = false;
        public string bbDrawerClass = "";

        protected override void OnInitialized()
        {
            this.NavMinify();
        }

        public void NavToggle()
        {
            this.navMenuOpened = !this.navMenuOpened;
            
            if (this.navMenuOpened)
            {
                this.bbDrawerClass = "full";
            }
            else
            {
                this.bbDrawerClass = "closed";
            }

            this.StateHasChanged();
        }

        public void NavMinify()
        {
            this.navMinified = !this.navMinified;

            if (!this.navMenuOpened)
            {
                this.navMinified = true;
            }

            if (this.navMinified)
            {
                this.bbDrawerClass = "mini";
                this.navMenuOpened = true;
            }
            else if (this.navMenuOpened)
            {
                this.bbDrawerClass = "full";
            }

            this.navMenuOpened = true;
            this.StateHasChanged();
        }
    }
}
