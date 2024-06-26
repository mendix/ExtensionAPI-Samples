# IAppService interface

Provides a set of Studio Pro level operations related to Mendix App.

```csharp
public interface IAppService
```

## Members

| name | description |
| --- | --- |
| [CheckVersionCompatible](IAppService/CheckVersionCompatible.md)(…) | Verify whether an app/module created by a given *mendixVersion* of Studio Pro can be opened in the current Studio Pro. |
| [GetOnlineAppIDForCurrentAppAsync](IAppService/GetOnlineAppIDForCurrentAppAsync.md)() | Returns the App ID of the Mendix online app corresponding to the currently opened app in Studio Pro. This App ID allows you to build interactions with the Mendix online services. |
| [SynchronizeWithFileSystem](IAppService/SynchronizeWithFileSystem.md)(…) | Synchronize model representation in Studio Pro with the recent changes on the file system, like changes in JavaScript actions or Widgets. |
| [TryImportApp](IAppService/TryImportApp.md)(…) | Try to import a mpk project file as a new app. The user will get a dialog asking how to import the app. |
| [TryImportModule](IAppService/TryImportModule.md)(…) | Try to import a mpk file as a module to the app. If the module with the same name exists, user will get a dialog asking to replace it or to rename the importing module. |

## See Also

* namespace [Mendix.StudioPro.ExtensionsAPI.UI.Services](../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->
