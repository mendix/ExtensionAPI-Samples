# ConsistencyCheckExtension&lt;TCheckedStructure&gt;.Check method

Should be overriden in a derived class to perform consistency checks for a *TCheckedStructure*.

```csharp
public abstract IEnumerable<ConsistencyError> Check(TCheckedStructure structure, IModel model)
```

| parameter | description |
| --- | --- |
| structure | The [`IStructure`](../../Mendix.StudioPro.ExtensionsAPI.Model/IStructure.md) to be checked for consistency by this method. |
| model | Representation of the app model. Immutable. |

## Return Value

List of [`ConsistencyError`](../ConsistencyError.md) errors found in the *structure*.

## Remarks

`Check` is invoked after Studio Pro starts up or after the app structure has changed. Studio Pro heavily optimizes the consistency check process by tracking what model elements `Check` method accesses, and re-running it only when these elements change. Hence it is adviced to access as few model elements as possible in one [`ConsistencyCheckExtension`](../ConsistencyCheckExtension-1.md). Note that multiple consistency check can be ran in parallel and that one consistency check can be ran over multiple threads. Do not make any assumptions about order of execution of `Check` and do not rely on state in [`ConsistencyCheckExtension`](../ConsistencyCheckExtension-1.md).

## See Also

* class [ConsistencyError](../ConsistencyError.md)
* interface [IModel](../../Mendix.StudioPro.ExtensionsAPI.Model/IModel.md)
* class [ConsistencyCheckExtension&lt;TCheckedStructure&gt;](../ConsistencyCheckExtension-1.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.ConsistencyCheck](../../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->