using System;
using UlziUI.Classes;
using UlziUI.ViewModels.Panels;
using UlziUI.Views.Panels;

namespace UlziUI.ViewModels.Pages
{
    /// <summary>
    /// TabPageViewModel
    /// This is the container view model which is responsible for maintaining all the tabs associated view models with them
    /// It maintains State property to handle the navigation i.e. Switching of the tabs. State property is bound to visiblity
    /// of the panel
    /// </summary>
    public class TabPageViewModel : UlziViewModel
    {
        private int _state = -1;
        /// <summary>
        /// This property maintains the current selected tab and will also be used for navigation in the tabbar
        /// </summary>
        public int State
        {
            get { return (int)_state; }
            set
            {
                if (_state != value)
                {
                    _state = value;
                    DoPropertyChanged("State");
                }
            }
        }

        public VisualCommand HomeSearchCommand { get; private set; }
        public VisualCommand StarredLocationCommand { get; private set; }

        public HomeSearchViewModel HomeSearchViewModel { get; private set; }
        public StarredPlacesViewModel StarredPlacesViewModel { get; private set; }

        public TabPageViewModel()
        {
            HomeSearchViewModel = new HomeSearchViewModel(null);
            StarredPlacesViewModel = new StarredPlacesViewModel(null);

            HomeSearchCommand = new VisualCommand(NavigateToHomeSearch);
            StarredLocationCommand = new VisualCommand(NavigateToStarredLocations);
            State = 0; //TODO: Use Constants
        }


        
        private void NavigateToStarredLocations(object parameter)
        {
            //We have not used CONSTANTS to define the pages for now but will use CONSTANTS
            State = 1; //TODO: Use Constants
        }

        private void NavigateToHomeSearch(object parameter)
        {
            State = 0; //TODO: Use Constants
        }
    }
}
