﻿#pragma checksum "C:\Users\AMShishkin\Desktop\LifeChacksApp_1.6.8.0\LifeChackerApp\Pages\ListPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BF41A83592725A1BA5F3E0A497870E4D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34014
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace LifeChacksApp {
    
    
    public partial class ListPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard LPStartAnimation;
        
        internal System.Windows.Media.Animation.Storyboard SwipeAnimation;
        
        internal Microsoft.Phone.Shell.ApplicationBar AppBar;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton AppShow;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton AppListRemove;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton AppSave;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Shapes.Rectangle RecRay;
        
        internal System.Windows.Shapes.Rectangle rectangle;
        
        internal Microsoft.Phone.Controls.Pivot MainPivot;
        
        internal Microsoft.Phone.Controls.PivotItem PIFirst;
        
        internal System.Windows.Controls.ScrollViewer SVFirst;
        
        internal System.Windows.Controls.Grid GridFirst;
        
        internal System.Windows.Controls.TextBlock TBFirst;
        
        internal System.Windows.Controls.Image ImageFirst;
        
        internal System.Windows.Shapes.Rectangle RecImageFirst;
        
        internal Microsoft.Phone.Controls.PivotItem PISecond;
        
        internal System.Windows.Controls.ScrollViewer SVSecond;
        
        internal System.Windows.Controls.Grid GridSecond;
        
        internal System.Windows.Controls.TextBlock TBSecond;
        
        internal System.Windows.Controls.Image ImageSecond;
        
        internal System.Windows.Shapes.Rectangle RecImageSecond;
        
        internal Microsoft.Phone.Controls.PivotItem PIThird;
        
        internal System.Windows.Controls.ScrollViewer SVThird;
        
        internal System.Windows.Controls.Grid GridThird;
        
        internal System.Windows.Controls.TextBlock TBThird;
        
        internal System.Windows.Controls.Image ImageThird;
        
        internal System.Windows.Shapes.Rectangle RecImageThird;
        
        internal System.Windows.Shapes.Rectangle RecTitle;
        
        internal System.Windows.Controls.ProgressBar PBar;
        
        internal System.Windows.Shapes.Rectangle LikeLogo;
        
        internal System.Windows.Controls.TextBlock TBInfoPage;
        
        internal System.Windows.Controls.TextBlock TBLogo;
        
        internal System.Windows.Shapes.Rectangle Logo;
        
        internal System.Windows.Controls.Image ShowBigImage;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/LifeChacksApp;component/Pages/ListPage.xaml", System.UriKind.Relative));
            this.LPStartAnimation = ((System.Windows.Media.Animation.Storyboard)(this.FindName("LPStartAnimation")));
            this.SwipeAnimation = ((System.Windows.Media.Animation.Storyboard)(this.FindName("SwipeAnimation")));
            this.AppBar = ((Microsoft.Phone.Shell.ApplicationBar)(this.FindName("AppBar")));
            this.AppShow = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("AppShow")));
            this.AppListRemove = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("AppListRemove")));
            this.AppSave = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("AppSave")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.RecRay = ((System.Windows.Shapes.Rectangle)(this.FindName("RecRay")));
            this.rectangle = ((System.Windows.Shapes.Rectangle)(this.FindName("rectangle")));
            this.MainPivot = ((Microsoft.Phone.Controls.Pivot)(this.FindName("MainPivot")));
            this.PIFirst = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("PIFirst")));
            this.SVFirst = ((System.Windows.Controls.ScrollViewer)(this.FindName("SVFirst")));
            this.GridFirst = ((System.Windows.Controls.Grid)(this.FindName("GridFirst")));
            this.TBFirst = ((System.Windows.Controls.TextBlock)(this.FindName("TBFirst")));
            this.ImageFirst = ((System.Windows.Controls.Image)(this.FindName("ImageFirst")));
            this.RecImageFirst = ((System.Windows.Shapes.Rectangle)(this.FindName("RecImageFirst")));
            this.PISecond = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("PISecond")));
            this.SVSecond = ((System.Windows.Controls.ScrollViewer)(this.FindName("SVSecond")));
            this.GridSecond = ((System.Windows.Controls.Grid)(this.FindName("GridSecond")));
            this.TBSecond = ((System.Windows.Controls.TextBlock)(this.FindName("TBSecond")));
            this.ImageSecond = ((System.Windows.Controls.Image)(this.FindName("ImageSecond")));
            this.RecImageSecond = ((System.Windows.Shapes.Rectangle)(this.FindName("RecImageSecond")));
            this.PIThird = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("PIThird")));
            this.SVThird = ((System.Windows.Controls.ScrollViewer)(this.FindName("SVThird")));
            this.GridThird = ((System.Windows.Controls.Grid)(this.FindName("GridThird")));
            this.TBThird = ((System.Windows.Controls.TextBlock)(this.FindName("TBThird")));
            this.ImageThird = ((System.Windows.Controls.Image)(this.FindName("ImageThird")));
            this.RecImageThird = ((System.Windows.Shapes.Rectangle)(this.FindName("RecImageThird")));
            this.RecTitle = ((System.Windows.Shapes.Rectangle)(this.FindName("RecTitle")));
            this.PBar = ((System.Windows.Controls.ProgressBar)(this.FindName("PBar")));
            this.LikeLogo = ((System.Windows.Shapes.Rectangle)(this.FindName("LikeLogo")));
            this.TBInfoPage = ((System.Windows.Controls.TextBlock)(this.FindName("TBInfoPage")));
            this.TBLogo = ((System.Windows.Controls.TextBlock)(this.FindName("TBLogo")));
            this.Logo = ((System.Windows.Shapes.Rectangle)(this.FindName("Logo")));
            this.ShowBigImage = ((System.Windows.Controls.Image)(this.FindName("ShowBigImage")));
        }
    }
}

