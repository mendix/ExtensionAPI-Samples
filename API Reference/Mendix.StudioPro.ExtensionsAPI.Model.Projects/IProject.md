# IProject interface

Representation of a whole [app](https://docs.mendix.com/apidocs-mxsdk/mxsdk/projects-metamodel) in metamodel.

```csharp
public interface IProject : IAbstractUnit
```

## Members

| name | description |
| --- | --- |
| [DirectoryPath](IProject/DirectoryPath.md) { get; } | Full path to app location on the file system. |
| [Name](IProject/Name.md) { get; } | Display name of the app. |
| [AddModule](IProject/AddModule.md)(…) | Adds your newly created module to your project. |
| [GetDocuments](IProject/GetDocuments.md)() | Returns the full list of [`IDocument`](./IDocument.md)s contained in the app, and their type, grouped by module with a Dictionary. |
| [GetDocuments](IProject/GetDocuments.md)(…) | Returns the full list of [`IDocument`](./IDocument.md)s contained in the app, by type, grouped by module with a Dictionary. |
| [GetDocuments&lt;TDocument&gt;](IProject/GetDocuments.md)() | Returns the full list of [`IDocument`](./IDocument.md)s contained in the app, by type, grouped by module with a Dictionary. |
| [GetModuleDocuments](IProject/GetModuleDocuments.md)(…) | Returns the full list of [`IDocument`](./IDocument.md)s contained in the app, and their type. (2 methods) |
| [GetModuleDocuments&lt;TDocument&gt;](IProject/GetModuleDocuments.md)(…) | Returns the full list of [`IDocument`](./IDocument.md)s contained in the app, by type. |
| [GetModules](IProject/GetModules.md)() | Returns the [`IModule`](./IModule.md)s contained by the app model at this moment. |
| [GetProjectDocuments](IProject/GetProjectDocuments.md)() | Returns the [`IProjectDocument`](./IProjectDocument.md)s contained by the app model at this moment. That includes [`IProjectSettings`](../Mendix.StudioPro.ExtensionsAPI.Model.Settings/IProjectSettings.md). |

## See Also

* interface [IAbstractUnit](../Mendix.StudioPro.ExtensionsAPI.Model/IAbstractUnit.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.Model.Projects](../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->
