namespace MobileNavBlazorWasmTemplate.Shared
{
    public partial class BTNavMenu
    {

        // Button States: Off, OnPanel, OnPage
        private string navButtonAState = "Off";
        private string navButtonBState = "Off";
        private string navButtonCState = "Off";
        private string navButtonDState = "Off";
        private string navButtonEState = "Off";

        // Button Statuses: "", NavButtonStatusOnPanel, NavButtonStatusOnPage, NavButtonStatusOnDeepPage
        protected string NavButtonAStatus = "";
        protected string NavButtonBStatus = "";
        protected string NavButtonCStatus = "";
        protected string NavButtonDStatus = "";
        protected string NavButtonEStatus = "";

        // Panel Statuses: "", NavPanelStatusOnPanel, ""
        protected string NavPanelAStatus = "";
        protected string NavPanelBStatus = "";
        protected string NavPanelCStatus = "";
        protected string NavPanelDStatus = "";
        protected string NavPanelEStatus = "";

        // For BehindPanel
        private string globalNavButtonState = "Off";
        protected string BehindPanel = "none";
        private char CurrentButton = 'Z';

        protected void UpdateNavFromBehindPanel() =>
            UpdateNav(CurrentButton);
        public void UpdateNav(char buttonId)
        {
            CurrentButton = buttonId;
            switch (buttonId)
            {
                case 'A':
                    navButtonAState = ReadAndUpdateButtonState(navButtonAState);
                    globalNavButtonState = navButtonAState;
                    break;
                case 'B':
                    navButtonBState = ReadAndUpdateButtonState(navButtonBState);
                    globalNavButtonState = navButtonBState;
                    break;
                case 'C':
                    navButtonCState = ReadAndUpdateButtonState(navButtonCState);
                    globalNavButtonState = navButtonCState;
                    break;
                case 'D':
                    navButtonDState = ReadAndUpdateButtonState(navButtonDState);
                    globalNavButtonState = navButtonDState;
                    break;
                case 'E':
                    navButtonEState = ReadAndUpdateButtonState(navButtonEState);
                    globalNavButtonState = navButtonEState;
                    break;
            }
            UpdateButtonStatuses();
            UpdatePanelStatuses();
            UpdateBehindPanel();
        }
        private string ReadAndUpdateButtonState(string buttonState)
        {
            if (buttonState == "Off")
            {
                ResetButtonStates();
                return "OnPanel";
            }
            else if (buttonState == "OnPanel") 
                return "OnPage";
            else 
                return "OnPanel";
        }
        private void ResetButtonStates()
        {
            navButtonAState = "Off";
            navButtonBState = "Off";
            navButtonCState = "Off";
            navButtonDState = "Off";
            navButtonEState = "Off";   
        }
        private void UpdateButtonStatuses()
        {
            NavButtonAStatus = UpdateButtonStatus(navButtonAState);
            NavButtonBStatus = UpdateButtonStatus(navButtonBState);
            NavButtonCStatus = UpdateButtonStatus(navButtonCState);
            NavButtonDStatus = UpdateButtonStatus(navButtonDState);
            NavButtonEStatus = UpdateButtonStatus(navButtonEState);
        }
        private string UpdateButtonStatus(string buttonState)
        {
            if (buttonState == "Off")
                return "";
            else if (buttonState == "OnPanel")
                return "NavButtonStatusOnPanel";
            else
                return "NavButtonStatusOnPage";
        }
        private void UpdatePanelStatuses()
        {
            NavPanelAStatus = UpdatePanelStatus(navButtonAState);
            NavPanelBStatus = UpdatePanelStatus(navButtonBState);
            NavPanelCStatus = UpdatePanelStatus(navButtonCState);
            NavPanelDStatus = UpdatePanelStatus(navButtonDState);
            NavPanelEStatus = UpdatePanelStatus(navButtonEState);
        }
        private string UpdatePanelStatus(string buttonState)
        {
            if (buttonState == "OnPanel")
                return "NavPanelStatusOnPanel";
            else
                return "";
        }
        private void UpdateBehindPanel()
        {
            if (globalNavButtonState == "OnPanel")
                BehindPanel = "block";
            else
                BehindPanel = "none";
        }
    }
}
