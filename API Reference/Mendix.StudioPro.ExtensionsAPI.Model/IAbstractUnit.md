# IAbstractUnit interface

Representation of a single [unit](https://docs.mendix.com/apidocs-mxsdk/mxsdk/understanding-the-metamodel#1-units) in metamodel. This is an abstract unit, so all instances of [`IAbstractUnit`](./IAbstractUnit.md) implement more concrete interface like [`IFolder`](../Mendix.StudioPro.ExtensionsAPI.Model.Projects/IFolder.md).

```csharp
public interface IAbstractUnit : IStructure
```

## Members

| name | description |
| --- | --- |
| [Container](IAbstractUnit/Container.md) { get; } |  |
| [Id](IAbstractUnit/Id.md) { get; } | Unique identifier of the document. It does not change when a document is renamed or moved. |

## See Also

* interface [IStructure](./IStructure.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.Model](../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->