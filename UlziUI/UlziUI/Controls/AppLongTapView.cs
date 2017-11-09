using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppLongTapView
    public class AppLongTapView : View
    {
        #region Static members
        public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(AppLongTapView), null);
        public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create("CommandProperty", typeof(object), typeof(AppLongTapView), null);
        #endregion

        public AppLongTapView() : base()
        {
        }

        public ICommand Command
        {
            get { return (ICommand)this.GetValue(CommandProperty); }
            set { this.SetValue(CommandProperty, value); }
        }

        public object CommandParameter
        {
            get { return this.GetValue(CommandParameterProperty); }
            set { this.SetValue(CommandParameterProperty, value); }
        }
    }
    #endregion
}
