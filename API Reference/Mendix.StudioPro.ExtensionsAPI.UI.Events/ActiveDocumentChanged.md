# ActiveDocumentChanged class

An event that occurs when the active document in the app has changed.

```csharp
public class ActiveDocumentChanged : IEvent
```

## Public Members

| name | description |
| --- | --- |
| [DocumentName](ActiveDocumentChanged/DocumentName.md) { get; } | The name of the active document. It will return null if there is no current active document. |
| [DocumentType](ActiveDocumentChanged/DocumentType.md) { get; } | The type of the active document. It will return a string representing the type of the document even if the document itself it not currently supported by the API. It will return null if there is no current active document. |
| [GetDocument](ActiveDocumentChanged/GetDocument.md)(…) | This method will return the [`IAbstractUnit`](../Mendix.StudioPro.ExtensionsAPI.Model/IAbstractUnit.md) representing the document that has become active. If the document type is not yet supported by the API, it will return null. It will also return null if the current active document gets de-activated and no new document becomes active. |

## See Also

* interface [IEvent](./IEvent.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.UI.Events](../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->