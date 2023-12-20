using System.Windows;
using System.Windows.Controls;

namespace ViewModuleSample.Main.UI.Units;

public class ContentBox: ListBox
{
    static ContentBox()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(ContentBox), new FrameworkPropertyMetadata(typeof(ContentBox)));
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new ContentItem ();
    }
}
