using System;
using System.Collections.Generic;
using System.Text;
using UlziUI.Classes;
using UlziUI.Classes.AppLanguages;
using UlziUI.ViewModels.Pages;

namespace UlziUI.ViewModels.Panels
{
    #region LoginViewModel
    public class LoginViewModel : PanelViewModel
    {
        public LoginViewModel(MainViewModel mainViewModel) : base(mainViewModel)
        {
            this.ForgotCommand = new VisualCommand(this.Forgot);
            this.LogInCommand = new VisualCommand(this.Login);
            this.SignUpCommand = new VisualCommand(this.SignUp);

            this.EnableCommands();
        }

        protected override void DoPropertyChanged(string propertyName)
        {
            if ((propertyName == "Email") ||
                (propertyName == "Password"))
                this.EnableCommands();

            base.DoPropertyChanged(propertyName);
        }

        private void DisableCommands()
        {
            this.ForgotCommand.IsEnabled = false;
            this.LogInCommand.IsEnabled = false;
            this.SignUpCommand.IsEnabled = false;
        }

        private void EnableCommands()
        {
            this.ForgotCommand.IsEnabled = true;
            this.LogInCommand.IsEnabled = ((!String.IsNullOrEmpty(this.Email)) && (!String.IsNullOrEmpty(this.Password)));
            this.SignUpCommand.IsEnabled = true;
        }

        private void SetError(bool isError)
        {
            this.IsErrorEmail =
                this.IsErrorPassword =
                this.IsError = isError;
        }

        private void Forgot(object parameter)
        {
        }

        private void Login(object parameter)
        {
            MainViewModel.PushPage(AppConstants.APP_Page_Tab);
        }

        private void SignUp(object parameter)
        {
        }

        public string Email
        {
            get { return (string)this.GetValue("Email"); }
            set { this.SetValue("Email", value); }
        }

        public string Password
        {
            get { return (string)this.GetValue("Password"); }
            set { this.SetValue("Password", value); }
        }

        public string ErrorText
        {
            get { return (string)this.GetValue("ErrorText", AppLanguages.CurrentLanguage.LoginPanelErrorText); }
            set { this.SetValue("ErrorText", value); }
        }

        public bool IsErrorEmail
        {
            get { return (bool)this.GetValue("IsErrorEmail", false); }
            set { this.SetValue("IsErrorEmail", value); }
        }

        public bool IsErrorPassword
        {
            get { return (bool)this.GetValue("IsErrorPassword", false); }
            set { this.SetValue("IsErrorPassword", value); }
        }

        public bool IsError
        {
            get { return (bool)this.GetValue("IsError", false); }
            set { this.SetValue("IsError", value); }
        }

        public VisualCommand ForgotCommand { get; private set; }

        public VisualCommand LogInCommand { get; private set; }

        public VisualCommand SignUpCommand { get; private set; }
    }
    #endregion
}
