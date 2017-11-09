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
using Xamarin.Forms.Platform.Android;
using UlziUI.Controls;
using System.ComponentModel;
using UlziUI.Classes.Models;
using Android.Graphics.Drawables;
using UlziUI.Classes.Enums;
using Android.Graphics;
using Android.Util;
using Java.Lang;
using UlziUI.Droid.Renderers;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(AppEnumSelector), typeof(AppEnumSelectorRenderer))]
namespace UlziUI.Droid.Renderers
{
    #region AppEnumSelectorRenderer
    public class AppEnumSelectorRenderer : ViewRenderer<AppEnumSelector, NumberPicker>, NumberPicker.IOnValueChangeListener
    {
        protected override void OnElementChanged(ElementChangedEventArgs<AppEnumSelector> args)
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

            if (args.PropertyName == AppEnumSelector.SelectedItemProperty.PropertyName)
                this.UpdateValue();
            else if (args.PropertyName == AppEnumSelector.ItemsProperty.PropertyName)
                this.BuildList();
        }

        private void UpdateValue()
        {
            try
            {
                var value = 0;
                if (this.Element.SelectedItem is PickerItem)
                    value = this.Element.Items.IndexOf(this.Element.SelectedItem);
                this.Control.Value = value;

                if (this.Element.SelectedItem == null)
                    this.Element.SelectedItem = (this.Element.Items[0] as PickerItem);
            }
            catch (System.Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void BuildList()
        {
            try
            {
                var items = new string[] { };
                if (this.Element.Items is IList<PickerItem>)
                    items = (this.Element.Items as IList<PickerItem>).Select(pi => pi.Name).ToArray();

                if (items.Length == 0)
                    items = new string[] { "No Items" };

                this.Control.SetDisplayedValues(items);

                this.Control.Value = 0;
                this.Control.MinValue = 0;
                this.Control.MaxValue = items.Length - 1;
            }
            catch (System.Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
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
                        editText.SetTextColor(this.Element.ValueTextColor.ToAndroid());

                        var paint = (Paint)selectorWheelPaintField.Get(numberPicker);
                        paint.TextSize = TypedValue.ApplyDimension(ComplexUnitType.Dip, (float)this.Element.FontSize, numberPicker.Resources.DisplayMetrics);
                        paint.Color = this.Element.ValueTextColor.ToAndroid();
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
                this.Element.SelectedItem = this.Element.Items[newVal];
        }
        #endregion
    }
    #endregion
}