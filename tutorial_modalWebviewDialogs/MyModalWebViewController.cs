using System.ComponentModel.Composition;
using Mendix.StudioPro.ExtensionsAPI.Model;
using Mendix.StudioPro.ExtensionsAPI.UI.Services;

namespace MyCompany.MyProject.MendixExtension;

[method: ImportingConstructor]
[Export(typeof(MyModalWebViewController))]
public class MyModalWebViewController(IDialogService dialogService, IMessageBoxService messageBoxService)
{
    public void ShowDialog(IModel currentApp, Uri webServerBaseUrl)
    {
        var modalViewModel = new MyModalWebViewViewModel("Modal WebView", currentApp, dialogService, messageBoxService, webServerBaseUrl)
        {
            Height = 160, Width = 400,
        };

        dialogService.ShowDialog(modalViewModel);
    }
}
