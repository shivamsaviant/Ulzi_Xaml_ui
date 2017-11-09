using System;
using UlziUI.ViewModels.Pages;
using System.Collections.ObjectModel;
using UlziUI.Classes.Models;
using System.Threading.Tasks;

namespace UlziUI.ViewModels.Panels
{
    /// <summary>
    /// HomeSearchViewModel
    /// This view model is responsible for managing the home search page
    /// </summary>
    public class HomeSearchViewModel : PanelViewModel
    {
        private ButtonData _currentLocation;
        /// <summary>
        /// This is the backstore for the data to be shown on the button.
        /// </summary>
        public ButtonData CurrentLocation
        {
            get
            {
                return _currentLocation;
            }
            set
            {
                _currentLocation = value;
                DoPropertyChanged("CurrentLocation");
            }
        }

        private ObservableCollection<ButtonData> _contactList;
        /// <summary>
        /// This is the list of contact which is the back store for the horizontal view on the home search page.
        /// </summary>
        public ObservableCollection<ButtonData> ContactList
        {
            get
            {
                return _contactList;
            }
            set
            {
                if (_contactList == value) return;
                _contactList = value;

                DoPropertyChanged("ContactList");
            }
        }

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

        private ObservableCollection<ButtonData> _recentLocations;
        /// <summary>
        /// This is the list of Recent locations which is the back store for the horizontal view on the home search page.
        /// </summary>
        public ObservableCollection<ButtonData> RecentLocations
        {
            get
            {
                return _recentLocations;
            }
            set
            {
                if (_recentLocations == value) return;

                _recentLocations = value;

                DoPropertyChanged("RecentLocations");
            }
        }

        public HomeSearchViewModel(MainViewModel mainViewModel) : base(mainViewModel)
        {
            //Populate the data on the Home search page
            CurrentLocation = new ButtonData()
            {
                Text = "Current Location",
                Image = "location_changed"
            };

            //Initiate and insert data in the contact list for the Xaml to render the screen. 
            #region ContactLists
            ContactList = new ObservableCollection<ButtonData>();
            ContactList.Add(new ButtonData()
            {
                Text = "Add New",
                Image = "add_photo"
            });
            ContactList.Add(new ButtonData()
            {
                Text = "Person 1",
                Image = "http://lorempixel.com/190/190/people/"
            });
            ContactList.Add(new ButtonData()
            {
                Text = "Person 1",
                Image = "http://lorempixel.com/190/190/people/"
            });
            ContactList.Add(new ButtonData()
            {
                Text = "Person 2",
                Image = "http://lorempixel.com/190/190/people/"
            });
            ContactList.Add(new ButtonData()
            {
                Text = "Person 3",
                Image = "http://lorempixel.com/190/190/people/"
            });
            ContactList.Add(new ButtonData()
            {
                Text = "Person 4",
                Image = "http://lorempixel.com/190/190/people/"
            });
            ContactList.Add(new ButtonData()
            {
                Text = "Person 5",
                Image = "http://lorempixel.com/190/190/people/"
            });
            ContactList.Add(new ButtonData()
            {
                Text = "Person 6",
                Image = "http://lorempixel.com/190/190/people/"
            });
            ContactList.Add(new ButtonData()
            {
                Text = "Person 7",
                Image = "http://lorempixel.com/190/190/people/"
            });


            //we tried removing one of the Contacts after delay of 5 sec to see if the list on the screen is being refreshed
            Task.Run(async () =>
            {
                await Task.Delay(5000).ContinueWith((arg) =>
                {
                    ContactList.RemoveAt(3);
                });
            });
            #endregion

            //Initiate and insert data in the contact list for the Xaml to render the screen. 
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

            //Initiate and insert data in the Recent locations list for the Xaml to render the screen. 
            #region RecentLists
            RecentLocations = new ObservableCollection<ButtonData>();
            RecentLocations.Add(new ButtonData()
            {
                Text = "872 Higuera St",
                Image = "location_changed"
            });
            RecentLocations.Add(new ButtonData()
            {
                Text = "872 Higuera St",
                Image = "location_changed"
            });
            RecentLocations.Add(new ButtonData()
            {
                Text = "872 Higuera St",
                Image = "location_changed"
            });
            RecentLocations.Add(new ButtonData()
            {
                Text = "872 Higuera St",
                Image = "location_changed"
            });
            RecentLocations.Add(new ButtonData()
            {
                Text = "872 Higuera St",
                Image = "location_changed"
            });
            RecentLocations.Add(new ButtonData()
            {
                Text = "872 Higuera St",
                Image = "location_changed"
            });
            #endregion
        }

        public override void Initialize(params object[] parameters)
        {
            base.Initialize(parameters);


        }
    }
}
