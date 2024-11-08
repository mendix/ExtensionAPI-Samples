# IMicroflowActivitiesService.CreateCreateListActivity method

It creates an [`IActionActivity`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActionActivity.md) which performs a [`ICreateListAction`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/ICreateListAction.md).

```csharp
public IActionActivity CreateCreateListActivity(IModel model, IEntity entity, 
    string outputVariableName)
```

| parameter | description |
| --- | --- |
| model | The current model of the application. |
| entity | The [`IEntity`](../../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IEntity.md) to create a list of. |
| outputVariableName | The name of the new list variable. |

## Return Value

An [`IActionActivity`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActionActivity.md) which performs a [`ICreateListAction`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/ICreateListAction.md).

## See Also

* interface [IActionActivity](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActionActivity.md)
* interface [IModel](../../Mendix.StudioPro.ExtensionsAPI.Model/IModel.md)
* interface [IEntity](../../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IEntity.md)
* interface [IMicroflowActivitiesService](../IMicroflowActivitiesService.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.Services](../../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->
