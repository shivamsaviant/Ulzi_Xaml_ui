using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using UlziUI.Controls;
using Xamarin.Forms.Platform.Android;
using System.ComponentModel;
using UlziUI.Classes.Enums;
using Android.Graphics;
using Android.Util;
using Java.Lang;
using Android.Graphics.Drawables;
using UlziUI.Droid.Renderers;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(AppNumberSelector), typeof(AppNumberSelectorRenderer))]
namespace UlziUI.Droid.Renderers
{
    #region AppNumberSelectorRenderer
    public class AppNumberSelectorRenderer : ViewRenderer<AppNumberSelector, NumberPicker>, NumberPicker.IOnValueChangeListener
    {
        protected override void OnElementChanged(ElementChangedEventArgs<AppNumberSelector> args)
        {
            base.OnElementChanged(args);

            if (this.Control == null)
            {
                var control = this.CreateNativeControl();
                this.SetNativeControl(control);
            }

            this.HideDelimiter();
            this.SetRowsCount();
            this.BuildList();
            this.Prepare();
        }

        protected override NumberPicker CreateNativeControl()
        {
            var control = new NumberPicker(this.Context);
            control.WrapSelectorWheel = false;
            control.SetOnValueChangedListener(this);
            control.DescendantFocusability = DescendantFocusability.BlockDescendants;
            return control;
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(sender, args);

            if (args.PropertyName == AppNumberSelector.ValueProperty.PropertyName)
                this.Control.Value = this.Element.Value;
        }

        private void BuildList()
        {
            var items = new List<string>();

            for (int index = this.Element.MinValue; index <= this.Element.MaxValue; index++)
                items.Add(index.ToString());

            this.Control.MaxValue = this.Element.MaxValue;
            this.Control.MinValue = this.Element.MinValue;
            this.Control.Value = this.Element.Value;
        }

        private void HideDelimiter()
        {
            try
            {
                var numberPickerType = Java.Lang.Class.FromType(typeof(NumberPicker));
                var divider = numberPickerType.GetDeclaredField("mSelectionDivider");
                divider.Accessible = true;

                var dividerDraw = new ColorDrawable(Xamarin.Forms.Color.Transparent.ToAndroid());
                divider.Set(this.Control, dividerDraw);
            }
            catch
            {
            }
        }

        private void SetRowsCount()
        {
            try
            {
                var numberPickerType = Java.Lang.Class.FromType(typeof(NumberPicker));
                var itemsCount = numberPickerType.GetDeclaredField("SELECTOR_WHEEL_ITEM_COUNT");
                itemsCount.Accessible = true;

                itemsCount.Set(this.Control, 5);
            }
            catch
            {
            }
        }

        private void Prepare()
        {
            var numberPicker = this.Control;

            string path = "";
            if (this.Element.AppFont == AppFonts.Quicksand)
                path = "Fonts/Quicksand-Regular.ttf";

            Typeface typeFace = null;
            if (!System.String.IsNullOrEmpty(path))
                typeFace = Typeface.CreateFromAsset(this.Context.Assets, path);

            int count = numberPicker.ChildCount;
            for (int i = 0; i < count; i++)
            {
                var child = numberPicker.GetChildAt(i);
                if (child.GetType() == typeof(EditText))
                {
                    try
                    {
                        var selectorWheelPaintField = numberPicker.Class.GetDeclaredField("mSelectorWheelPaint");
                        selectorWheelPaintField.Accessible = true;

                        var editText = (EditText)child;
                        if (!System.String.IsNullOrEmpty(path))
                            editText.Typeface = typeFace;
                        editText.TextSize = (float)this.Element.FontSize;
                        editText.SetTextColor(this.Element.ValueColor.ToAndroid());

                        var paint = (Paint)selectorWheelPaintField.Get(numberPicker);
                        paint.TextSize = TypedValue.ApplyDimension(ComplexUnitType.Dip, (float)this.Element.FontSize, numberPicker.Resources.DisplayMetrics);
                        paint.Color = this.Element.ValueColor.ToAndroid();
                        paint.SetTypeface(editText.Typeface);

                        numberPicker.Invalidate();
                    }
                    catch (NoSuchFieldException e)
                    {
                        Log.Warn("setNumberPickerTextColor", e);
                    }
                    catch (IllegalAccessException e)
                    {
                        Log.Warn("setNumberPickerTextColor", e);
                    }
                    catch (IllegalArgumentException e)
                    {
                        Log.Warn("setNumberPickerTextColor", e);
                    }
                }
            }
        }

        #region NumberPicker.IOnValueChangeListener
        public void OnValueChange(NumberPicker picker, int oldVal, int newVal)
        {
            if (this.Element != null)
                this.Element.Value = newVal;
        }
        #endregion
    }
    #endregion
}