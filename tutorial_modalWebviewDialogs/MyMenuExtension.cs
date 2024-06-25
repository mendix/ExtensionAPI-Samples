using System.ComponentModel.Composition;
using Mendix.StudioPro.ExtensionsAPI.UI.Menu;

namespace MyCompany.MyProject.MendixExtension;

[Export(typeof(MenuExtension))]
[method: ImportingConstructor]
public class MyMenuExtension(MyModalWebViewController myModalWebViewController) : MenuExtension
{
    public override IEnumerable<MenuViewModel> GetMenus()
    {
        yield return new MenuViewModel("Create Entity From Dialog", () => myModalWebViewController.ShowDialog(CurrentApp!, WebServerBaseUrl));
    }
}
