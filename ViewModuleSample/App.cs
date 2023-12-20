using AModule.Local.ViewModels;
using AModule.UI.Views;
using BModule.Local.ViewModels;
using BModule.UI.Views;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Global.Location;
using Prism.Ioc;
using System.Windows;
using Unity;
using ViewModuleSample.Forms.UI.Views;
using ViewModuleSample.Main.Local.ViewModels;
using ViewModuleSample.Main.UI.Views;

namespace ViewModuleSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow> ();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            base.RegisterTypes (containerRegistry);

            containerRegistry.RegisterSingleton<IViewable,MainContent> ("MainContent");
        }

        protected override void RegisterWireDataContexts(ViewModelLocatorCollection items)
        {
            base.RegisterWireDataContexts (items);
            items.Register<MainContent, MainContentViewModel> ();
            items.Register<AContent, ModuleAViewModel> ();
            items.Register<BContent, ModuleBViewModel> ();
        }
    }
}
