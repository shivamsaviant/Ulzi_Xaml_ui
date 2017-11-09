using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using UlziUI.Classes.Models;
using UlziUI.Controls;

namespace UlziUI.Views.Panels
{
    public partial class HomeSearchPanel : Panel
    {
        //This dictionary maintains the mapping of the button data with Views. 
        //This will be used to keep the references of the added view in Different parts of the screen
        private Dictionary<ButtonData, View> _viewMappings = new Dictionary<ButtonData, View>();

        #region Contact List Bindable Property
        #region Static members
        public static readonly BindableProperty ContactListProperty = BindableProperty.Create(
            propertyName: "ContactList",
            returnType: typeof(ObservableCollection<ButtonData>),
            declaringType: typeof(ObservableCollection<ButtonData>),
            defaultValue: new ObservableCollection<ButtonData>(),
            defaultBindingMode: BindingMode.TwoWay, propertyChanged: OnContactListChanged);//BindableProperty.Create("ContactList", typeof(ObservableCollection<ButtonData>), typeof(ObservableCollection<ButtonData>), new ObservableCollection<ButtonData>());


        static void OnContactListChanged(BindableObject bindable, object oldValue, object newValue)
        {

            if (oldValue != null)
            {
                //Remove previous callback
                (oldValue as ObservableCollection<ButtonData>).CollectionChanged -= (bindable as HomeSearchPanel).OnContactListChanged;
                foreach (var contact in oldValue as ObservableCollection<ButtonData>)
                {
                    (bindable as HomeSearchPanel).RemoveContactTile(contact);
                }
            }
            if (newValue != null)
            {
                foreach (var contact in newValue as ObservableCollection<ButtonData>)
                {
                    (bindable as HomeSearchPanel).AddContactTile(contact);
                }

                (newValue as ObservableCollection<ButtonData>).CollectionChanged += (bindable as HomeSearchPanel).OnContactListChanged;
            }
        }
        #endregion
        /// <summary>
        /// Gets or sets the contact list.
        /// </summary>
        /// <value>The contact list.</value>
        public ObservableCollection<ButtonData> ContactList
        {
            get { return (ObservableCollection<ButtonData>)this.GetValue(ContactListProperty); }
            set
            {
                this.SetValue(ContactListProperty, value);
            }
        }

        /// <summary>
        /// This will handle any changes in the Contact Collection
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        internal void OnContactListChanged(object sender = null, System.Collections.Specialized.NotifyCollectionChangedEventArgs e = null)
        {
            if (e.NewItems != null) // New Values added
            {
                foreach (var contact in e.NewItems)
                {
                    AddContactTile(contact as ButtonData);
                }
            }

            if (e.OldItems != null)  //Value removed
            {
                foreach (var contact in e.OldItems)
                {
                    RemoveContactTile(contact as ButtonData);
                }
            }
        }

        /// <summary>
        /// Adds the contact tile.
        /// </summary>
        public void AddContactTile(ButtonData contact)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                var view = CreateView<AppTileButton>();
                view.BindingContext = contact;
                ContactListLayout.Children.Add(view);
                _viewMappings.Add(contact, view);
            });
        }
        /// <summary>
        /// Removes contact tile from the horizontal scrollview
        /// </summary>
        /// <param name="contact"></param>
        public void RemoveContactTile(ButtonData contact)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                //Remove the view from the view heirarchy
                ContactListLayout.Children.Remove(_viewMappings.GetValueOrDefault(contact));

                //remove the mapping
                _viewMappings.Remove(contact);
            });
        }
        #endregion

        #region Starred Places Bindable Property
        #region Static members
        public static readonly BindableProperty StarredPlacesListProperty = BindableProperty.Create(
            propertyName: "StarredPlacesList",
            returnType: typeof(ObservableCollection<ButtonData>),
            declaringType: typeof(ObservableCollection<ButtonData>),
            defaultValue: new ObservableCollection<ButtonData>(),
            defaultBindingMode: BindingMode.TwoWay, propertyChanged: OnStarredPlacesListChanged);

        /// <summary>
        /// This will handle any changes in the Starred Location Collection
        /// </summary>
        /// <param name="bindable"></param>
        /// <param name="oldValue"></param>
        /// <param name="newValue"></param>
        static void OnStarredPlacesListChanged(BindableObject bindable, object oldValue, object newValue)
        {

            if (oldValue != null)
            {
                //Remove previous callback
                (oldValue as ObservableCollection<ButtonData>).CollectionChanged -= (bindable as HomeSearchPanel).OnStarredPlacesListChanged;
                foreach (var place in oldValue as ObservableCollection<ButtonData>)
                {
                    (bindable as HomeSearchPanel).RemoveHorizontalButton((bindable as HomeSearchPanel).StarredLocationLayout, place);
                }
            }
            if (newValue != null)
            {
                foreach (var place in newValue as ObservableCollection<ButtonData>)
                {
                    (bindable as HomeSearchPanel).AddHorizontalButton((bindable as HomeSearchPanel).StarredLocationLayout, place);
                }

                (newValue as ObservableCollection<ButtonData>).CollectionChanged += (bindable as HomeSearchPanel).OnStarredPlacesListChanged;
            }
        }
        #endregion
        /// <summary>
        /// Gets or sets the contact list.
        /// </summary>
        /// <value>The contact list.</value>
        public ObservableCollection<ButtonData> StarredPlacesList
        {
            get { return (ObservableCollection<ButtonData>)this.GetValue(StarredPlacesListProperty); }
            set
            {
                this.SetValue(StarredPlacesListProperty, value);
            }
        }

        /// <summary>
        /// Ons the value changed.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        internal void OnStarredPlacesListChanged(object sender = null, System.Collections.Specialized.NotifyCollectionChangedEventArgs e = null)
        {
            if (e.NewItems != null) // New Values added
            {
                foreach (var place in e.NewItems)
                {
                    AddHorizontalButton(StarredLocationLayout, place as ButtonData);
                }
            }

            if (e.OldItems != null)  //Value removed
            {
                foreach (var place in e.OldItems)
                {
                    RemoveHorizontalButton(StarredLocationLayout, place as ButtonData);
                }
            }
        }
        #endregion

        #region Recent Places Bindable Property
        #region Static members
        public static readonly BindableProperty RecentPlacesListProperty = BindableProperty.Create(
            propertyName: "RecentPlacesList",
            returnType: typeof(ObservableCollection<ButtonData>),
            declaringType: typeof(ObservableCollection<ButtonData>),
            defaultValue: new ObservableCollection<ButtonData>(),
            defaultBindingMode: BindingMode.TwoWay, propertyChanged: OnRecentPlacesListChanged);

        static void OnRecentPlacesListChanged(BindableObject bindable, object oldValue, object newValue)
        {

            if (oldValue != null)
            {
                //Remove previous callback
                (oldValue as ObservableCollection<ButtonData>).CollectionChanged -= (bindable as HomeSearchPanel).OnRecentPlacesListChanged;
                foreach (var place in oldValue as ObservableCollection<ButtonData>)
                {
                    (bindable as HomeSearchPanel).RemoveHorizontalButton((bindable as HomeSearchPanel).RecentLocationLayout, place);
                }
            }
            if (newValue != null)
            {
                foreach (var place in newValue as ObservableCollection<ButtonData>)
                {
                    (bindable as HomeSearchPanel).AddHorizontalButton((bindable as HomeSearchPanel).RecentLocationLayout, place);
                }

                (newValue as ObservableCollection<ButtonData>).CollectionChanged += (bindable as HomeSearchPanel).OnRecentPlacesListChanged;
            }
        }
        #endregion

        /// <summary>
        /// Gets or sets the contact list.
        /// </summary>
        /// <value>The contact list.</value>
        public ObservableCollection<ButtonData> RecentPlacesList
        {
            get { return (ObservableCollection<ButtonData>)this.GetValue(StarredPlacesListProperty); }
            set
            {
                this.SetValue(StarredPlacesListProperty, value);
            }
        }

        /// <summary>
        /// This will handle any changes in the Recent Location Collection
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        internal void OnRecentPlacesListChanged(object sender = null, System.Collections.Specialized.NotifyCollectionChangedEventArgs e = null)
        {
            if (e.NewItems != null) // New Values added
            {
                foreach (var place in e.NewItems)
                {
                    AddHorizontalButton(RecentLocationLayout, place as ButtonData);
                }
            }

            if (e.OldItems != null)  //Value removed
            {
                foreach (var place in e.OldItems)
                {
                    RemoveHorizontalButton(RecentLocationLayout, place as ButtonData);
                }
            }
        }
        #endregion

        /// <summary>
        /// Adds the Horizontal button.
        /// </summary>
        public void AddHorizontalButton(StackLayout layout, ButtonData place)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                var view = CreateView<AppHorizontalButton>();
                view.BindingContext = place;
                layout.Children.Add(view);
                _viewMappings.Add(place, view);
            });
        }

        /// <summary>
        /// Removes Horizontal button
        /// </summary>
        /// <param name="layout"></param>
        /// <param name="place"></param>
        public void RemoveHorizontalButton(StackLayout layout, ButtonData place)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                //Remove the view from the view heirarchy
                layout.Children.Remove(_viewMappings.GetValueOrDefault(place));

                //remove the mapping
                _viewMappings.Remove(place);
            });
        }

        /// <summary>
        /// Creates the view reflection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private T CreateView<T>() where T : ContentView
        {
            return Activator.CreateInstance<T>();
        }

        public HomeSearchPanel()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            this.SetBinding(HomeSearchPanel.ContactListProperty, "ContactList", BindingMode.TwoWay);
            this.SetBinding(HomeSearchPanel.StarredPlacesListProperty, "StarredLocations", BindingMode.TwoWay);
            this.SetBinding(HomeSearchPanel.RecentPlacesListProperty, "RecentLocations", BindingMode.TwoWay);
        }
    }
}
