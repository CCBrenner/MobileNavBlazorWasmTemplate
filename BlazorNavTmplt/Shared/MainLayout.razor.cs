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

        public bool FirstAnimationIsContinuous = false;
        public bool SecondAnimationIsContinuous = false;
        public bool ThirdAnimationIsContinuous = false;
        public bool FourthAnimationIsContinuous = false;
        public bool FifthAnimationIsContinuous = false;

        public string LayoutControls = "";
        public string AnimateMain = "";
        public string DiscontinueButton = "";

        public bool ExternalLayoutControls = false;

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

        public void PlayFirstAnimation(bool isContinuous)
        {
            if (isContinuous)
            {
                AnimateMain = "main1-infinite";
                DiscontinueButton = "discontinue-button-on";
            }
            else
            {
                if (AnimateMain == "main1")
                    AnimateMain = "";
                else
                    AnimateMain = "main1";
            }
        }
        public void PlaySecondAnimation(bool isContinuous)
        {
            if (isContinuous)
            {
                AnimateMain = "main2-infinite";
                DiscontinueButton = "discontinue-button-on";
            }
            else
            {
                if (AnimateMain == "main2")
                    AnimateMain = "";
                else
                    AnimateMain = "main2";
            }
        }
        public void PlayThirdAnimation(bool isContinuous)
        {
            if (isContinuous)
            {
                AnimateMain = "main3-infinite";
                DiscontinueButton = "discontinue-button-on";
            }
            else
            {
                if (AnimateMain == "main3")
                    AnimateMain = "";
                else
                    AnimateMain = "main3";
            }
        }
        public void PlayFourthAnimation(bool isContinuous)
        {
            if (isContinuous)
            {
                AnimateMain = "main4-infinite";
                DiscontinueButton = "discontinue-button-on";
            }
            else
            {
                if (AnimateMain == "main4")
                    AnimateMain = "";
                else
                    AnimateMain = "main4";
            }
        }
        public void PlayFifthAnimation(bool isContinuous)
        {
            if (isContinuous)
            {
                AnimateMain = "main5-infinite";
                DiscontinueButton = "discontinue-button-on";
            }
            else
            {
                if (AnimateMain == "main5")
                    AnimateMain = "";
                else 
                    AnimateMain = "main5";
            }
        }
        public void StopMainAnimation()
        {
            AnimateMain = "";
            DiscontinueButton = "";
        }
        public void ShowLayoutControls(char character)
        {
            UpdateNav(character);
            LayoutControls = "layout-controls-on";
        }
        public void UpdateNavFromRoute(char character)
        {
            LayoutControls = "";
            AnimateMain = "";
            UpdateNav(character);
        }
        public void SetExternalLayoutControlsToTrue() =>
            ExternalLayoutControls = true;
    }
}
