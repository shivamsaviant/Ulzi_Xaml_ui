using System;
using System.Security.Permissions;
namespace UlziUI.Classes.Models
{
    public class ButtonData : BaseData
    {
        private string _text;
        public string Text 
        { 
            get
            {
                return _text;
            }
            set{
                if (_text == value) return;

                _text = value;
                DoPropertyChanged("Text");
            }
        }

        private string _image;
        public string Image
        {
            get
            {
                return _image;
            }
            set
            {
                if (_image == value) return;

                _image = value;
                DoPropertyChanged("Image");
            }
        }


        private double _borderWidth = 0;
        public double BorderWidth
        {
            get
            {
                return _borderWidth;
            }
            set
            {
                if (_borderWidth == value) return;

                _borderWidth = value;
                DoPropertyChanged("BorderWidth");
            }
        }
    }
}

