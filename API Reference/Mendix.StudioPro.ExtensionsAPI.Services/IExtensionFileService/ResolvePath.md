# IExtensionFileService.ResolvePath method

Returns the full path to a file included in the calling extension, relative to the root directory containing the extension.

```csharp
public string ResolvePath(params string[] pathSegments)
```

| parameter | description |
| --- | --- |
| pathSegments | Segments of the path to the file inside the root directory of the extension. E.g. "config"(directory),"config.json"(file) |

## See Also

* interface [IExtensionFileService](../IExtensionFileService.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.Services](../../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->