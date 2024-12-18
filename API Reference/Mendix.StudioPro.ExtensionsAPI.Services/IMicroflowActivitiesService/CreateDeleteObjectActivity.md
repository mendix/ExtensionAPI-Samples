# IMicroflowActivitiesService.CreateDeleteObjectActivity method

It creates an [`IActionActivity`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActionActivity.md) which performs a [`IDeleteAction`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IDeleteAction.md).

```csharp
public IActionActivity CreateDeleteObjectActivity(IModel model, string deleteVariableName)
```

| parameter | description |
| --- | --- |
| model | The current model of the application. |
| deleteVariableName | The name of the existing variable in scope to delete with this activity. |

## Return Value

An [`IActionActivity`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActionActivity.md) which performs a [`IDeleteAction`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IDeleteAction.md).

## See Also

* interface [IActionActivity](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActionActivity.md)
* interface [IModel](../../Mendix.StudioPro.ExtensionsAPI.Model/IModel.md)
* interface [IMicroflowActivitiesService](../IMicroflowActivitiesService.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.Services](../../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->
