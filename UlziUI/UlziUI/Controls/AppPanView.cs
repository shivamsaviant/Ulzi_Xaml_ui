using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppPanViewEvent
    public enum AppPanViewEvent
    {
        None,
        Start,
        Move,
        Complete
    }
    #endregion

    #region AppPanViewEventArgs
    public class AppPanViewEventArgs : EventArgs
    {
        public AppPanViewEventArgs(AppPanViewEvent ev, double x, double y)
        {
            this.Event = ev;
            this.X = x;
            this.Y = y;
        }

        public AppPanViewEvent Event { get; private set; }

        public double X { get; private set; }

        public double Y { get; private set; }
    }
    #endregion

    #region AppPanViewEventHandler
    public delegate void AppPanViewEventHandler(object sender, AppPanViewEventArgs args);
    #endregion

    #region AppPanView
    public class AppPanView : View
    {
        public AppPanView() : base()
        {
        }

        public void DoPanEvent(AppPanViewEventArgs args)
        {
            if (this.OnPanEvent != null)
                this.OnPanEvent(this, args);
        }

        public event AppPanViewEventHandler OnPanEvent;
    }
    #endregion
}
