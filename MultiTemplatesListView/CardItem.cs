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
using Windows.UI.Xaml.Media.Imaging;
using Image = Windows.UI.Xaml.Controls.Image;

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
            "Cover", typeof(string), typeof(CardItem), new PropertyMetadata(default(string), onChanged));

        private static void onChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as CardItem).SetImg();
        }

        private void SetImg()
        {
            if (_img != null && Cover != null)
            {
                _img.Source = new BitmapImage(new Uri(Cover));
            }
        }

        public string Cover
        {
            get { return (string)GetValue(CoverProperty); }
            set { SetValue(CoverProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
            "Title", typeof(string), typeof(CardItem), new PropertyMetadata(default(string)));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        private Image _img;
        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _img = GetTemplateChild("ImagePart") as Image;
            SetImg();
        }
    }

    public enum CardType
    {
        Movie,
        Album,
    }

    public class CardItemModel
    {
        public CardType Type { get; set; }
        public string Cover { get; set; }
        public string Title { get; set; }

    }
}
