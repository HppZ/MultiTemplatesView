using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Management.Deployment;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MultiTemplatesListView
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<object> Source { get; }

        public MainPage()
        {
            this.InitializeComponent();

            Source = new ObservableCollection<object>();
            Loaded += MainPage_Loaded;
        }

        private async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Assets/topic.json"));
            var json = await FileIO.ReadTextAsync(file);
            var response = JsonConvert.DeserializeObject<Response>(json);

            foreach (var responseItem in response.items)
            {
                object card = null;

                var items = responseItem.video[0].data.Select(toCardItemModel).ToList();

                if (responseItem.temp.id % 2 == 0)
                {
                    card = new CardModel1()
                    {
                        Title = responseItem.title,
                        Header = items.First(),
                        Items = new List<CardItemModel>(items.Skip(1))
                    };
                }
                else
                {
                    card = new CardModel2()
                    {
                        Title = responseItem.title,
                        Items = items
                    };
                }
                Debug.Assert(card != null);
                Source.Add(card);
            }
        }

        CardItemModel toCardItemModel(Datum datum)
        {
            return new CardItemModel()
            {
                Title = datum.title,
                Cover = datum.image_url,
                Type = datum.channel_id % 2 == 0 ? CardType.Movie : CardType.Album
            };
        }
    }


    public class TemplateSelector1 : DataTemplateSelector
    {
        public DataTemplate Template1 { get; set; }
        public DataTemplate Template2 { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            switch (item)
            {
                case CardModel1 model:
                    return Template1;
                    break;

                case CardModel2 model:
                    return Template2;
                    break;
            }
            return Template1;
        }
    }

}
