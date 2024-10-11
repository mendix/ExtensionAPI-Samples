# IMicroflowActivitiesService.CreateDatabaseRetrieveSourceActivity method (1 of 2)

It creates an [`IActionActivity`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActionActivity.md) which performs a [`IRetrieveAction`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IRetrieveAction.md). This method is used to create the retrieve action which will only retrieve items from the database. It will also add a range of values for the retrieval of data from the database.

```csharp
public IActionActivity CreateDatabaseRetrieveSourceActivity(IModel model, 
    string outputVariableName, IEntity entity, string? xPathConstraint, 
    (IMicroflowExpression startingIndex, IMicroflowExpression amount) range, 
    params AttributeSorting[] attributesToSortBy)
```

| parameter | description |
| --- | --- |
| model | The current model of the application. |
| outputVariableName | The name of the object retrieved from the database. It could be a single item or a list. |
| entity | The [`IEntity`](../../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IEntity.md)to query the database for. |
| xPathConstraint | The condition the objects need to fulfill to be retrieved. If not supplied, all objects of the [`IEntity`](../../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IEntity.md) are retrieved. |
| range | One [`IMicroflowExpression`](../../Mendix.StudioPro.ExtensionsAPI.Model.MicroflowExpressions/IMicroflowExpression.md)for the starting index and one for the amount of items to retrieve. |
| attributesToSortBy | A set of [`IAttribute`](../../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IAttribute.md) to sort by. They can individually be either ascending or descending. |

## Return Value

An [`IActionActivity`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActionActivity.md) which performs a [`IRetrieveAction`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IRetrieveAction.md) for database retrieval with a custom range.

## See Also

* interface [IActionActivity](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActionActivity.md)
* interface [IModel](../../Mendix.StudioPro.ExtensionsAPI.Model/IModel.md)
* interface [IEntity](../../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IEntity.md)
* interface [IMicroflowExpression](../../Mendix.StudioPro.ExtensionsAPI.Model.MicroflowExpressions/IMicroflowExpression.md)
* record [AttributeSorting](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/AttributeSorting.md)
* interface [IMicroflowActivitiesService](../IMicroflowActivitiesService.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.Services](../../Mendix.StudioPro.ExtensionsAPI.md)

---

# IMicroflowActivitiesService.CreateDatabaseRetrieveSourceActivity method (2 of 2)

It creates an [`IActionActivity`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActionActivity.md) which performs a [`IRetrieveAction`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IRetrieveAction.md). This method is used to create the retrieve action which will only retrieve items from the database. It can be specified if it should retrieve all items or just the first item from the database.

```csharp
public IActionActivity CreateDatabaseRetrieveSourceActivity(IModel model, 
    string outputVariableName, IEntity entity, string? xPathConstraint, bool retrieveJustFirstItem, 
    params AttributeSorting[] attributesToSortBy)
```

| parameter | description |
| --- | --- |
| model | The current model of the application. |
| outputVariableName | The name of the object retrieved from the database. It could be a single item or a list. |
| entity | The [`IEntity`](../../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IEntity.md)to query the database for. |
| xPathConstraint | The condition the objects need to fulfill to be retrieved. If not supplied, all objects of the [`IEntity`](../../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IEntity.md) are retrieved. |
| retrieveJustFirstItem | If true, only the first item matching is returned. If false, all items are returned. |
| attributesToSortBy | A set of [`IAttribute`](../../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IAttribute.md) to sort by. They can individually be either ascending or descending. |

## Return Value

An [`IActionActivity`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActionActivity.md) which performs a [`IRetrieveAction`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IRetrieveAction.md) for database retrieval.

## See Also

* interface [IActionActivity](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActionActivity.md)
* interface [IModel](../../Mendix.StudioPro.ExtensionsAPI.Model/IModel.md)
* interface [IEntity](../../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IEntity.md)
* record [AttributeSorting](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/AttributeSorting.md)
* interface [IMicroflowActivitiesService](../IMicroflowActivitiesService.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.Services](../../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->
