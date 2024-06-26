# IMicroflowService.CreateMicroflow method

Creates a microflow and adds it to its containing folder. It initializes it with start and end nodes and the specified *parameters*. It uses ReturnType property of [`IMicroflow`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IMicroflow.md) to set the Return Type and its value, using the [`MicroflowReturnValue`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/MicroflowReturnValue.md) parameter./&gt;. The microflow must be added to the app model first before this method can be used.

```csharp
public IMicroflow CreateMicroflow(IModel model, IFolderBase container, string name, 
    MicroflowReturnValue? returnValue = null, params (string name, DataType type)[] parameters)
```

| parameter | description |
| --- | --- |
| model | The model in which the microflow will be created. |
| container | The folder or module in which the microflow will be added. |
| name | The name of the microflow. |
| returnValue | The [`MicroflowReturnValue`](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/MicroflowReturnValue.md) of the microflow. It has a [`DataType`](../../Mendix.StudioPro.ExtensionsAPI.Model.DataTypes/DataType.md) for the return type and a [`IMicroflowExpression`](../../Mendix.StudioPro.ExtensionsAPI.Model.MicroflowExpressions/IMicroflowExpression.md) for the return value. If not passed in, the return value will default to [`Void`](../../Mendix.StudioPro.ExtensionsAPI.Model.DataTypes/DataType/Void.md) without a return value. |
| parameters | List of parameters that are set in the microflow. |

## See Also

* interface [IMicroflow](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IMicroflow.md)
* interface [IModel](../../Mendix.StudioPro.ExtensionsAPI.Model/IModel.md)
* interface [IFolderBase](../../Mendix.StudioPro.ExtensionsAPI.Model.Projects/IFolderBase.md)
* record [MicroflowReturnValue](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/MicroflowReturnValue.md)
* class [DataType](../../Mendix.StudioPro.ExtensionsAPI.Model.DataTypes/DataType.md)
* interface [IMicroflowService](../IMicroflowService.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.Services](../../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->
