using System.ComponentModel;
using Mendix.StudioPro.ExtensionsAPI.Model;
using Mendix.StudioPro.ExtensionsAPI.Model.DomainModels;
using Mendix.StudioPro.ExtensionsAPI.UI.Dialogs;
using Mendix.StudioPro.ExtensionsAPI.UI.Services;
using Mendix.StudioPro.ExtensionsAPI.UI.WebView;

namespace MyCompany.MyProject.MendixExtension;

public class MyModalWebViewViewModel(
    string title,
    IModel currentApp,
    IDialogService dialogService,
    IMessageBoxService messageBoxService,
    Uri webServerBaseUrl) : WebViewModalDialogViewModel(title)
{
    public override void InitWebView(IWebView webView)
    {
        webView.MessageReceived += Browser_MessageReceived;
        OnClosing = HandleOnClosed;
        webView.Address = new Uri(webServerBaseUrl + "index");
    }

    void HandleOnClosed(CancelEventArgs cancelEventArgs) => messageBoxService.ShowInformation("Entity was created.");

    void Browser_MessageReceived(object? sender, MessageReceivedEventArgs e)
    {
        using var transaction = currentApp.StartTransaction("create entity from modal");

        var entity = currentApp.Create<IEntity>();
        entity.Name = e.Message.Replace("\\", "").Replace("\"", "");
        currentApp.Root.GetModules().First(m => m.Name == "MyFirstModule").DomainModel.AddEntity(entity);

        transaction.Commit();

        dialogService.CloseDialog(this);
    }
}
