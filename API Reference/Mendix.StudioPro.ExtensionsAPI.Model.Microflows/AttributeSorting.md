# AttributeSorting record

When creating or filtering lists through an [`IActionActivity`](./IActionActivity.md) we can choose a few [`IAttribute`](../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IAttribute.md) to sort it by.

```csharp
public record AttributeSorting
```

## Public Members

| name | description |
| --- | --- |
| [AttributeSorting](AttributeSorting/AttributeSorting.md)(…) | When creating or filtering lists through an [`IActionActivity`](./IActionActivity.md) we can choose a few [`IAttribute`](../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IAttribute.md) to sort it by. |
| [Attribute](AttributeSorting/Attribute.md) { get; set; } | The [`IAttribute`](../Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IAttribute.md) whose value will be used to sort by. |
| [SortByDescending](AttributeSorting/SortByDescending.md) { get; set; } | It can be true or false. |

## See Also

* namespace [Mendix.StudioPro.ExtensionsAPI.Model.Microflows](../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->