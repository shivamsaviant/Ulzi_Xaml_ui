using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppImage
    public class AppImage : Image
    {
        #region Static members
        public static readonly BindableProperty ImageUriProperty = BindableProperty.Create("ImageUri", typeof(string), typeof(AppImage), default(string));
        public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(AppImage), null);
        public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create("CommandParameter", typeof(object), typeof(AppImage), null);
        public static readonly BindableProperty StrokeWidthProperty = BindableProperty.Create("StrokeWidth", typeof(double), typeof(AppImage), (double)0);
        public static readonly BindableProperty StrokeColorProperty = BindableProperty.Create("StrokeColor", typeof(Color), typeof(AppImage), Color.White);
        #endregion

        public AppImage() : base()
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

        public string ImageUri
        {
            get { return (string)this.GetValue(ImageUriProperty); }
            set { this.SetValue(ImageUriProperty, value); }
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

        public double StrokeWidth
        {
            get { return (double)this.GetValue(StrokeWidthProperty); }
            set { this.SetValue(StrokeWidthProperty, value); }
        }

        public Color StrokeColor
        {
            get { return (Color)this.GetValue(StrokeColorProperty); }
            set { this.SetValue(StrokeColorProperty, value); }
        }
    }
    #endregion
}
