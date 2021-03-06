using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// Checked
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("E190F4F4-7C94-4CB3-BA4D-DDCDA7AC7693")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IWebView2DocumentTitleChangedEventHandler
	{
		void Invoke([In, MarshalAs(UnmanagedType.Interface)] IWebView2WebView3 webview, [In, MarshalAs(UnmanagedType.Interface)] object args);
	}
}