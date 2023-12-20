using Module.Core.Local.ViewModels;

namespace AModule.Local.ViewModels;

public partial class ModuleAViewModel : ModuleBaseViewModel
{
    public ModuleAViewModel()
    {
        this.Name = "ModuleAContent";
        this.Type = Module.Core.Local.Enums.ContentType.A;
    }
}
