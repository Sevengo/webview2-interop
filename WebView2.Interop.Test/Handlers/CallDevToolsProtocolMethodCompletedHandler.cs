﻿using System;
using MtrDev.WebView2.Interop;

namespace MtrDev.WinForms.Handlers
{
    internal class CallDevToolsProtocolMethodCompletedHandler : HandlerBase<CallDevToolsProtocolMethodCompletedEventArgs>, IWebView2CallDevToolsProtocolMethodCompletedHandler
    {
        public CallDevToolsProtocolMethodCompletedHandler(Action<CallDevToolsProtocolMethodCompletedEventArgs> callback) : base(callback)
        {
        }

        public void Invoke(int errorCode, string returnObjectAsJson)
        {
            CallDevToolsProtocolMethodCompletedEventArgs eventArgs = new CallDevToolsProtocolMethodCompletedEventArgs(errorCode, returnObjectAsJson);
            Callback(eventArgs);
        }
    }
}
