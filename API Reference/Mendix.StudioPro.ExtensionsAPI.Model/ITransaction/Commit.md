# ITransaction.Commit method

Commit the transaction. That indicates that an atomic set of changes is completed and: saves all affected documents that are not currently being edited by a user; adds an undo item for the documents that are edited.

```csharp
public void Commit()
```

## See Also

* interface [ITransaction](../ITransaction.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.Model](../../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->
