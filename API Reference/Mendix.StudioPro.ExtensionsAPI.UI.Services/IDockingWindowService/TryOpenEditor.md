# IDockingWindowService.TryOpenEditor method

Tries to open an editor tab for the specified model unit.

```csharp
public bool TryOpenEditor(IAbstractUnit unit, IElement? elementToFocus = null)
```

| parameter | description |
| --- | --- |
| unit | The unit that will be opened in the editor. |
| elementToFocus | A UI element that should get the focus as soon as the editor is opened. |

## Return Value

`true` if the active editor was successfully determined; otherwise, `false`.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | When *unit* is null. |
| InvalidOperationException | When there is no app open in Studio Pro. |

## See Also

* interface [IAbstractUnit](../../Mendix.StudioPro.ExtensionsAPI.Model/IAbstractUnit.md)
* interface [IElement](../../Mendix.StudioPro.ExtensionsAPI.Model/IElement.md)
* interface [IDockingWindowService](../IDockingWindowService.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.UI.Services](../../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->