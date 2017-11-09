using System;
using System.Collections.Generic;
using System.Text;
using UlziUI.Classes;
using UlziUI.ViewModels.Pages;

namespace UlziUI.ViewModels.Panels
{
    #region PanelViewModel
    public class PanelViewModel : BaseViewModel
    {
        public PanelViewModel(MainViewModel mainViewModel) : base("", "")
        {
            this.MainViewModel = mainViewModel;
        }

        public virtual void Localize()
        {
        }

        public MainViewModel MainViewModel { get; private set; }
    }
    #endregion
}
