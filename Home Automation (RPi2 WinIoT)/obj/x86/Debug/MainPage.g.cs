﻿#pragma checksum "C:\Users\Anurag\Desktop\OneDrive\Hackster.io\Challenge\Microsoft Challenge\Final Release\Home Automation (RPi2 WinIoT)\Home Automation (RPi2 WinIoT)\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "673D11B7490EBE593E7AF3499DC11FD6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Home_Automation__RPi2_WinIoT_
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.Frame_Main = (global::Windows.UI.Xaml.Controls.Frame)(target);
                    #line 30 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Frame)this.Frame_Main).Navigated += this.Frame_Main_Navigated;
                    #line 30 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Frame)this.Frame_Main).Navigating += this.Frame_Main_Navigating;
                    #line default
                }
                break;
            case 2:
                {
                    this.Btn_Home = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 43 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.Btn_Home).Tapped += this.Btn_Home_Tapped;
                    #line default
                }
                break;
            case 3:
                {
                    this.Btn_ShowRooms = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 44 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.Btn_ShowRooms).Tapped += this.Btn_ShowRooms_Tapped;
                    #line default
                }
                break;
            case 4:
                {
                    this.Btn_ShowConfiguration = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 45 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.Btn_ShowConfiguration).Tapped += this.Btn_ShowConfiguration_Tapped;
                    #line default
                }
                break;
            case 5:
                {
                    this.Lbl_Time = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.Lbl_Date = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
