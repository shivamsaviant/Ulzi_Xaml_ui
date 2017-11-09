using System;
using System.Collections.Generic;
using System.Text;
using UlziUI.Classes.AppLanguages;
using UlziUI.Classes.Enums;
using UlziUI.Controls;
using UlziUI.Views.Pages;
using Xamarin.Forms;

namespace UlziUI.Views.Panels
{
    #region StartPanel
    public class StartPanel : Panel
    {
        public StartPanel() : base()
        {
        }

        protected override View CreateContent()
        {
            var logoWidth = MainPage.PageWidth / 4.4366;
            var logoHeight = MainPage.PageHeight / 7.3297;
            var logoTopOffset = MainPage.PageHeight / 6.0636;

            var welcomeTextOffset = MainPage.PageHeight / 17.1026;

            var buttonsOffset = MainPage.PageHeight / 6.2925;

            var facebookSize = MainPage.PageHeight / 26.6800;
            var facebookHOffset = MainPage.PageWidth / 5.0000;

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
            welcome.SetBinding(AppLabel.TextProperty, new Binding("StartPanelWelcomeText", BindingMode.OneWay, null, null, null, AppLanguages.CurrentLanguage));

            var welcomeContent = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                Padding = new Thickness(0, welcomeTextOffset, 0, 0),
                Content = welcome
            };
            #endregion

            #region Buttons
            var logIn = new AppButton
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                WidthRequest = MainPage.PageWidth / 1.2458,
                HeightRequest = MainPage.PageHeight / 11.7018,
                FontSize = MainPage.PageHeight / 39.2353
            };
            logIn.SetBinding(AppButton.TextProperty, new Binding("StartPanelLogInButtonText", BindingMode.OneWay, null, null, null, AppLanguages.CurrentLanguage));
            logIn.SetBinding(AppButton.CommandProperty, "LogInCommand");

            var createAccount = new AppButton
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                WidthRequest = MainPage.PageWidth / 1.2458,
                HeightRequest = MainPage.PageHeight / 11.7018,
                FontSize = MainPage.PageHeight / 39.2353
            };
            createAccount.SetBinding(AppButton.TextProperty, new Binding("StartPanelCreateAccountButtonText", BindingMode.OneWay, null, null, null, AppLanguages.CurrentLanguage));
            createAccount.SetBinding(AppButton.CommandProperty, "CreateAccountCommand");

            var facebookLogin = new AppButton
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                AppButtonStyle = AppButtonStyles.Facebook,
                Image = "facebook_white",
                WidthRequest = MainPage.PageWidth / 1.2458,
                HeightRequest = MainPage.PageHeight / 11.7018,
                FontSize = MainPage.PageHeight / 39.2353
            };
            facebookLogin.SetBinding(AppButton.TextProperty, new Binding("StartPanelFacebookLoginButtonText", BindingMode.OneWay, null, null, null, AppLanguages.CurrentLanguage));
            facebookLogin.SetBinding(AppButton.CommandProperty, "FacebookLoginCommand");

            var buttons = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                Spacing = MainPage.PageHeight / 29,
                Padding = new Thickness(0, buttonsOffset, 0, 0)
            };
            buttons.Children.Add(logIn);
            buttons.Children.Add(createAccount);
            buttons.Children.Add(facebookLogin);
            #endregion

            var grid = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
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
            grid.Children.Add(buttons, 0, 2);

            return grid;
        }
    }
    #endregion
}
