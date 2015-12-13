﻿using NetworkSocket.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebsocketChatServer.Filters
{
    /// <summary>
    /// 昵称设置过滤器
    /// </summary>
    public class NickNameFilter : JsonWebSocketFilterAttribute
    {
        public NickNameFilter()
        {
            this.Order = -1;
        }

        protected override void OnExecuting(ActionContext filterContext)
        {
            if (filterContext.Session.TagBag.Name == null)
            {
                filterContext.Result = "请设置昵称后再聊天";
            }
        }
    }
}
