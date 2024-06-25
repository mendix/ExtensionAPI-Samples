using Mendix.StudioPro.ExtensionsAPI.UI.Menu;
using Mendix.StudioPro.ExtensionsAPI.UI.Services;
using System.ComponentModel.Composition;

namespace MyCompany.MyProject.MendixExtension;

[Export(typeof(MenuExtension))]
public class MyMenuExtension : MenuExtension
{
    readonly IMessageBoxService messageBoxService;

    [ImportingConstructor]
    public MyMenuExtension(IMessageBoxService messageBoxService)
    {
        this.messageBoxService = messageBoxService;
    }

    public override IEnumerable<MenuViewModel> GetMenus()
    {
        var ristretto = new MenuViewModel("Ristretto", () => messageBoxService.ShowInformation("Ristretto"));
        var regularExpresso = new MenuViewModel("Regular Espresso", () => messageBoxService.ShowInformation("Regular Espresso"));
        var espresso = new MenuViewModel("Espresso", [regularExpresso, ristretto]);
        var blackCoffee = new MenuViewModel("Black Coffee", () => messageBoxService.ShowInformation("Black Coffee"));
        var decaf = new MenuViewModel("Decaf", () => messageBoxService.ShowInformation("Decaf")) { Separator = MenuSeparator.After };
        var coffee = new MenuViewModel("Coffee", [blackCoffee, decaf, espresso]);

        var tea = new MenuViewModel("Tea", () => messageBoxService.ShowInformation("Tea"));

        var hot = new MenuViewModel("Hot", [coffee, tea]);

        var soda = new MenuViewModel("Soda", () => messageBoxService.ShowInformation("Soda"));
        var cold = new MenuViewModel("Cold", [soda]);

        var beverages = new MenuViewModel("Beverages", [hot, cold]);
        yield return beverages;
    }
}
