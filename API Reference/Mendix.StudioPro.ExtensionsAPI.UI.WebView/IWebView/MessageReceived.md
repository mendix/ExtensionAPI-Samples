# IWebView.MessageReceived event

MessageReceived is raised when a message is received that was sent from the web document in the web view. It can be used as a two-way communication channel with the web view in combination with [`PostMessage`](./PostMessage.md).

```csharp
public event EventHandler<MessageReceivedEventArgs> MessageReceived;
```

## Remarks

A message can be sent from the web document by calling the function `window.chrome.webview.postMessage(...)`. The web view expects the message to be an object with two properties, `message` and `data`. `message` should be a string that contains the message or message type. `data` is an optional object that contains additional data to be sent to the web view. The following code sample shows how to send a message from the web content:

```csharp
function sendMessage() {
  window.chrome.webview.postMessage({ message: "Message", data: { property1: "value1", property2: "value2" } });
}
```

## See Also

* class [MessageReceivedEventArgs](../MessageReceivedEventArgs.md)
* interface [IWebView](../IWebView.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.UI.WebView](../../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->