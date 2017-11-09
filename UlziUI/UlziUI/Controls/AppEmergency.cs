using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppEmergency
    public class AppEmergency : Image
    {
        #region Static members
        public static readonly BindableProperty StartedCommandProperty = BindableProperty.Create("StartedCommand", typeof(ICommand), typeof(AppEmergency), null);
        public static readonly BindableProperty RunningCommandProperty = BindableProperty.Create("RunningCommand", typeof(ICommand), typeof(AppEmergency), null);
        public static readonly BindableProperty CompletedCommandProperty = BindableProperty.Create("CompletedCommand", typeof(ICommand), typeof(AppEmergency), null);
        public static readonly BindableProperty CanceledCommandProperty = BindableProperty.Create("CanceledCommand", typeof(ICommand), typeof(AppEmergency), null);
        public static readonly BindableProperty EmergencyCommandProperty = BindableProperty.Create("EmergencyCommand", typeof(ICommand), typeof(AppEmergency), null);
        public static readonly BindableProperty RedRegionProperty = BindableProperty.Create("RedRegion", typeof(Rectangle), typeof(AppEmergency), Rectangle.Zero);
        public static readonly BindableProperty YellowRegionProperty = BindableProperty.Create("YellowRegion", typeof(Rectangle), typeof(AppEmergency), Rectangle.Zero);
        #endregion

        private Rectangle _startRect = Rectangle.Zero;
        private Rectangle _lastRect = Rectangle.Zero;

        private bool _isStarted = false;

        public AppEmergency() : base()
        {
        }

        public void DoStarted()
        {
            _isStarted = false;

            if ((this.StartedCommand != null) && (this.StartedCommand.CanExecute(null)))
                this.StartedCommand.Execute(null);

            _startRect = this.Bounds;
            _lastRect = _startRect;

            Console.WriteLine("Position => {0}, {1}", _lastRect.X, _lastRect.Y);
        }

        public void DoRunning(double deltaX, double deltaY)
        {
            _isStarted = true;

            if ((this.RunningCommand != null) && (this.RunningCommand.CanExecute(null)))
                this.RunningCommand.Execute(null);

            var newRect = new Rectangle(_lastRect.X + deltaX, _lastRect.Y + deltaY, _startRect.Width, _startRect.Height);

            this.Layout(newRect);

            _lastRect = newRect;

            Console.WriteLine("Position => {0}, {1}", _lastRect.X, _lastRect.Y);
        }

        public void DoCompleted()
        {
            if ((this.CompletedCommand != null) && (this.CompletedCommand.CanExecute(null)))
                this.CompletedCommand.Execute(null);

            if (this.CheckRedRegion())
                this.Emergency(true);
            else if (this.CheckYellowRegion())
                this.Emergency(false);

            this.RestoreStartPosition();
        }

        public void DoCanceled()
        {
            if ((this.CanceledCommand != null) && (this.CanceledCommand.CanExecute(null)))
                this.CanceledCommand.Execute(null);

            this.RestoreStartPosition();
        }

        private void RestoreStartPosition()
        {
            Device.BeginInvokeOnMainThread(async () => {
                await this.LayoutTo(_startRect);
            });
        }

        private void Emergency(bool isRed)
        {
            if ((this.EmergencyCommand != null) && (this.EmergencyCommand.CanExecute(isRed)))
                this.EmergencyCommand.Execute(isRed);
        }

        private bool CheckRedRegion()
        {
            return this.CheckRegion(this.RedRegion);
        }

        private bool CheckYellowRegion()
        {
            return this.CheckRegion(this.YellowRegion);
        }

        private bool CheckRegion(Rectangle region)
        {
            var result = false;
            if (!Rectangle.Zero.Equals(region))
            {
                var thisCenter = this.Bounds.Center;
                var regionCenter = region.Center;

                var deltaX = regionCenter.X - thisCenter.X;
                var deltaY = regionCenter.Y - thisCenter.Y;

                var distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

                result = (distance <= region.Width / 2);
            }
            return result;
        }

        public ICommand StartedCommand
        {
            get { return (ICommand)this.GetValue(StartedCommandProperty); }
            set { this.SetValue(StartedCommandProperty, value); }
        }

        public ICommand RunningCommand
        {
            get { return (ICommand)this.GetValue(RunningCommandProperty); }
            set { this.SetValue(RunningCommandProperty, value); }
        }

        public ICommand CompletedCommand
        {
            get { return (ICommand)this.GetValue(CompletedCommandProperty); }
            set { this.SetValue(CompletedCommandProperty, value); }
        }

        public ICommand CanceledCommand
        {
            get { return (ICommand)this.GetValue(CanceledCommandProperty); }
            set { this.SetValue(CanceledCommandProperty, value); }
        }

        public ICommand EmergencyCommand
        {
            get { return (ICommand)this.GetValue(EmergencyCommandProperty); }
            set { this.SetValue(EmergencyCommandProperty, value); }
        }

        public Rectangle RedRegion
        {
            get { return (Rectangle)this.GetValue(RedRegionProperty); }
            set { this.SetValue(RedRegionProperty, value); }
        }

        public Rectangle YellowRegion
        {
            get { return (Rectangle)this.GetValue(YellowRegionProperty); }
            set { this.SetValue(YellowRegionProperty, value); }
        }
    }
    #endregion
}
