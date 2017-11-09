using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Input;
using UlziUI.Classes.Enums;
using Xamarin.Forms;
using UlziUI.Effects;

namespace UlziUI.Controls
{
    #region AppLabel
    public class AppLabel : Label
    {
        #region Static members
        private static int _defaultLineSetting = -1;
        public static readonly BindableProperty LinesProperty = BindableProperty.Create(nameof(Lines), typeof(int), typeof(AppLabel), _defaultLineSetting); // This is for Number of lines to be shown in Label
        public static readonly BindableProperty AppFontProperty = BindableProperty.Create("AppFont", typeof(AppFonts), typeof(AppLabel), AppFonts.Quicksand);
        public static readonly BindableProperty HtmlTextProperty = BindableProperty.Create("HtmlText", typeof(string), typeof(AppLabel), default(string));
        public static readonly BindableProperty IsUnderlineProperty = BindableProperty.Create("IsUnderline", typeof(bool), typeof(AppLabel), default(bool));
        public static readonly BindableProperty NavigateUriProperty = BindableProperty.Create("NavigateUri", typeof(string), typeof(AppLabel), string.Empty, BindingMode.OneWay, null, null, null, null); //CakeSoft fixed bug SB-17
        public static readonly BindableProperty NavigateCommandProperty = BindableProperty.Create("NavigateCommand", typeof(ICommand), typeof(AppLabel), null, BindingMode.OneWay, null, null, null, null);
        #endregion

        private TapGestureRecognizer _tapGestureRecognizer;

        public AppLabel() : base()
        {
            this.UpdateIsUnderline();
            this.clickOnLink();
        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == IsUnderlineProperty.PropertyName)
                this.UpdateIsUnderline();
            else if (propertyName == "NavigateCommand")
            {
                this.GestureRecognizers.Remove(_tapGestureRecognizer);
                _tapGestureRecognizer = new TapGestureRecognizer() { Command = NavigateCommand };
                GestureRecognizers.Add(_tapGestureRecognizer);
            }
        }

        private void UpdateIsUnderline()
        {
            if (this.IsUnderline)
                this.Effects.Add(new UnderlineEffect());
            else
            {
                var effect = this.Effects.FirstOrDefault(e => e is UnderlineEffect);
                if (effect != null)
                    this.Effects.Remove(effect);
            }
        }

        private void clickOnLink()
        {
            NavigateCommand = new Command(() =>
            {
                if (!String.IsNullOrEmpty(NavigateUri))
                {
                    Device.OpenUri(new Uri(NavigateUri));
                }
            });

            _tapGestureRecognizer = new TapGestureRecognizer() { Command = NavigateCommand };

            GestureRecognizers.Add(_tapGestureRecognizer);
        }

        public string NavigateUri
        {
            get { return (string)base.GetValue(NavigateUriProperty); }
            set { base.SetValue(NavigateUriProperty, value); }
        }

        public int Lines
        {
            get { return (int)GetValue(LinesProperty); }
            set { SetValue(LinesProperty, value); }
        }

        public AppFonts AppFont
        {
            get { return (AppFonts)this.GetValue(AppFontProperty); }
            set { this.SetValue(AppFontProperty, value); }
        }

        public string HtmlText
        {
            get { return (string)this.GetValue(HtmlTextProperty); }
            set { this.SetValue(HtmlTextProperty, value); }
        }

        public bool IsUnderline
        {
            get { return (bool)this.GetValue(IsUnderlineProperty); }
            set { this.SetValue(IsUnderlineProperty, value); }
        }

        public ICommand NavigateCommand
        {
            get { return (ICommand)base.GetValue(NavigateCommandProperty); }
            set { base.SetValue(NavigateCommandProperty, value); }
        }
    }
    #endregion
}
