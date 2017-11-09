using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UlziUI.Classes.AppLanguages;
using UlziUI.Classes.Enums;
using UlziUI.Controls;
using UlziUI.Views.Pages;
using Xamarin.Forms;

namespace UlziUI.Views.Panels
{
    #region LoginPanel
    public class LoginPanel : Panel
    {
        private AppEntryEditor _email = null;
        private AppEntryEditor _password = null;
        private AppButton _logIn = null;

        private ScrollView _scroll = null;

        public LoginPanel() : base()
        {
        }

        protected override async void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if ((propertyName == IsVisibleProperty.PropertyName) && (this.IsVisible))
                await this.ScrollToUp();
        }

        private async Task ScrollToUp()
        {
            if (_scroll != null)
                await Panel.DelayActionAsync(100, () => { _scroll.ScrollToAsync(0, 0, true); });
        }

        protected override View CreateContent()
        {
            var logoWidth = MainPage.PageWidth / 4.4366;
            var logoHeight = MainPage.PageHeight / 7.3297;
            var logoTopOffset = MainPage.PageHeight / 6.0636;

            var welcomeTextOffset = MainPage.PageHeight / 17.1026;

            var emailHeight = MainPage.PageHeight / 7.0211;
            var passwordHeight = MainPage.PageHeight / 8.2346;

            var errorHeight = MainPage.PageHeight / 12.5849;
            var errorBottomOffset = MainPage.PageHeight / 60.6363;
            var forgotTopOffset = MainPage.PageHeight / 95.2857;
            var signUpTopOffset = MainPage.PageHeight / 11.9107;

            var textFontSize = MainPage.PageHeight / 60.6364;
            var entryFontSize = MainPage.PageHeight / 39.2353;
            var signUpFontSize = MainPage.PageHeight / 55.5833;
            var horizontalPadding = MainPage.PageWidth / 7.8125;

            var color = Color.White;
            var placeholderColor = Color.White;
            var errorColor = Color.White; // Color.FromHex("#E27A73");
            var commandColor = Color.FromHex("#61A8A1");

            var imageSize = MainPage.PageWidth / 17.0455;
            var imageOffset = imageSize / 2;

            #region Logo
            var logo = new Image
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                WidthRequest = logoWidth,
                HeightRequest = logoHeight,
                Source = "logo"
            };

            var logoContent = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                Padding = new Thickness(0, logoTopOffset, 0, 0),
                Content = logo
            };
            #endregion

            #region Welcome
            var welcome = new AppLabel
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                AppFont = AppFonts.Quicksand,
                FontSize = MainPage.PageHeight / 39.2353,
                TextColor = Color.White
            };
            welcome.SetBinding(AppLabel.TextProperty, new Binding("LoginPanelWelcomeText", BindingMode.OneWay, null, null, null, AppLanguages.CurrentLanguage));

            var welcomeContent = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                Padding = new Thickness(0, welcomeTextOffset, 0, 0),
                Content = welcome
            };
            #endregion

            #region Сontent
            #region Email
            _email = new AppEntryEditor
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                HeightRequest = emailHeight,
                AppFont = AppFonts.Quicksand,
                FontSize = entryFontSize,
                TextColor = color,
                ErrorTextColor = errorColor,
                PlaceholderColor = placeholderColor,
                ImageSource = "email_white",
                ErrorImageSource = "email_red",
                ImageSize = imageSize,
                ImageOffset = imageOffset,
                Keyboard = Keyboard.Email
            };
            _email.SetBinding(AppEntryEditor.TextProperty, "Email", BindingMode.TwoWay);
            _email.SetBinding(AppEntryEditor.PlaceholderProperty, new Binding("LoginPanelEmailPlaceholderText", BindingMode.OneWay, null, null, null, AppLanguages.CurrentLanguage));
            _email.SetBinding(AppEntryEditor.IsErrorProperty, "IsErrorEmail");
            #endregion

            #region Password
            _password = new AppEntryEditor
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                HeightRequest = passwordHeight,
                AppFont = AppFonts.Quicksand,
                FontSize = entryFontSize,
                TextColor = color,
                ErrorTextColor = errorColor,
                PlaceholderColor = placeholderColor,
                ImageSource = "lock_white",
                ErrorImageSource = "lock_red",
                ImageSize = imageSize,
                ImageOffset = imageOffset,
                Keyboard = Keyboard.Default,
                IsPassword = true
            };
            _password.SetBinding(AppEntryEditor.TextProperty, "Password", BindingMode.TwoWay);
            _password.SetBinding(AppEntryEditor.PlaceholderProperty, new Binding("LoginPanelPasswordPlaceholderText", BindingMode.OneWay, null, null, null, AppLanguages.CurrentLanguage));
            _password.SetBinding(AppEntryEditor.IsErrorProperty, "IsErrorPassword");
            #endregion

            #region Error
            var error = new AppLabel
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End,
                HorizontalTextAlignment = TextAlignment.Center,
                AppFont = AppFonts.Quicksand,
                FontSize = MainPage.PageHeight / 39.2353,
                TextColor = errorColor
            };
            error.SetBinding(AppLabel.TextProperty, "ErrorText");
            error.SetBinding(AppLabel.IsVisibleProperty, "IsError");

            var errorContent = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                HeightRequest = errorHeight,
                Padding = new Thickness(0, 0, 0, errorBottomOffset),
                Content = error
            };
            #endregion

            #region LogIn
            _logIn = new AppButton
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                WidthRequest = MainPage.PageWidth / 1.2458,
                HeightRequest = MainPage.PageHeight / 11.7018,
                FontSize = MainPage.PageHeight / 39.2353
            };
            _logIn.SetBinding(AppButton.TextProperty, new Binding("LoginPanelLogInButtonText", BindingMode.OneWay, null, null, null, AppLanguages.CurrentLanguage));
            _logIn.SetBinding(AppButton.CommandProperty, "LogInCommand");

            var logInContent = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                Content = _logIn
            };
            #endregion

            #region Forgot Password
            var forgot = new AppCommand
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                AppFont = AppFonts.Quicksand,
                IsUnderline = true,
                FontSize = 14,
                TextColor = commandColor,
                DisableTextColor = commandColor
            };
            forgot.SetBinding(AppCommand.TextProperty, new Binding("LoginPanelForgotCommandText", BindingMode.OneWay, null, null, null, AppLanguages.CurrentLanguage));
            forgot.SetBinding(AppCommand.CommandProperty, "ForgotCommand");

            var forgotContent = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                Padding = new Thickness(0, forgotTopOffset, 0, 0),
                Content = forgot
            };
            #endregion

            #region SignUp
            var signUp = new AppCommand
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                AppFont = AppFonts.Quicksand,
                IsUnderline = true,
                FontSize = 14,
                TextColor = commandColor,
                DisableTextColor = commandColor
            };
            signUp.SetBinding(AppCommand.TextProperty, new Binding("LoginPanelSignUpCommandText", BindingMode.OneWay, null, null, null, AppLanguages.CurrentLanguage));
            signUp.SetBinding(AppCommand.CommandProperty, "SignUpCommand");

            var signUpContent = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                Padding = new Thickness(0, signUpTopOffset, 0, 0),
                Content = signUp
            };
            #endregion

            var content = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                Padding = new Thickness(horizontalPadding, 0, horizontalPadding, 0),
                RowSpacing = 0,
                ColumnSpacing = 0,
                RowDefinitions = {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) }
                }
            };
            content.Children.Add(_email, 0, 0);
            content.Children.Add(_password, 0, 1);
            content.Children.Add(errorContent, 0, 2);
            content.Children.Add(logInContent, 0, 3);
            content.Children.Add(forgotContent, 0, 4);
            content.Children.Add(signUpContent, 0, 5);
            #endregion

            var grid = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                RowSpacing = 0,
                ColumnSpacing = 0,
                RowDefinitions = {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) }
                }
            };
            grid.Children.Add(logoContent, 0, 0);
            grid.Children.Add(welcomeContent, 0, 1);
            grid.Children.Add(content, 0, 2);

            _email.Completed += (sender, args) => {
                _password.SetFocus();
            };

            _password.Completed += (sender, args) => {
                if ((_logIn.Command != null) && (_logIn.Command.CanExecute(_logIn.CommandParameter)))
                    _logIn.Command.Execute(_logIn.CommandParameter);
            };

            _scroll = new ScrollView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                Content = grid
            };

            return _scroll;
        }
    }
    #endregion
}
