# ExtensionUnloading class

An event that occurs when an extension will be unloaded.

```csharp
public sealed class ExtensionUnloading : IEvent
```

## Public Members

| name | description |
| --- | --- |
| [ExtensionUnloading](ExtensionUnloading/ExtensionUnloading.md)() | The default constructor. |

## Remarks

This event occurs when an app that contains the extension is closing, as well as when an extension is removed from the app, or before it is updated to a newer version. Note that this method is called when Studio Pro closes gracefully, but its execution is not guaranteed.

## See Also

* interface [IEvent](./IEvent.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.UI.Events](../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->