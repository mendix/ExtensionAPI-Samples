# IMicroflowActivitiesService.CreateListOperationActivity method

It creates an [`IActionActivity`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActionActivity.md) which performs a [`IListOperation`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IListOperation.md) action.

```csharp
public IActionActivity CreateListOperationActivity(IModel model, string listVariableName, 
    string outputVariableName, IListOperation listOperation)
```

| parameter | description |
| --- | --- |
| model | The current model of the application. |
| listVariableName | The list variable in scope to perform the operation on. |
| outputVariableName | The new result after the operation is performed. |
| listOperation | The [`IListOperation`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IListOperation.md) for the action |

## Return Value

An [`IActionActivity`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActionActivity.md) which performs a [`IListOperation`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IListOperation.md) action.

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | when the operation is a [`IBinaryListOperation`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IBinaryListOperation.md) and the 'SecondListOrObjectVariableName' property is not provided. |

## See Also

* interface [IActionActivity](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActionActivity.md)
* interface [IModel](../../Mendix.StudioPro.ExtensionsAPI.Model/IModel.md)
* interface [IListOperation](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IListOperation.md)
* interface [IMicroflowActivitiesService](../IMicroflowActivitiesService.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.Services](../../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->
