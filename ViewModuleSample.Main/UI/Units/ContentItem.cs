using System.Windows;
using System.Windows.Controls;

namespace ViewModuleSample.Main.UI.Units;

public class ContentItem : ListBoxItem
{
    static ContentItem()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(ContentItem), new FrameworkPropertyMetadata(typeof(ContentItem)));
    }
}
