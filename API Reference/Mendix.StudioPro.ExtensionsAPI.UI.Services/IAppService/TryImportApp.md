# IAppService.TryImportApp method

Try to import a mpk project file as a new app. The user will get a dialog asking how to import the app.

```csharp
public bool TryImportApp(IModel model, string mpkFilePath, string name)
```

| parameter | description |
| --- | --- |
| model | Reference to the current model. |
| mpkFilePath | Path to the mpk that should be imported. |
| name | Suggested name of the new app |

## Return Value

Flag indicating whether import was successful.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *name* or *mpkFilePath* is null or empty. |
| ArgumentException | *mpkFilePath* does not exist. |
| InvalidOperationException | *model* has a pending transaction which is not allowed. |

## Remarks

We advise you to use temporary directory for *mpkFilePath* and remove the file after import.

## See Also

* interface [IModel](../../Mendix.StudioPro.ExtensionsAPI.Model/IModel.md)
* interface [IAppService](../IAppService.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.UI.Services](../../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->