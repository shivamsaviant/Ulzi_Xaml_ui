using System;
using System.Collections.Generic;

using Xamarin.Forms;
using UlziUI.ViewModels.Pages;
using UlziUI.Views.Panels;

namespace UlziUI.Views.Pages
{
    /// <summary>
    /// Tabpage 
    /// This page will work as the container page for the panels
    /// </summary>
    public partial class TabPage : CurrentPage
    {
        public TabPage()
        {
            InitializeComponent();
            this.BindingContext = new TabPageViewModel();

        }
    }
}
