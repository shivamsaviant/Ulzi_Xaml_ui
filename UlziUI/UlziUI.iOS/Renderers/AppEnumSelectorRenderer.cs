using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using UlziUI.Controls;
using System.ComponentModel;
using UlziUI.Classes.Enums;
using Xamarin.Forms;
using UlziUI.iOS.Renderers;

[assembly: ExportRenderer(typeof(AppEnumSelector), typeof(AppEnumSelectorRenderer))]
namespace UlziUI.iOS.Renderers
{
    #region AppEnumSelectorRenderer
    public class AppEnumSelectorRenderer : ViewRenderer<AppEnumSelector, UIPickerView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<AppEnumSelector> args)
        {
            base.OnElementChanged(args);

            if (this.Control == null)
            {
                this.SetNativeControl(this.CreatePicker());
                this.UpdateValues();
                this.SetValue();
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(sender, args);

            if (args.PropertyName == AppEnumSelector.SelectedItemProperty.PropertyName)
                this.SetValue();
            else if (args.PropertyName == AppEnumSelector.ItemsProperty.PropertyName)
                this.UpdateValues();
        }

        private void UpdateValues()
        {
            this.Control.Model = new PickerViewModel(this.Element);
        }

        private void SetValue()
        {
            var value = 0;
            if ((this.Element != null) && (this.Element.Items != null) && (this.Element.Items.Count > 0) && (this.Element.SelectedItem != null))
                value = this.Element.Items.IndexOf(this.Element.SelectedItem);
            if (this.Control != null)
                this.Control.Select(value, 0, true);
        }

        private UIPickerView CreatePicker()
        {
            var picker = new UIPickerView();
            picker.ShowSelectionIndicator = false;
            return picker;
        }

        #region PickerViewModel
        public class PickerViewModel : UIPickerViewModel
        {
            private AppEnumSelector _appEnumSelector = null;

            public PickerViewModel(AppEnumSelector appEnumSelector) : base()
            {
                _appEnumSelector = appEnumSelector;
            }

            public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
            {
                var count = 0;
                if ((_appEnumSelector != null) && (_appEnumSelector.Items != null))
                    count = _appEnumSelector.Items.Count;
                return count;
            }

            public override string GetTitle(UIPickerView pickerView, nint row, nint component)
            {
                var result = "";
                if ((_appEnumSelector != null) && (_appEnumSelector.Items != null) && ((int)row < _appEnumSelector.Items.Count))
                    result = _appEnumSelector.Items[(int)row].ToString();
                return result;
            }

            public override nint GetComponentCount(UIPickerView pickerView)
            {
                return 1;
            }

            public override UIView GetView(UIPickerView pickerView, nint row, nint component, UIView view)
            {
                var label = new UILabel(); // (UILabel)base.GetView(pickerView, row, component, view);
                if (_appEnumSelector != null)
                {
                    string path = "";
                    if (_appEnumSelector.AppFont == AppFonts.Quicksand)
                        path = "Quicksand-Regular";

                    if (!String.IsNullOrEmpty(path))
                    {
                        var font = UIFont.FromName(path, (nfloat)_appEnumSelector.FontSize);
                        if (font != null)
                            label.Font = font;
                    }
                }
                label.TextAlignment = this.GetTextAlignment();
                label.Text = this.GetTitle(pickerView, row, component);
                label.TextColor = _appEnumSelector.ValueTextColor.ToUIColor();
                return label;
            }

            public override void Selected(UIPickerView pickerView, nint row, nint component)
            {
                //base.Selected(pickerView, row, component);

                object selected = null;
                if ((_appEnumSelector != null) && (_appEnumSelector.Items != null) && (_appEnumSelector.Items.Count > 0))
                    selected = _appEnumSelector.Items[(int)row];
                _appEnumSelector.SelectedItem = selected;
            }

            public AppEnumSelector AppEnumSelector
            {
                get { return _appEnumSelector; }
                set { _appEnumSelector = value; }
            }

            private UITextAlignment GetTextAlignment()
            {
                var textAlignment = UITextAlignment.Center;
                if (_appEnumSelector.TextAlignment == TextAlignment.End)
                    textAlignment = UITextAlignment.Right;
                else if (_appEnumSelector.TextAlignment == TextAlignment.Start)
                    textAlignment = UITextAlignment.Left;
                return textAlignment;
            }
        }
        #endregion
    }
    #endregion
}