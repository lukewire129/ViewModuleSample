using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Global.Composition;
using System.Windows;

namespace ViewModuleSample.Forms.UI.Views;

public class MainWindow : DarkThemeWindow
{
    private readonly ContentManager _contentManager;

    static MainWindow()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(MainWindow), new FrameworkPropertyMetadata(typeof(MainWindow)));
    }

    public MainWindow(ContentManager contentManager)
    {
        this.Loaded += MainWindow_Loaded;
        this._contentManager = contentManager;
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
        _contentManager.ActiveContent ("MainRegion", "MainContent");
    }
}
