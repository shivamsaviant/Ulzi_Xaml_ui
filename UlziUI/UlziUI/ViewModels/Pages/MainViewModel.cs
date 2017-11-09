using System;
using System.Collections.Generic;
using System.Text;
using UlziUI.Classes;
using UlziUI.ViewModels.Panels;

using UlziUI.Views.Pages;
using Xamarin.Forms;

namespace UlziUI.ViewModels.Pages
{
    #region MainViewModel
    public class MainViewModel : UlziViewModel
    {
        private List<int> _statesStack = new List<int>();

        public MainViewModel() : base()
        {
            this.StartViewModel = new StartViewModel(this);
            this.LoginViewModel = new LoginViewModel(this);
        }

        protected override void DoPropertyChanged(string propertyName)
        {
            base.DoPropertyChanged(propertyName);
        }

        protected override void Localize()
        {
            base.Localize();

            if (this.StartViewModel != null)
            {
                this.StartViewModel.Localize();
                this.LoginViewModel.Localize();
            }
        }

        public override void Initialize(params object[] parameters)
        {
            base.Initialize(parameters);

            this.State = AppConstants.APP_PANEL_START;
            this.InitializePanel(parameters);
        }

        private void InitializePanel(params object[] parameters)
        {
            if (this.State == AppConstants.APP_PANEL_START)
                this.StartViewModel.Initialize(parameters);
            else if (this.State == AppConstants.APP_PANEL_LOGIN)
                this.LoginViewModel.Initialize(parameters);
        }

        private void BackPanel()
        {
            if (this.State == AppConstants.APP_PANEL_START)
                this.StartViewModel.Back();
            else if (this.State == AppConstants.APP_PANEL_LOGIN)
                this.LoginViewModel.Back();
        }

        public void PushPanel(int newState, params object[] parameters)
        {
            if (this.State != newState)
            {
                this.State = newState;
                this.InitializePanel(parameters);
            }
        }

        public void PopPanel()
        {
            var index = _statesStack.Count - 1;
            if (index >= 0)
            {
                var state = _statesStack[index];
                _statesStack.RemoveAt(index);
                this.State = state;
                this.BackPanel();
            }
        }

        public void PopToRootPanel()
        {
            if (_statesStack.Count > 0)
            {
                _statesStack.Clear();
                this.State = AppConstants.APP_PANEL_START;
                this.BackPanel();
            }
        }

        public int State
        {
            get { return (int)this.GetValue("State", (int)-1); }
            set
            {
                if (this.State != value)
                {
                    this.LastState = this.State;
                    this.SetValue("State", value);
                }
            }
        }

        public int LastState
        {
            get { return (int)this.GetValue("LastState", AppConstants.APP_PANEL_START); }
            set { this.SetValue("LastState", value); }
        }

        #region Panels
        public StartViewModel StartViewModel { get; private set; }

        public LoginViewModel LoginViewModel { get; private set; }
        #endregion

        #region Saviant Changes

        public ContentPage InitializePage(string PageURI)
        {
            switch (PageURI)
            {
                case AppConstants.APP_Page_Tab:
                    return new TabPage();
            }

            return null;
        }

        /// <summary>
        /// Added this method to push navigation page.
        /// </summary>
        /// <param name="PageURI"></param>
        public void PushPage(string PageURI)
        {
            (Application.Current.MainPage as NavigationPage).PushAsync(InitializePage(PageURI));
        }
        #endregion
    }
    #endregion
}
