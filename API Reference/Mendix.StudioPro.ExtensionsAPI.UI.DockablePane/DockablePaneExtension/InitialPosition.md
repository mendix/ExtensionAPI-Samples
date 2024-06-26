# DockablePaneExtension.InitialPosition property

The dock where the pane is opened initially, if it hasn't been opened before. By default, Right.

```csharp
public virtual DockablePanePosition InitialPosition { get; }
```

## Remarks

Studio Pro user can drag the dockable pane to another position. That position is persisted (based on [`Id`](./Id.md)) and has precedence over the `InitialPosition`.

## See Also

* enum [DockablePanePosition](../DockablePanePosition.md)
* class [DockablePaneExtension](../DockablePaneExtension.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.UI.DockablePane](../../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->
