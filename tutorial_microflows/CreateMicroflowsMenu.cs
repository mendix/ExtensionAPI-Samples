using Mendix.StudioPro.ExtensionsAPI.UI.Menu;
using System.ComponentModel.Composition;

namespace MicroflowTutorial;

[Export(typeof(MenuExtension))]
[method: ImportingConstructor]
class CreateMicroflowsMenu(CalculationsMicroflowCreator microflowCreator) : MenuExtension
{
    public override IEnumerable<MenuViewModel> GetMenus()
    {
        yield return new MenuViewModel("Create microflows", () =>
        {
            if (CurrentApp == null)
                return;

            microflowCreator.CreateMicroflows(CurrentApp);
        });
    }
}
