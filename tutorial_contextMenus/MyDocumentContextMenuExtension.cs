using Mendix.StudioPro.ExtensionsAPI.Model.Microflows;
using Mendix.StudioPro.ExtensionsAPI.Model.Pages;
using Mendix.StudioPro.ExtensionsAPI.Model.Projects;
using Mendix.StudioPro.ExtensionsAPI.UI.Menu;
using Mendix.StudioPro.ExtensionsAPI.UI.Services;
using System.ComponentModel.Composition;

namespace MyCompany.MyProject.MendixExtension;

[method: ImportingConstructor]
[Export(typeof(ContextMenuExtension<>))]
class MyDocumentContextMenuExtension(IMessageBoxService messageBoxService) : ContextMenuExtension<IDocument>
{
    public override IEnumerable<MenuViewModel> GetContextMenus(IDocument document)
    {
        if (document is IMicroflow microflow)
            yield return new MenuViewModel("This document is a  microflow", () => messageBoxService.ShowInformation(microflow.Name));

        else if (document is IPage page)
            yield return new MenuViewModel("This document is a  page", () => messageBoxService.ShowInformation(page.Name));
    }
}
