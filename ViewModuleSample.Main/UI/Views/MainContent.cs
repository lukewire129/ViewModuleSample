﻿using Jamesnet.Wpf.Controls;
using System.Windows;

namespace ViewModuleSample.Main.UI.Views;

public class MainContent : JamesContent
{
    static MainContent()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(MainContent), new FrameworkPropertyMetadata(typeof(MainContent)));
    }
}