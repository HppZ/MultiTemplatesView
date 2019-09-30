using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Store;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace MultiTemplatesListView
{
    public sealed class CardItem : Control
    {
        public CardItem()
        {
            this.DefaultStyleKey = typeof(CardItem);
        }

        public static readonly DependencyProperty CoverProperty = DependencyProperty.Register(
            "Cover", typeof(string), typeof(CardItem), new PropertyMetadata(default(string)));

        public string Cover
        {
            get { return (string) GetValue(CoverProperty); }
            set { SetValue(CoverProperty, value); }
        }

    }
}
