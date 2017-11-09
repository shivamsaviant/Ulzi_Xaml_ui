using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlziUI.Classes.Models;
using UlziUI.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UlziUI.Views.Panels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StarredPlacesPanel : Panel
    {
        //This dictionary maintains the mapping of the button data with Views. 
        //This will be used to keep the references of the added view in Different parts of the screen
        private Dictionary<ButtonData, View> _viewMappings = new Dictionary<ButtonData, View>();

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
                (oldValue as ObservableCollection<ButtonData>).CollectionChanged -= (bindable as StarredPlacesPanel).OnStarredPlacesListChanged;
                foreach (var place in oldValue as ObservableCollection<ButtonData>)
                {
                    (bindable as StarredPlacesPanel).RemoveHorizontalButton((bindable as StarredPlacesPanel).StarredLocationLayout, place);
                }
            }
            if (newValue != null)
            {
                foreach (var place in newValue as ObservableCollection<ButtonData>)
                {
                    (bindable as StarredPlacesPanel).AddHorizontalButton((bindable as StarredPlacesPanel).StarredLocationLayout, place);
                }

                (newValue as ObservableCollection<ButtonData>).CollectionChanged += (bindable as StarredPlacesPanel).OnStarredPlacesListChanged;
            }
        }
        #endregion
        /// <summary>
        /// Gets or sets the Starred Location list.
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

        /// <summary>
        /// Adds the contact tile.
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
        /// Creates the instance of the specified class using reflection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private T CreateView<T>() where T : ContentView
        {
            return Activator.CreateInstance<T>();
        }

        public StarredPlacesPanel()
        {
            string labeltext = "Add the places that are important to you. You can also add places by holding down on the or searching for a place on the map page.";
            InitializeComponent();
            HeaderLabel.Text = labeltext;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            this.SetBinding(StarredPlacesPanel.StarredPlacesListProperty, "StarredLocations", BindingMode.TwoWay);
        }
    }
}