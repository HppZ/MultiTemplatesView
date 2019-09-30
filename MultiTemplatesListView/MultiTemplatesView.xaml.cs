using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace MultiTemplatesListView
{
    public sealed partial class MultiTemplatesView : UserControl
    {
        public MultiTemplatesView()
        {
            this.InitializeComponent();
            ListView a; 
            a.ItemsSource
        }

        public static readonly DependencyProperty SourceProperty = DependencyProperty.Register(
            "Source", typeof(object), typeof(MultiTemplatesView), new PropertyMetadata(default(object)));

        public object Source
        {
            get { return (object) GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty DataTemplateSelectorProperty = DependencyProperty.Register(
            "DataTemplateSelector", typeof(DataTemplateSelector), typeof(MultiTemplatesView), new PropertyMetadata(default(DataTemplateSelector)));

        public DataTemplateSelector DataTemplateSelector
        {
            get { return (DataTemplateSelector) GetValue(DataTemplateSelectorProperty); }
            set { SetValue(DataTemplateSelectorProperty, value); }
        }

    }
}
