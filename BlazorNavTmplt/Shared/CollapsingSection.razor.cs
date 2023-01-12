using Microsoft.AspNetCore.Components;

namespace BlazorNavTmplt.Shared
{
    public partial class CollapsingSection
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
        [Parameter]
        public string IconClasses { get; set; }
        [Parameter]
        public string ParentButtonText { get; set; }
        public string ChevronLeftDisplay = "block";
        public string ChevronDownDisplay = "none";
        public string SectionDisplay = "none";

        public void ToggleSection()
        {
            if (ChevronLeftDisplay == "block")
            {
                ChevronLeftDisplay = "none";
                ChevronDownDisplay = "block";
                SectionDisplay = "block";
            }
            else
            {
                ChevronLeftDisplay = "block";
                ChevronDownDisplay = "none";
                SectionDisplay = "none";
            }
        }
    }
}
