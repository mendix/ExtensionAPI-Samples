# IAppService.CheckVersionCompatible method

Verify whether an app/module created by a given *mendixVersion* of Studio Pro can be opened in the current Studio Pro.

```csharp
public bool CheckVersionCompatible(IModel model, string mendixVersion, out string mismatchMessage)
```

| parameter | description |
| --- | --- |
| model | Reference to the current model. |
| mendixVersion | Semver v2 version string like `major.minor.patch`. |
| mismatchMessage | Description of incompatibility if the result is `false`. |

## Return Value

Whether an app in a given version can be opened in the current Studio Pro.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *mendixVersion* is null or empty. |
| ArgumentException | *mendixVersion* is in incorrect format. |

## See Also

* interface [IModel](../../Mendix.StudioPro.ExtensionsAPI.Model/IModel.md)
* interface [IAppService](../IAppService.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.UI.Services](../../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->
