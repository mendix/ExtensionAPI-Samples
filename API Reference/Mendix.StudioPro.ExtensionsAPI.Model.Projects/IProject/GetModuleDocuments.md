# IProject.GetModuleDocuments method (1 of 3)

Returns the full list of [`IDocument`](../IDocument.md)s contained in the app, and their type.

```csharp
public IReadOnlyList<(IDocument document, Type documentType)> GetModuleDocuments(IModule module)
```

| parameter | description |
| --- | --- |
| module | The module in which to search for documents. |

## Return Value

A list of all [`IDocument`](../IDocument.md)s contained in the [`IModule`](../IModule.md) provided.

## See Also

* interface [IDocument](../IDocument.md)
* interface [IModule](../IModule.md)
* interface [IProject](../IProject.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.Model.Projects](../../Mendix.StudioPro.ExtensionsAPI.md)

---

# IProject.GetModuleDocuments method (2 of 3)

Returns the full list of [`IDocument`](../IDocument.md)s contained in the app, by type.

```csharp
public IReadOnlyList<IDocument> GetModuleDocuments(IModule module, Type documentType)
```

| parameter | description |
| --- | --- |
| module | The module in which to search for documents. |
| documentType | The type of document. |

## Return Value

A list of all [`IDocument`](../IDocument.md)s contained in the [`IModule`](../IModule.md) provided, filtered by type.

## See Also

* interface [IDocument](../IDocument.md)
* interface [IModule](../IModule.md)
* interface [IProject](../IProject.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.Model.Projects](../../Mendix.StudioPro.ExtensionsAPI.md)

---

# IProject.GetModuleDocuments&lt;TDocument&gt; method (3 of 3)

Returns the full list of [`IDocument`](../IDocument.md)s contained in the app, by type.

```csharp
public IReadOnlyList<TDocument> GetModuleDocuments<TDocument>(IModule module)
    where TDocument : IDocument
```

| parameter | description |
| --- | --- |
| module | The module in which to search for documents. |

## Return Value

A list of all [`IDocument`](../IDocument.md)s contained in the [`IModule`](../IModule.md) provided, filtered by type.

## See Also

* interface [IModule](../IModule.md)
* interface [IDocument](../IDocument.md)
* interface [IProject](../IProject.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.Model.Projects](../../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->
