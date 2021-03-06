﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MtrDev.WebView2.Interop
{
    /// <summary>
    /// Defines properties that enable, disable, or modify WebView
    /// features. Setting changes made after NavigationStarting event will not
    /// apply until the next top level navigation.
    /// </summary>
    [ComVisible(true)]
    [ComImport]
    [Guid("9FC76F96-CFD8-4C92-8EC5-9215E92EF3E8")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWebView2Settings2 : IWebView2Settings
    {
        /// <summary>
        /// Controls if JavaScript execution is enabled in all future
        /// navigations in the WebView.  This only affects scripts in the document;
        /// scripts injected with ExecuteScript will run even if script is disabled.
        /// It is true by default.
        /// </summary>
        [DispId(1610678272)]
        new bool IsScriptEnabled
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
            [param: MarshalAs(UnmanagedType.Bool)]
            set;
        }

        /// <summary>
        /// The IsWebMessageEnabled property is used when loading a new
        /// HTML document. If set to true, communication from the host to the
        /// webview's top level HTML document is allowed via PostWebMessageAsJson,
        /// PostWebMessageAsString, and window.chrome.webview's message event
        /// (see PostWebMessageAsJson documentation for details).
        /// Communication from the webview's top level HTML document
        /// to the host is allowed via window.chrome.webview's postMessage function
        /// and the SetWebMessageReceivedEventHandler method (see the
        /// SetWebMessageReceivedEventHandler documentation for details).
        /// If set to false, then communication is disallowed.
        /// PostWebMessageAsJson and PostWebMessageAsString will
        /// fail with E_ACCESSDENIED and window.chrome.webview.postMessage will fail
        /// by throwing an instance of an Error object.
        /// It is true by default.
        /// </summary>
        [DispId(1610678274)]
        new bool IsWebMessageEnabled
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
            [param: MarshalAs(UnmanagedType.Bool)]
            set;
        }

        /// <summary>
        /// AreDefaultScriptDialogsEnabled is used when loading a new
        /// HTML document. If set to false, then WebView won't render the default
        /// javascript dialog box (Specifically those shown by the javascript alert,
        /// confirm, and prompt functions). Instead, if an event handler is set by
        /// SetScriptDialogOpeningEventHandler, WebView will send an event that will
        /// contain all of the information for the dialog and allow the host app to
        /// show its own custom UI.
        /// </summary>
        [DispId(1610678276)]
        new bool AreDefaultScriptDialogsEnabled
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
            [param: MarshalAs(UnmanagedType.Bool)]
            set;
        }

        /// <summary>
        /// TODO: remove this for the next breaking change:
        /// https://microsoft.visualstudio.com/Edge/_workitems/edit/20699378
        ///
        /// This setting is deprecated and will always return false. That means
        /// elements in the WebView will only fill the WebView bounds. This property
        /// will then be completely removed. Please listen to the
        /// ContainsFullScreenElementChanged event instead.
        ///
        /// Controls if fullscreen is allowed for elements in the WebView.
        /// When it is allowed, web content such as a video element in the WebView
        /// is allowed to be displayed full screen.
        /// When it is not allowed, such element will fill the WebView bounds when
        /// the element requests full screen.
        /// It is true by default.        
        /// </summary>
        [DispId(1610678278)]
        new bool IsFullscreenAllowed_deprecated
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
            [param: MarshalAs(UnmanagedType.Bool)]
            set;
        }

        /// <summary>
        /// IsStatusBarEnabled controls whether the status bar will be displayed. The
        /// status bar is usually displayed in the lower left of the WebView and shows
        /// things such as the URI of a link when the user hovers over it and other
        /// information. It is true by default.
        /// </summary>
        [DispId(1610678280)]
        new bool IsStatusBarEnabled
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
            [param: MarshalAs(UnmanagedType.Bool)]
            set;
        }

        /// <summary>
        /// AreDevToolsEnabled controls whether the user is able to use the context
        /// menu or keyboard shortcuts to open the DevTools window.
        /// It is true by default.
        /// </summary>
        [DispId(1610678282)]
        new bool AreDevToolsEnabled
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
            [param: MarshalAs(UnmanagedType.Bool)]
            set;
        }

        /// <summary>
        /// The AreDefaultContextMenusEnabled property is used to prevent
        /// default context menus from being shown to user in webview. Defaults to TRUE.
        /// </summary>
        [DispId(1610743808)]
        bool AreDefaultContextMenusEnabled
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            get;
            [param: MarshalAs(UnmanagedType.Bool)]
            set;
        }
    }
}