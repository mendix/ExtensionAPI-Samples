# ILogService.Error method

Logs a message at ERROR log level.

```csharp
public void Error(string message, Exception? exception = null, 
    [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "")
```

| parameter | description |
| --- | --- |
| message | the message |
| exception | the exception to log. if exception is null, it will not be logged. |
| memberName | optional member name, of the method or property where the message originates from. Uses [CallerMemberName] by default. |
| filePath | optional file path of the file where the message originates from. Uses [CallerFilePath] by default. |

## See Also

* interface [ILogService](../ILogService.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.Services](../../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->
