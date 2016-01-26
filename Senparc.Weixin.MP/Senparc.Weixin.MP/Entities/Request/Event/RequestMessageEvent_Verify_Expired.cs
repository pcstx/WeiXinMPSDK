using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senparc.Weixin.MP.Entities
{
    public class RequestMessageEvent_Verify_Expired : RequestMessageEventBase, IRequestMessageEventBase
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public override Event Event
        {
            get { return Event.verify_expired; }
        }

        /// <summary>
        /// 有效期
        /// </summary>
        public DateTime ExpiredTime { get; set; }

    }
}
