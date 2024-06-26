# SelectorResult&lt;TStructure&gt;.Selection property

The selected model element. Can be

```csharp
null
```

in case the dialog was canceled (see [`IsCanceled`](./IsCanceled.md)), or when the 'None' button was clicked.

```csharp
public TStructure? Selection { get; }
```

## Remarks

Should only be used when [`IsCanceled`](./IsCanceled.md) is

```csharp
false
```

. Otherwise the value will be

```csharp
null
```

.

## See Also

* class [SelectorResult&lt;TStructure&gt;](../SelectorResult-1.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.UI.Services](../../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->
