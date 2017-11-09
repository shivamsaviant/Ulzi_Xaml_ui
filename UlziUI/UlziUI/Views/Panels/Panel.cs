using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UlziUI.Classes.Extensions;
using UlziUI.Classes.Messages;
using UlziUI.ViewModels.Panels;
using UlziUI.Views.Pages;
using Xamarin.Forms;

namespace UlziUI.Views.Panels
{
    #region Panel
    public class Panel : ContentView
    {
        #region Static members
        public static async Task DelayActionAsync(int delay, Action action)
        {
            await Task.Delay(delay);
            action();
        }
        #endregion

        private View _content = null;

        public Panel() : base()
        {
            this.ID = Guid.NewGuid();

            this.HorizontalOptions = LayoutOptions.Fill;
            this.VerticalOptions = LayoutOptions.Fill;

            var grid = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                RowSpacing = 0,
                ColumnSpacing = 0
            };

            this.SizeChanged += (sender, args) =>
            {
                if (_content == null)
                    try
                    {
                        _content = this.CreateContent();

                        if (_content != null)
                            grid.Children.Add(_content);
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine("Create panel content: " + exception.Message);
                        ShowToastMessage.Send(exception.Message);
                    }
            };

            this.Content = grid;

            //this.BuildContent();
        }

        protected View CreateEmpty(Color backgroundColor)
        {
            var emptySize = (int)Math.Round(MainPage.PageWidth * 0.2400);

            var contentView = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                HeightRequest = emptySize,
                BackgroundColor = backgroundColor
            };

            return contentView;
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == "IsVisible")
            {
                this.AddContent();
                if (this.IsVisible)
                    this.Enter();
                else
                    this.Leave();
            }
        }

        private void BuildContent()
        {
            Task.Run(() => {
                try
                {
                    _content = this.CreateContent();
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Create panel content: " + exception.Message);
                    ShowToastMessage.Send(exception.Message);
                }
            }).LogExceptions("Panel BuildContent");
        }

        protected void AddContent()
        {
            if ((this.IsVisible) && (_content != null) && (this.Content == null))
                Device.BeginInvokeOnMainThread(() => {
                    this.Content = _content;
                    Console.WriteLine("{0}: Added to View", this);
                });
        }

        protected virtual View CreateContent()
        {
            return null;
        }

        protected virtual void Enter()
        {
        }

        protected virtual void Leave()
        {
        }

        public Guid ID { get; private set; }

        public PanelViewModel ViewModel
        {
            get { return (this.BindingContext as PanelViewModel); }
        }
    }
    #endregion
}
