using CommunityToolkit.Mvvm.ComponentModel;
using Jamesnet.Wpf.Mvvm;
using Module.Core.Local.Enums;

namespace Module.Core.Local.ViewModels;
public partial class ModuleBaseViewModel : ObservableBase
{
    [ObservableProperty] string _name;
    [ObservableProperty] ContentType _type;
}
