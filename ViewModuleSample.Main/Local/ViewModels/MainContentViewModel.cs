using AModule.Local.ViewModels;
using BModule.Local.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;
using Jamesnet.Wpf.Mvvm;
using Module.Core.Local.ViewModels;

namespace ViewModuleSample.Main.Local.ViewModels;

public partial class MainContentViewModel : ObservableBase
{
    [ObservableProperty] List<ModuleBaseViewModel> moduleBaseViewModels;
    public MainContentViewModel()
    {
        this.ModuleBaseViewModels = new List<ModuleBaseViewModel>();
        this.ModuleBaseViewModels.Add (new ModuleAViewModel ());
        this.ModuleBaseViewModels.Add (new ModuleBViewModel ());
    }
}
