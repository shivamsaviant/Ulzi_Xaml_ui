using System;
using System.Collections.Generic;
using System.Text;

namespace UlziUI.Classes.Models
{
    #region PickerItem
    public class PickerItem
    {
        public override string ToString()
        {
            return this.Name;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
    #endregion
}
