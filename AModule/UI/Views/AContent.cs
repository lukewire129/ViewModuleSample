using Jamesnet.Wpf.Controls;
using System.Windows;

namespace AModule.UI.Views;

public class AContent : JamesContent
{
    static AContent()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(AContent), new FrameworkPropertyMetadata(typeof(AContent)));
    }
}