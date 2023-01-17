using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Linq.Expressions;

namespace BlazorNavTmplt.Shared
{
    public partial class MainLayout : LayoutComponentBase
    {
        [Inject]
        public IJSRuntime Js { get; set; }
        public string DisplayInstallPromo = "none";
        public string DisplayInstallPrompt = "none";

        protected override void OnInitialized()
        {
            Js.InvokeVoidAsync("InitializeInstallAppPrompt");
            DisplayInstallPromo = "flex";
        }
        public void OnTapInstallPromo()
        {
            DisplayInstallPromo = "none";
            DisplayInstallPrompt = "flex";
        }
        public void OnTapInstallPrompt()
        {
            Js.InvokeVoidAsync("InstallApp");
            DisplayInstallPrompt = "none";
        }
        public void OnTapCloseInstallPrompt()
        {
            DisplayInstallPromo = "flex";
            DisplayInstallPrompt = "none";
        }
    }
}
