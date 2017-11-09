using System;
using System.Collections.Generic;
using System.Text;
using UlziUI.Classes;
using UlziUI.Classes.AppLanguages;
using UlziUI.Classes.Messages;

namespace UlziUI.ViewModels.Pages
{
    #region UlziViewModel
    public class UlziViewModel : BaseViewModel
    {
        public UlziViewModel() : base("", "")
        {
            this.Localize();
        }

        public override void Appering()
        {
            base.Appering();

            LanguageSelectedMessage.Subscribe(this, this.LanguageSelected);
        }

        public override void Disappering()
        {
            base.Disappering();

            LanguageSelectedMessage.Unsubscribe(this);
        }

        private void LanguageSelected(LanguageSelectedMessage message)
        {
            this.Localize();
        }

        protected override void DoPropertyChanged(string propertyName)
        {
            if (propertyName == "IsBusy")
                this.SetCommandsState();

            base.DoPropertyChanged(propertyName);
        }

        private void SetCommandsState()
        {
            if (this.IsBusy)
                this.DisableCommands();
            else
                this.EnabledCommands();
        }

        protected virtual void Localize()
        {
            this.Title = AppLanguages.CurrentLanguage.AppName;
        }

        protected virtual void DisableCommands()
        {
        }

        protected virtual void EnabledCommands()
        {
        }
    }
    #endregion
}
