using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace CustomFlipViewDemo
{
    public sealed class CustomFlipViewItem : FlipViewItem
    {
        public CustomFlipViewItem()
        {
            this.DefaultStyleKey = typeof(CustomFlipViewItem);
        }


        protected override void OnKeyDown(KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Left || e.Key == VirtualKey.Right || e.Key == VirtualKey.Up || e.Key == VirtualKey.Down)
            {
                e.Handled = true;
            }

            base.OnKeyDown(e);
        }
    }
}
