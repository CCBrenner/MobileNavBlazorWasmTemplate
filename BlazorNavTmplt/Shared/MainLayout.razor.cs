namespace BlazorNavTmplt.Shared
{
    public partial class MainLayout
    {
        private bool buttonAIsOn = false;
        private bool buttonBIsOn = false;
        private bool buttonCIsOn = false;
        private bool buttonDIsOn = false;
        private bool buttonEIsOn = false;

        protected string NavButtonAStatus = "";
        protected string NavButtonBStatus = "";
        protected string NavButtonCStatus = "";
        protected string NavButtonDStatus = "";
        protected string NavButtonEStatus = "";

        protected string NavPanelAStatus = "";
        protected string NavPanelBStatus = "";
        protected string NavPanelCStatus = "";
        protected string NavPanelDStatus = "";
        protected string NavPanelEStatus = "";

        // For BehindPanel
        private bool globalNavButtonState = false;
        protected string BehindPanel = "";
        private char CurrentButton = 'Z';

        public string ContentBlur = "";

        public void UpdateNav(char buttonId)
        {
            CurrentButton = buttonId;
            switch (buttonId)
            {
                case 'A':
                    buttonAIsOn = UpdateButtonState(buttonAIsOn);
                    globalNavButtonState = buttonAIsOn;
                    break;
                case 'B':
                    buttonBIsOn = UpdateButtonState(buttonBIsOn);
                    globalNavButtonState = buttonBIsOn;
                    break;
                case 'C':
                    buttonCIsOn = UpdateButtonState(buttonCIsOn);
                    globalNavButtonState = buttonCIsOn;
                    break;
                case 'D':
                    buttonDIsOn = UpdateButtonState(buttonDIsOn);
                    globalNavButtonState = buttonDIsOn;
                    break;
                case 'E':
                    buttonEIsOn = UpdateButtonState(buttonEIsOn);
                    globalNavButtonState = buttonEIsOn;
                    break;
            }
            UpdateButtons();
            UpdatePanels();
            UpdateBehindPanel();
            UpdateContentBlur(globalNavButtonState);
        }
        private bool UpdateButtonState(bool buttonState)
        {
            if (buttonState)
                return false;
            else
            {
                TurnAllButtonsOff();
                return true;
            }
        }
        private void TurnAllButtonsOff()
        {
            buttonAIsOn = false;
            buttonBIsOn = false;
            buttonCIsOn = false;
            buttonDIsOn = false;
            buttonEIsOn = false;
        }
        private void UpdateButtons()
        {
            NavButtonAStatus = UpdateButton(buttonAIsOn);
            NavButtonBStatus = UpdateButton(buttonBIsOn);
            NavButtonCStatus = UpdateButton(buttonCIsOn);
            NavButtonDStatus = UpdateButton(buttonDIsOn);
            NavButtonEStatus = UpdateButton(buttonEIsOn);
        }
        private void UpdatePanels()
        {
            NavPanelAStatus = UpdatePanel(buttonAIsOn);
            NavPanelBStatus = UpdatePanel(buttonBIsOn);
            NavPanelCStatus = UpdatePanel(buttonCIsOn);
            NavPanelDStatus = UpdatePanel(buttonDIsOn);
            NavPanelEStatus = UpdatePanel(buttonEIsOn);
        }
        private void UpdateBehindPanel() =>
            BehindPanel = globalNavButtonState ? "button-on-show-behind-panel" : "";
        protected void UpdateNavFromBehindPanel() =>
            UpdateNav(CurrentButton);
        private string UpdateButton(bool buttonState) =>
            buttonState ? "button-on-highlight-button" : "";
        private string UpdatePanel(bool buttonState) =>
            buttonState ? "button-on-show-panel" : "";
        private string UpdateContentBlur(bool buttonState) =>
            ContentBlur = buttonState ? "content-blur" : "";
    }
}
