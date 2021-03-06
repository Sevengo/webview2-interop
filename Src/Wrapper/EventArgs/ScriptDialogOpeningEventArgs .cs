﻿#region License
// Copyright (c) 2019 Michael T. Russin
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion
using System;
using MtrDev.WebView2.Interop;

namespace MtrDev.WebView2.Wrapper
{
    public class ScriptDialogOpeningEventArgs : EventArgs
    {
        IWebView2ScriptDialogOpeningEventArgs _args;

        internal ScriptDialogOpeningEventArgs(IWebView2ScriptDialogOpeningEventArgs args)
        {
            _args = args;
        }

        public string Uri
        {
            get => _args.Uri; 
        }

        public WEBVIEW2_SCRIPT_DIALOG_KIND Kind
        {
            get => _args.Kind;
        }

        public string Message
        {
            get => _args.Message;
        }

        public void Accept()
        {
            _args.Accept();
        }

        public string DefaultText
        {
            get => _args.DefaultText;
        }

        public string ResultText
        {
            get => _args.ResultText;
            set => _args.ResultText = value;
        }

        public WebView2Deferral GetDeferral()
        {
            return new WebView2Deferral(_args.GetDeferral());
        }

        public override string ToString()
        {
            return string.Format("Uri={0}, Kind={1}, Message={4}, DefaultText={2}, ResultText={3},",
                Uri, Kind, DefaultText, ResultText, Message);
        }
    }
}
