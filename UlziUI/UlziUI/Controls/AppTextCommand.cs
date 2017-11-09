using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppTextCommand
    public class AppTextCommand : AppLabel
    {
        #region Static members
        public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(AppTextCommand), null);
        public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create("CommandParameter", typeof(object), typeof(AppTextCommand), null);
        #endregion

        public AppTextCommand() : base()
        {
            var touchGesture = new TapGestureRecognizer();
            touchGesture.Tapped += (sender, args) => {
                if ((this.Command != null) && (this.Command.CanExecute(this.CommandParameter)))
                {
                    this.FadeTo(0.6);
                    this.FadeTo(1);
                    this.Command.Execute(CommandParameter);
                }
            };
            this.GestureRecognizers.Add(touchGesture);
        }

        public ICommand Command
        {
            get { return (ICommand)this.GetValue(CommandProperty); }
            set { this.SetValue(CommandProperty, value); }
        }

        public object CommandParameter
        {
            get { return (object)this.GetValue(CommandParameterProperty); }
            set { this.SetValue(CommandParameterProperty, value); }
        }
    }
    #endregion
}
