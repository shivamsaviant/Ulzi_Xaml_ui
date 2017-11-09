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
using Android.Graphics;
using UlziUI.Droid.Renderers;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(AppImage), typeof(AppImageRenderer))]
namespace UlziUI.Droid.Renderers
{
    #region AppImageRenderer
    public class AppImageRenderer : ImageRenderer
    {
        private AppImage _appImage = null;

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(sender, args);

            //if (args.PropertyName == "ImageUri")
            //    this.LoadImage();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Image> args)
        {
            base.OnElementChanged(args);

            _appImage = (this.Element as AppImage);

            if (args.OldElement == null)
            {

                if ((int)Android.OS.Build.VERSION.SdkInt < 18)
                    this.SetLayerType(LayerType.Software, null);
            }
        }

        protected override bool DrawChild(Canvas canvas, Android.Views.View child, long drawingTime)
        {
            try
            {
                var radius = Math.Min(this.Width, this.Height) / 2;

                //Create path to clip
                var path = new Path();
                path.AddCircle(Width / 2, Height / 2, radius, Path.Direction.Ccw);
                canvas.Save();
                canvas.ClipPath(path);

                var result = base.DrawChild(canvas, child, drawingTime);

                canvas.Restore();

               

                //Saviant changes
                //When there is no border it should not draw path
                if(_appImage.StrokeWidth > 0)
                {
                    // Create path for circle border
                    path = new Path();
                    path.AddCircle(Width / 2, Height / 2, radius, Path.Direction.Ccw);

                    var paint = new Paint();
                    paint.AntiAlias = true;
                    paint.StrokeWidth = (float)_appImage.StrokeWidth;
                    paint.SetStyle(Paint.Style.Stroke);
                    paint.Color = _appImage.StrokeColor.ToAndroid(); // global::Android.Graphics.Color.Black;

                    canvas.DrawPath(path, paint);

                    //Properly dispose
                    paint.Dispose();
                    path.Dispose();
                }


                return result;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Unable to create circle image: " + exception);
            }

            return base.DrawChild(canvas, child, drawingTime);
        }
    }
    #endregion
}