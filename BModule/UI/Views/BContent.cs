using Jamesnet.Wpf.Controls;
using System.Windows;

namespace BModule.UI.Views;

public class BContent : JamesContent
{
    static BContent()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(BContent), new FrameworkPropertyMetadata(typeof(BContent)));
    }
}