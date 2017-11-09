using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UlziUI.Classes;
using UlziUI.Classes.AppLanguages;
using UlziUI.Classes.Converters;
using UlziUI.Controls;
using UlziUI.ViewModels.Pages;
using UlziUI.Views.Panels;
using Xamarin.Forms;

namespace UlziUI.Views.Pages
{
    #region MainPage
    public class MainPage : CurrentPage
    {
        #region Static members
        public static readonly BindableProperty StateProperty = BindableProperty.Create("State", typeof(int), typeof(MainPage), -1);

        public static double PageHeight = 0;
        public static double PageWidth = 0;
        #endregion

        private View _startPanel = null;
        private View _loginPanel = null;

        private IndexToBoolConverter _indexToBoolConverter = new IndexToBoolConverter();

        private bool _firstAppering = true;

        public MainPage() : base()
        {
            this.BindingContext = new MainViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (_firstAppering)
            {
                this.ViewModel.Initialize();
                _firstAppering = false;
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == "State")
            {
                Console.WriteLine("Work panel state: {0}", this.State);
            }
        }

        protected override View CreateContent()
        {
            MainPage.PageWidth = this.Width;
            MainPage.PageHeight = this.Height;

            var image = new Image
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                Source = "background",
                Aspect = Aspect.Fill
            };

            this.CreateStartPanel();
            this.CreateLoginPanel();

            var grid = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                RowSpacing = 0,
                ColumnSpacing = 0
            };
            grid.Children.Add(image);
            grid.Children.Add(_startPanel);
            grid.Children.Add(_loginPanel);

            this.SetBinding(MainPage.StateProperty, "State", BindingMode.TwoWay);

            return grid;
        }

        #region Panels
        private void CreateStartPanel()
        {
            var startPanel = new StartPanel();
            startPanel.SetBinding(StartPanel.BindingContextProperty, "StartViewModel");
            startPanel.SetBinding(StartPanel.IsVisibleProperty, new Binding("State", BindingMode.OneWay, _indexToBoolConverter, AppConstants.APP_PANEL_START, null, this));

            //var homeSearchPanel = new HomeSearchPanel();
            //homeSearchPanel.SetBinding(HomeSearchPanel.BindingContextProperty, "HomeSearchViewModel");
            _startPanel = startPanel;
        }

        private void CreateLoginPanel()
        {
            var loginPanel = new LoginPanel();
            loginPanel.SetBinding(LoginPanel.BindingContextProperty, "LoginViewModel");
            loginPanel.SetBinding(LoginPanel.IsVisibleProperty, new Binding("State", BindingMode.OneWay, _indexToBoolConverter, AppConstants.APP_PANEL_LOGIN, null, this));

            _loginPanel = loginPanel;
        }
        #endregion

        public int State
        {
            get { return (int)this.GetValue(StateProperty); }
            set { this.SetValue(StateProperty, value); }
        }

        public new MainViewModel ViewModel
        {
            get { return (this.BindingContext as MainViewModel); }
        }
    }
    #endregion
}
