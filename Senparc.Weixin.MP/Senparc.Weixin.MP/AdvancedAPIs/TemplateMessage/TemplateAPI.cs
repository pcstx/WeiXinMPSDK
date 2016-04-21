/*----------------------------------------------------------------
    Copyright (C) 2015 Senparc
    
    文件名：TemplateAPI.cs
    文件功能描述：模板消息接口
    
    
    创建标识：Senparc - 20150211
    
    修改标识：Senparc - 20150303
    修改描述：整理接口
 
    修改标识：Senparc - 20150312
    修改描述：开放代理请求超时时间
----------------------------------------------------------------*/

/*
    API：http://mp.weixin.qq.com/wiki/17/304c1885ea66dbedf7dc170d84999a9d.html
 */

using Senparc.Weixin.Entities;
using Senparc.Weixin.MP.AdvancedAPIs.TemplateMessage; 
using Senparc.Weixin.MP.CommonAPIs;

namespace Senparc.Weixin.MP.AdvancedAPIs
{
    /// <summary>
    /// 模板消息接口
    /// </summary>
    public static class TemplateApi
    {
        /// <summary>
        /// 模板消息接口
        /// </summary>
        /// <param name="accessTokenOrAppId"></param>
        /// <param name="openId"></param>
        /// <param name="templateId"></param>
        /// <param name="topcolor"></param>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <param name="timeOut">代理请求超时时间（毫秒）</param>
        /// <returns></returns>
        public static SendTemplateMessageResult SendTemplateMessage(string accessTokenOrAppId, string openId, string templateId, string topcolor, string url, object data, int timeOut = Config.TIME_OUT)
        {
            return ApiHandlerWapper.TryCommonApi(accessToken =>
            {
                const string urlFormat = "https://api.weixin.qq.com/cgi-bin/message/template/send?access_token={0}";
                var msgData = new TempleteModel()
                {
                    touser = openId,
                    template_id = templateId,
                    topcolor = topcolor,
                    url = url,
                    data = data
                };
                return CommonJsonSend.Send<SendTemplateMessageResult>(accessToken, urlFormat, msgData, timeOut: timeOut);

            }, accessTokenOrAppId);
        }

        /// <summary>
        /// 设置所属行业
        /// </summary>
        /// <param name="accessTokenOrAppId"></param>
        public static WxJsonResult SetIndustry(string accessTokenOrAppId,string industryId1,string industryId2, int timeOut = Config.TIME_OUT)
        {
            return ApiHandlerWapper.TryCommonApi(accessToken =>
            {
                const string urlFormat = "https://api.weixin.qq.com/cgi-bin/template/api_set_industry?access_token={0}";
                var msgData = new
                {
                    industry_id1 = industryId1,
                    industry_id2 = industryId2
                };
                return CommonJsonSend.Send<WxJsonResult>(accessToken, urlFormat, msgData, timeOut: timeOut);

            }, accessTokenOrAppId);
        }

        /// <summary>
        /// 获取设置的行业信息
        /// </summary>
        /// <param name="accessTokenOrAppId"></param>
        /// <param name="timeOut"></param>
        public static GetIndustryResult GetIndustry(string accessTokenOrAppId, int timeOut = Config.TIME_OUT)
        {
            return ApiHandlerWapper.TryCommonApi(accessToken =>
            {
                const string urlFormat = "https://api.weixin.qq.com/cgi-bin/template/get_industry?access_token={0}";
                 
                return CommonJsonSend.Send<GetIndustryResult>(accessToken, urlFormat, null, timeOut: timeOut);

            }, accessTokenOrAppId);
        }

        /// <summary>
        /// 获得模板ID
        /// </summary>
        /// <param name="accessTokenOrAppId"></param>
        /// <param name="templateIdShort"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        public static AddTemplateResult AddTemplate(string accessTokenOrAppId, string templateIdShort, int timeOut = Config.TIME_OUT)
        {
            return ApiHandlerWapper.TryCommonApi(accessToken =>
            {
                const string urlFormat = "https://api.weixin.qq.com/cgi-bin/template/api_add_template?access_token={0}";
                var msgData = new
                {
                    template_id_short=templateIdShort
                };
                return CommonJsonSend.Send<AddTemplateResult>(accessToken, urlFormat, msgData, timeOut: timeOut);

            }, accessTokenOrAppId);
        }

        /// <summary>
        /// 获取模板列表
        /// </summary>
        /// <param name="accessTokenOrAppId"></param>
        public static TemplateListResult GetAllPrivateTemplate(string accessTokenOrAppId,string templateId, int timeOut = Config.TIME_OUT)
        {
            return ApiHandlerWapper.TryCommonApi(accessToken =>
            {
                const string urlFormat = "https://api.weixin.qq.com/cgi-bin/template/get_all_private_template?access_token={0}";
               
                return CommonJsonSend.Send<TemplateListResult>(accessToken, urlFormat, null, timeOut: timeOut);

            }, accessTokenOrAppId);
        }

        /// <summary>
        /// 删除模板
        /// </summary>
        public static WxJsonResult DelPrivateTemplate(string accessTokenOrAppId,string templateId, int timeOut = Config.TIME_OUT)
        {
            return ApiHandlerWapper.TryCommonApi(accessToken =>
            {
                const string urlFormat = "https://api.weixin.qq.com/cgi-bin/template/del_private_template?access_token={0}";
                var msgData = new
                {
                    template_id = templateId
                };
                return CommonJsonSend.Send<WxJsonResult>(accessToken, urlFormat, msgData, timeOut: timeOut);

            }, accessTokenOrAppId);
        }


    }
}