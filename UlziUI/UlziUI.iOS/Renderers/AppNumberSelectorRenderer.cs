using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using UlziUI.Controls;
using Xamarin.Forms.Platform.iOS;
using System.ComponentModel;
using UlziUI.Classes.Enums;
using Xamarin.Forms;
using UlziUI.iOS.Renderers;

[assembly: ExportRenderer(typeof(AppNumberSelector), typeof(AppNumberSelectorRenderer))]
namespace UlziUI.iOS.Renderers
{
    #region AppNumberSelectorRenderer
    public class AppNumberSelectorRenderer : ViewRenderer<AppNumberSelector, UIPickerView>
    {

        protected override void OnElementChanged(ElementChangedEventArgs<AppNumberSelector> args)
        {
            base.OnElementChanged(args);

            if (this.Control == null)
            {
                this.SetNativeControl(this.CreatePicker());

                this.SetValue();
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(sender, args);

            if (args.PropertyName == AppNumberSelector.ValueProperty.PropertyName)
                this.SetValue();
        }

        private void SetValue()
        {
            var value = 0;
            if ((this.Element != null) && (this.Element.Value >= this.Element.MinValue) && (this.Element.MaxValue >= this.Element.Value))
                value = this.Element.Value;
            if (this.Control != null)
                this.Control.Select(value, 0, true);
        }

        private UIPickerView CreatePicker()
        {
            var picker = new UIPickerView();
            picker.Model = new PickerViewModel(this.Element);
            return picker;
        }

        #region PickerViewModel
        public class PickerViewModel : UIPickerViewModel
        {
            private AppNumberSelector _appNumberSelector = null;

            public PickerViewModel(AppNumberSelector appNumberSelector) : base()
            {
                _appNumberSelector = appNumberSelector;
            }

            public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
            {
                return (_appNumberSelector != null ? _appNumberSelector.MaxValue - _appNumberSelector.MinValue + 1 : 0);
            }

            public override string GetTitle(UIPickerView pickerView, nint row, nint component)
            {
                return (row + (nint)(_appNumberSelector != null ? _appNumberSelector.MinValue : 0)).ToString();
            }

            public override nint GetComponentCount(UIPickerView pickerView)
            {
                return 1;
            }

            public override UIView GetView(UIPickerView pickerView, nint row, nint component, UIView view)
            {
                var label = new UILabel(); // (UILabel)base.GetView(pickerView, row, component, view);
                if (_appNumberSelector != null)
                {
                    string path = "";
                    if (_appNumberSelector.AppFont == AppFonts.Quicksand)
                        path = "Quicksand-Regular";

                    if (!String.IsNullOrEmpty(path))
                    {
                        var font = UIFont.FromName(path, (nfloat)_appNumberSelector.FontSize);
                        if (font != null)
                            label.Font = font;
                    }
                }
                label.TextAlignment = UITextAlignment.Center;
                label.Text = this.GetTitle(pickerView, row, component);
                return label;
            }

            public override void Selected(UIPickerView pickerView, nint row, nint component)
            {
                //base.Selected(pickerView, row, component);

                if (_appNumberSelector != null)
                    _appNumberSelector.Value = (int)row;
            }

            public AppNumberSelector AppNumberSelector
            {
                get { return _appNumberSelector; }
                set { _appNumberSelector = value; }
            }
        }
        #endregion
    }
    #endregion
}