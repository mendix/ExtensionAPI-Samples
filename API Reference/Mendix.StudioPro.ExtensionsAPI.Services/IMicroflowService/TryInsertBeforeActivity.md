# IMicroflowService.TryInsertBeforeActivity method

Inserts *activities* in a microflow directly before the *insertBeforeActivity*. This *insertBeforeActivity* must be connected in the microflow and must contain exactly 1 incoming [SequenceFlow](https://docs.mendix.com/refguide/sequence-flow).

```csharp
public bool TryInsertBeforeActivity(IActivity insertBeforeActivity, params IActivity[] activities)
```

| parameter | description |
| --- | --- |
| insertBeforeActivity | The activity in the microflow to act as reference point to insert the *activities*. |
| activities | List of activities to add before the *insertBeforeActivity* activity. |

## Return Value

Returns false if it does not have exactly 1 incoming [SequenceFlow](https://docs.mendix.com/refguide/sequence-flow).

## See Also

* interface [IActivity](../../Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActivity.md)
* interface [IMicroflowService](../IMicroflowService.md)
* namespace [Mendix.StudioPro.ExtensionsAPI.Services](../../Mendix.StudioPro.ExtensionsAPI.md)

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->
