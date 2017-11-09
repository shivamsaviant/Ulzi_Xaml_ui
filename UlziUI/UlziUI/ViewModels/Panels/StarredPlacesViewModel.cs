using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using UlziUI.Classes.Models;
using UlziUI.ViewModels.Pages;

namespace UlziUI.ViewModels.Panels
{
    public class StarredPlacesViewModel : PanelViewModel
    {
        private ObservableCollection<ButtonData> _staredLocations;
        /// <summary>
        /// This is the list of Starred location which is the back store for the horizontal view on the home search page.
        /// </summary>
        public ObservableCollection<ButtonData> StarredLocations
        {
            get
            {
                return _staredLocations;
            }
            set
            {
                if (_staredLocations == value) return;

                _staredLocations = value;

                DoPropertyChanged("StarredLocations");
            }
        }


        public StarredPlacesViewModel(MainViewModel mainViewModel) : base(mainViewModel)
        {
            //Initiate and insert data in the Starred Location list for the Xaml to render the screen. 

            #region StarredLocations
            StarredLocations = new ObservableCollection<ButtonData>();
            StarredLocations.Add(new ButtonData()
            {
                Text = "School",
                Image = "starred_place",
                BorderWidth = 1
            });
            StarredLocations.Add(new ButtonData()
            {
                Text = "Home",
                Image = "starred_place",
                BorderWidth = 1
            });
            StarredLocations.Add(new ButtonData()
            {
                Text = "Work",
                Image = "starred_place",
                BorderWidth = 1
            });
            StarredLocations.Add(new ButtonData()
            {
                Text = "Library",
                Image = "starred_place",
                BorderWidth = 1
            });
            StarredLocations.Add(new ButtonData()
            {
                Text = "Jamie's Dorm",
                Image = "starred_place",
                BorderWidth = 1
            });

            StarredLocations.Add(new ButtonData()
            {
                Text = "Add More Starred Places",
                Image = "plus_changed"
            });
            #endregion
        }
    }
}
