using Senparc.Weixin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senparc.Weixin.MP.AdvancedAPIs.TemplateMessage
{
    public class GetIndustryResult : WxJsonResult
    {
        public IndustryResult primary_industry { get; set; }
        public IndustryResult secondary_industry { get; set; }
    }

    public class IndustryResult
    {
        public string first_class { get; set; }
        public string second_class { get; set; }
    }

}
