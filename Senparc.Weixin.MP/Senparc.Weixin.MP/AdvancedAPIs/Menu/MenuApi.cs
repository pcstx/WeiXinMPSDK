using Senparc.Weixin.CommonAPIs;
using Senparc.Weixin.MP.AdvancedAPIs.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senparc.Weixin.MP.AdvancedAPIs
{
    /// <summary>
    /// 获取公众号的菜单配置
    /// </summary>
    public static class MenuApi
    {
        public static GetCurrentSelfmenuInfoResult GetCurrentSelfmenuInfo(string accessTokenOrAppId)
        {
            return ApiHandlerWapper.TryCommonApi(accessToken =>
            {
                string urlFormat = "https://api.weixin.qq.com/cgi-bin/get_current_selfmenu_info?access_token={0}";

                return CommonJsonSend.Send<GetCurrentSelfmenuInfoResult>(accessToken, urlFormat, null, CommonJsonSendType.GET);

            }, accessTokenOrAppId);
        }

    }
}
