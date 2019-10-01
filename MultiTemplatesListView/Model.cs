using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MultiTemplatesListView
{
    public class ItemSelector : DataTemplateSelector
    {
        public DataTemplate Template1 { get; set; }
        public DataTemplate Template2 { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            if (item == null)
            {

            }
            switch (item)
            {
                case CardItemModel model:
                    {
                        switch (model.Type)
                        {
                            case CardType.Movie:
                                return Template1;
                            case CardType.Album:
                                return Template2;
                        }
                    }
                    break;
            }

            return Template1;
        }
    }

    public class CardModel1
    {
        public string Title { get; set; }
        public CardItemModel Header { get; set; }
        public List<CardItemModel> Items { get; set; }
    }

    public class CardModel2
    {
        public string Title { get; set; }
        public List<CardItemModel> Items { get; set; }
    }
}
