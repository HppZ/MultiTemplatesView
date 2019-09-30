using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTemplatesListView
{
    public class Response
    {
        public Base _base { get; set; }
        public Channel channel { get; set; }
        public string code { get; set; }
        public Item[] items { get; set; }
    }

    public class Base
    {
    }

    public class Channel
    {
        public string status { get; set; }
        public string time_offline { get; set; }
        public string time_online { get; set; }
        public string title { get; set; }
    }

    public class Item
    {
        public string desc { get; set; }
        public string image_url { get; set; }
        public int order { get; set; }
        public string status { get; set; }
        public Temp temp { get; set; }
        public string time_offline { get; set; }
        public string time_online { get; set; }
        public string title { get; set; }
        public Video[] video { get; set; }
    }

    public class Temp
    {
        public int desc_status { get; set; }
        public int id { get; set; }
        public string rlcorner { get; set; }
        public int score { get; set; }
        public string target { get; set; }
        public string hoverImage { get; set; }
    }

    public class Video
    {
        public Datum[] data { get; set; }
    }

    public class Datum
    {
        public int album_id { get; set; }
        public string album_name { get; set; }
        public int channel_id { get; set; }
        public Date date { get; set; }
        public bool default_download_allowed { get; set; }
        public string desc { get; set; }
        public int film_id { get; set; }
        public string image_source { get; set; }
        public string image_url { get; set; }
        public bool is_episode { get; set; }
        public int order { get; set; }
        public string page_url { get; set; }
        public string pay_mark { get; set; }
        public string pay_mark_url { get; set; }
        public string play_url { get; set; }
        public float sns_score { get; set; }
        public int time_length { get; set; }
        public string title { get; set; }
        public long tv_id { get; set; }
        public long uploader_id { get; set; }
        public string vid { get; set; }
        public Blacklisted_Region_Full[] blacklisted_region_full { get; set; }
    }

    public class Date
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }
    }

    public class Blacklisted_Region_Full
    {
        public bool is_download_allowed { get; set; }
        public Location[] location { get; set; }
    }

    public class Location
    {
        public string province { get; set; }
        public int province_id { get; set; }
        public string country { get; set; }
        public int country_id { get; set; }
        public string area { get; set; }
        public int area_id { get; set; }
        public string area_spell { get; set; }
    }

}
