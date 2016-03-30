using Senparc.Weixin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senparc.Weixin.MP.AdvancedAPIs.Menu
{
    public class GetCurrentSelfmenuInfoResult: WxJsonResult
    {
        public int is_menu_open { get; set; }

        public SelfMenuInfo selfmenu_info { get; set; }

    }

    public class SelfMenuInfo
    {
        public List<Button> button { get; set; }
    }

    public class Button
    {
        public string name { get; set; }
        public string type { get; set; } 
        public string value { get; set; }
        public SubButton sub_button { get; set; }
    }

    public class SubButton
    {
        public List<List> list { get; set; }
    }

    public class List
    {
        public string type { get; set; }

        public string name { get; set; }

        public string url { get; set; }

        public NewsInfo news_info { get; set; }

        public string value { get; set; }
    }

    public class NewsInfo
    {
        public List<NewsInfoList> list { get; set; }
    }

    public class NewsInfoList
    {
        public string title { get; set; }

        public string author { get; set; }

        public string digest { get; set; }

        public int show_cover { get; set; }

        public string cover_url { get; set; }

        public string content_url { get; set; }

        public string source_url { get; set; }

    }

}
