# HandleWebRequestAsync delegate

Represents a method for handling a web request.

```csharp
public delegate Task HandleWebRequestAsync(HttpListenerRequest request, 
    HttpListenerResponse response, CancellationToken cancellationToken);
```

| parameter | description |
| --- | --- |
| request | An object representing the request made to the web server. |
| response | An object representing the response that will be sent back to the client. |
| cancellationToken | A cancellation token that can be used to detect when the request was cancelled. |

## Return Value

A Task instance.

## Remarks

Examine the Url property of the *request* parameter to determine the actual request URL for further processing.

## See Also

* namespace [Mendix.StudioPro.ExtensionsAPI.UI.WebServer](../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->
