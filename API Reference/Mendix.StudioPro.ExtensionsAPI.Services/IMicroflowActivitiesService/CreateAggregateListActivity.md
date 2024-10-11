# IMicroflowActivitiesService.CreateAggregateListActivity method

It creates an [`IActionActivity`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActionActivity.md) which performs a [`IAggregateListAction`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IAggregateListAction.md).

```csharp
public IActionActivity CreateAggregateListActivity(IModel model, string inputListVariableName, 
    string outputVariableName, AggregateFunctionEnum aggregateFunction)
```

| parameter | description |
| --- | --- |
| model | The current model of the application. |
| inputListVariableName | The list variable in scope which is the input for the aggregate function |
| outputVariableName | The new result after the aggregate function is performed |
| aggregateFunction | The type of aggregate function. |

## Return Value

An [`IActionActivity`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActionActivity.md) which performs a [`IAggregateListAction`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IAggregateListAction.md).

## See Also

* interface [IActionActivity](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActionActivity.md)
* interface [IModel](../../Mendix.StudioPro.ExtensionsAPI.Model/IModel.md)
* enum [AggregateFunctionEnum](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows.Actions/AggregateFunctionEnum.md)
* interface [IMicroflowActivitiesService](../IMicroflowActivitiesService.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.Services](../../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->