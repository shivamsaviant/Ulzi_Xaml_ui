using System;
using System.Collections.Generic;
using System.Text;
using UlziUI.Classes;
using UlziUI.ViewModels.Pages;

namespace UlziUI.ViewModels.Panels
{
    #region StartViewModel
    public class StartViewModel : PanelViewModel
    {
        public StartViewModel(MainViewModel mainViewModel) : base(mainViewModel)
        {
            this.LogInCommand = new VisualCommand(this.LogIn);
            this.CreateAccountCommand = new VisualCommand(this.CreateAccount);
            this.FacebookLoginCommand = new VisualCommand(this.FacebookLogin);
        }

        private void EnableCommands()
        {
            this.LogInCommand.IsEnabled =
                this.CreateAccountCommand.IsEnabled =
                this.FacebookLoginCommand.IsEnabled = true;
        }

        private void DisableCommands()
        {
            this.LogInCommand.IsEnabled =
                this.CreateAccountCommand.IsEnabled =
                this.FacebookLoginCommand.IsEnabled = false;
        }

        private void LogIn(object parameter)
        {
            this.MainViewModel.PushPanel(AppConstants.APP_PANEL_LOGIN);
        }

        private void CreateAccount(object parameter)
        {
        }

        private void FacebookLogin(object parameter)
        {
        }

        public VisualCommand LogInCommand { get; private set; }

        public VisualCommand CreateAccountCommand { get; private set; }

        public VisualCommand FacebookLoginCommand { get; private set; }
    }
    #endregion
}
