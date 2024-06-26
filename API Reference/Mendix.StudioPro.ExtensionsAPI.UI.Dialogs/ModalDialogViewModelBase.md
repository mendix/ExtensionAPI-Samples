# ModalDialogViewModelBase class

Representation of a modal popup dialog in Studio Pro. It is topmost and blocking. The only current allowed usage of this class is to implement the [`WebViewModalDialogViewModel`](./WebViewModalDialogViewModel.md) class, used to show a modal dialog containing a [`IWebView`](../Mendix.StudioPro.ExtensionsAPI.UI.WebView/IWebView.md) from [`ShowDialog`](../Mendix.StudioPro.ExtensionsAPI.UI.Services/IDialogService/ShowDialog.md).

```csharp
public abstract class ModalDialogViewModelBase : ViewModelBase
```

## Public Members

| name | description |
| --- | --- |
| [Height](ModalDialogViewModelBase/Height.md) { get; set; } | The height of the dialog. If not provided, the dialog will have a default size. It can be changed while the dialog is open. |
| [OnClosed](ModalDialogViewModelBase/OnClosed.md) { get; set; } | Optional action to execute when the dialog is closed. |
| [OnClosing](ModalDialogViewModelBase/OnClosing.md) { get; set; } | Optional action to execute when the user attempts to close the dialog. |
| [Title](ModalDialogViewModelBase/Title.md) { get; } | Title of the dialog. Empty by default. |
| [Width](ModalDialogViewModelBase/Width.md) { get; set; } | The width of the dialog. If not provided, the dialog will have a default size. |

## Remarks

A dialog can be opened with [`IDialogService`](../Mendix.StudioPro.ExtensionsAPI.UI.Services/IDialogService.md).

## See Also

* class [ViewModelBase](../Mendix.StudioPro.ExtensionsAPI.UI/ViewModelBase.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.UI.Dialogs](../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->
