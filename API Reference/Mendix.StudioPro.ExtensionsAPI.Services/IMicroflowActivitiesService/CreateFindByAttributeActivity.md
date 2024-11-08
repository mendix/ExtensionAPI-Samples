# IMicroflowActivitiesService.CreateFindByAttributeActivity method

It creates an [`IActionActivity`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActionActivity.md) which performs a [`IFind`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IFind.md) action.

```csharp
public IActionActivity CreateFindByAttributeActivity(IModel model, IAttribute attribute, 
    string listVariableName, string outputVariableName, IMicroflowExpression findExpression)
```

| parameter | description |
| --- | --- |
| model | The current model of the application. |
| attribute | The [`IAttribute`](../../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IAttribute.md) used to perform the search. |
| listVariableName | The name of the list variable in scope to search. |
| outputVariableName | The name of the search result object. |
| findExpression | The [`IMicroflowExpression`](../../Mendix.StudioPro.ExtensionsAPI.Model.MicroflowExpressions/IMicroflowExpression.md) used to compare to the [`IAttribute`](../../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IAttribute.md). |

## Return Value

An [`IActionActivity`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActionActivity.md) which performs a [`IFind`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IFind.md) action.

## See Also

* interface [IActionActivity](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActionActivity.md)
* interface [IModel](../../Mendix.StudioPro.ExtensionsAPI.Model/IModel.md)
* interface [IAttribute](../../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IAttribute.md)
* interface [IMicroflowExpression](../../Mendix.StudioPro.ExtensionsAPI.Model.MicroflowExpressions/IMicroflowExpression.md)
* interface [IMicroflowActivitiesService](../IMicroflowActivitiesService.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.Services](../../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->
