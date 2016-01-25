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
        public List<MenuFull_RootButton> button { get; set; }
    }

}
