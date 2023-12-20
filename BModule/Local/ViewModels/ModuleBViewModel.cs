using Module.Core.Local.ViewModels;

namespace BModule.Local.ViewModels;

public partial class ModuleBViewModel : ModuleBaseViewModel
{
    public ModuleBViewModel()
    {
        this.Name = "ModuleBContent";
        this.Type = Module.Core.Local.Enums.ContentType.B;
    }
}
