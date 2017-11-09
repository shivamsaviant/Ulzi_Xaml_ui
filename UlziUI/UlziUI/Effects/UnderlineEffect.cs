using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace UlziUI.Effects
{
    #region UnderlineEffect
    public class UnderlineEffect : RoutingEffect
    {
        public const string EFFECT_NAMESPACE = "Effects";

        public UnderlineEffect() : base($"{EFFECT_NAMESPACE}.{nameof(UnderlineEffect)}")
        {
        }
    }
    #endregion
}
