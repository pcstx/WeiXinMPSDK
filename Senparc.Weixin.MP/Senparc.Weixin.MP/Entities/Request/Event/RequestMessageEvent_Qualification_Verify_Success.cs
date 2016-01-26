using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senparc.Weixin.MP.Entities
{
    public class RequestMessageEvent_Qualification_Verify_Success: RequestMessageEventBase, IRequestMessageEventBase
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public override Event Event
        {
            get { return Event.qualification_verify_success; }
        }

        /// <summary>
        /// 有效期
        /// </summary>
        public DateTime ExpiredTime { get; set; }

    }
}
