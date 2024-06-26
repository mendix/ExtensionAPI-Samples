# IDomainModelService.GetAnyAssociationsBetweenEntities method

It returns all [`EntityAssociation`](../../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/EntityAssociation.md) in the current app between two [`IEntity`](../../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IEntity.md) objects when both entities supplied are either the parent and the child.

```csharp
public IList<EntityAssociation> GetAnyAssociationsBetweenEntities(IModel currentApp, 
    IEntity entity1, IEntity entity2)
```

| parameter | description |
| --- | --- |
| currentApp | The current app. |
| entity1 | One [`IEntity`](../../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IEntity.md) on one side of the [`IAssociation`](../../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IAssociation.md). |
| entity2 | The other [`IEntity`](../../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IEntity.md) on one side of the [`IAssociation`](../../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IAssociation.md). |

## Return Value

List of [`EntityAssociation`](../../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/EntityAssociation.md)

## See Also

* record [EntityAssociation](../../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/EntityAssociation.md)
* interface [IModel](../../Mendix.StudioPro.ExtensionsAPI.Model/IModel.md)
* interface [IEntity](../../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IEntity.md)
* interface [IDomainModelService](../IDomainModelService.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.Services](../../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->
