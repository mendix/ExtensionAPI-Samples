using System.ComponentModel.Composition;
using System.Text;
using Mendix.StudioPro.ExtensionsAPI.UI.WebServer;

namespace MyCompany.MyProject.MendixExtension;

[Export(typeof(WebServerExtension))]
public class ContentServer : WebServerExtension
{
    private const string Content = """
<html>
  <head>
      <script>
          function sendMessage(message, data) {
              if (window.chrome?.webview) {
                  window.chrome.webview.postMessage({ message, data })
              } else if (window.webkit?.messageHandlers.studioPro) {
                  window.webkit.messageHandlers.studioPro.postMessage(JSON.stringify({ message, data }))
              }
          }
          function registerMessageListener(eventHandler) {
              if (window.chrome?.webview) {
                  window.chrome.webview.addEventListener("message", (event) => eventHandler(event.data))
                  sendMessage("MessageListenerRegistered")
              } else if (window.webkit?.messageHandlers.studioPro) {
                  window.WKPostMessage = (json) => {
                      const wkMessage = JSON.parse(json)
                      eventHandler(wkMessage)
                  }
                  sendMessage("MessageListenerRegistered")
              }
          }
          function init() {
              registerMessageListener(msgHandler);
          }
          function msgHandler(event) {
              console.log('message sent to JS: '+event.data);
          }
          function create() {
              sendMessage(document.getElementById("entity_name").value, null);
          }
      </script>
  </head>
  <body onload="init()">
      <div>
          <p>Entity Name</p>
          <input type="text" style="width: 150px" id="entity_name"/>
          <p><button onclick="create();">Create Entity</button></p>
      </div>
  </body>
</html>
""";

    public override void InitializeWebServer(IWebServer webServer)
    {
        webServer.AddRoute("index", async (_, response, _) =>
        {
            response.ContentType = "text/html";
            response.StatusCode = 200;
            var content = Encoding.ASCII.GetBytes(Content);
            response.ContentLength64 = content.Length;
            await response.OutputStream.WriteAsync(content, CancellationToken.None);
        });
    }
}
