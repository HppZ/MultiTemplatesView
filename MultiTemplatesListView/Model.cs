using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTemplatesListView
{
    public class CardModel1
    {
        public string Title { get; set; }
        public List<CardItemModel> Items { get; set; }
    }

    public class CardModel2
    {
        public string Title { get; set; }
        public CardItemModel Header { get; set; }
        public List<CardItemModel> Items { get; set; }
    }


}
