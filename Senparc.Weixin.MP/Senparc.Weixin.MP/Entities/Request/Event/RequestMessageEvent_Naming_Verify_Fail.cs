using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senparc.Weixin.MP.Entities
{
    public class RequestMessageEvent_Naming_Verify_Fail : RequestMessageEventBase, IRequestMessageEventBase
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public override Event Event
        {
            get { return Event.naming_verify_fail; }
        }

        /// <summary>
        /// 失败发生时间
        /// </summary>
        public DateTime FailTime { get; set; }

        /// <summary>
        /// 认证失败的原因
        /// </summary>
        public string FailReason { get; set; }

    }
}
