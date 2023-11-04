﻿namespace IsaacSocket.Common
{
    internal enum Channel
    {
        //心跳包
        HEARTBEAT = 0,
        // WebSocket
        WEB_SOCKET_CLIENT = 1,
        //剪贴板
        CLIPBOARD = 2,
        //HTTP
        HTTP_CLIENT = 3,
        //以撒API
        ISAAC_API = 4
    }
}
