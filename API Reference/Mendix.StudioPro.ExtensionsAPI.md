# Mendix.StudioPro.ExtensionsAPI assembly

## Mendix.StudioPro.ExtensionsAPI namespace

| public type | description |
| --- | --- |
| abstract class [ExtensionBase](./Mendix.StudioPro.ExtensionsAPI/ExtensionBase.md) | Base class for all extensions. Do not inherit from this class directly, but use concrete extension points like [`ConsistencyCheckExtension`](./Mendix.StudioPro.ExtensionsAPI.ConsistencyCheck/ConsistencyCheckExtension-1.md). |
| interface [IConfiguration](./Mendix.StudioPro.ExtensionsAPI/IConfiguration.md) | Global Studio Pro configuration that can depend on environment or user-defined settings. |
| interface [IHttpClient](./Mendix.StudioPro.ExtensionsAPI/IHttpClient.md) | Provides a class for sending HTTP requests and receiving HTTP responses from a resource identified by a URI. |
| enum [ServicesEnvironment](./Mendix.StudioPro.ExtensionsAPI/ServicesEnvironment.md) | Represents a versions of global services accessed by Studio Pro. |
| enum [ThemeSupport](./Mendix.StudioPro.ExtensionsAPI/ThemeSupport.md) | Represents a user interface theme in Studio Pro. |

## Mendix.StudioPro.ExtensionsAPI.BackgroundJobs namespace

| public type | description |
| --- | --- |
| class [BackgroundJob](./Mendix.StudioPro.ExtensionsAPI.BackgroundJobs/BackgroundJob.md) | It represents a collection of [`BackgroundJobStep`](./Mendix.StudioPro.ExtensionsAPI.BackgroundJobs/BackgroundJobStep.md) which will run in sequence. |
| class [BackgroundJobStep](./Mendix.StudioPro.ExtensionsAPI.BackgroundJobs/BackgroundJobStep.md) | A step of a background job. |

## Mendix.StudioPro.ExtensionsAPI.ConsistencyCheck namespace

| public type | description |
| --- | --- |
| abstract class [ConsistencyCheckExtension&lt;TCheckedStructure&gt;](./Mendix.StudioPro.ExtensionsAPI.ConsistencyCheck/ConsistencyCheckExtension-1.md) | Base class for an extension that introduces new [consistency errors (warnings)](https://docs.mendix.com/refguide/consistency-errors/) for specific model elements. |
| class [ConsistencyError](./Mendix.StudioPro.ExtensionsAPI.ConsistencyCheck/ConsistencyError.md) | Represents consistency check errors in Studio Pro and MxBuild. |
| enum [Severity](./Mendix.StudioPro.ExtensionsAPI.ConsistencyCheck/Severity.md) |  |

## Mendix.StudioPro.ExtensionsAPI.Drawing namespace

| public type | description |
| --- | --- |
| class [StudioProImage](./Mendix.StudioPro.ExtensionsAPI.Drawing/StudioProImage.md) | Represents an image shown in the UI of Studio Pro. |

## Mendix.StudioPro.ExtensionsAPI.Model namespace

| public type | description |
| --- | --- |
| interface [IAbstractUnit](./Mendix.StudioPro.ExtensionsAPI.Model/IAbstractUnit.md) | Representation of a single [unit](https://docs.mendix.com/apidocs-mxsdk/mxsdk/understanding-the-metamodel#1-units) in metamodel. This is an abstract unit, so all instances of [`IAbstractUnit`](./Mendix.StudioPro.ExtensionsAPI.Model/IAbstractUnit.md) implement more concrete interface like [`IFolder`](./Mendix.StudioPro.ExtensionsAPI.Model.Projects/IFolder.md). |
| interface [IElement](./Mendix.StudioPro.ExtensionsAPI.Model/IElement.md) | Representation of a single [element](https://docs.mendix.com/apidocs-mxsdk/mxsdk/understanding-the-metamodel#2-elements) in metamodel. This is an abstract element, so all instances of [`IElement`](./Mendix.StudioPro.ExtensionsAPI.Model/IElement.md) also implement more concrete interface like [`IMicroflow`](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IMicroflow.md). |
| interface [IModel](./Mendix.StudioPro.ExtensionsAPI.Model/IModel.md) | Representation of Mendix app loaded in Studio Pro in terms of [Mendix Metamodel](https://docs.mendix.com/apidocs-mxsdk/mxsdk/understanding-the-metamodel). |
| interface [IQualifiedName&lt;T&gt;](./Mendix.StudioPro.ExtensionsAPI.Model/IQualifiedName-1.md) | Represents a [by-name reference](https://docs.mendix.com/apidocs-mxsdk/mxsdk/understanding-the-metamodel#3-1-references) to an object (element or unit) or type *T* in metamodel. The reference can be resolved to retrieve the object it is referencing. |
| interface [IQualifiedName](./Mendix.StudioPro.ExtensionsAPI.Model/IQualifiedName.md) | Represents a [by-name reference](https://docs.mendix.com/apidocs-mxsdk/mxsdk/understanding-the-metamodel#3-1-references) to an object (element or unit) in metamodel. The type of the referenced object is not statically known. |
| interface [IReferableStructure](./Mendix.StudioPro.ExtensionsAPI.Model/IReferableStructure.md) | Represents any model object that is referable by-name, i.e. where the concrete type has a |
| interface [IStructure](./Mendix.StudioPro.ExtensionsAPI.Model/IStructure.md) | Representation of a single [unit](https://docs.mendix.com/apidocs-mxsdk/mxsdk/understanding-the-metamodel#1-units) or [element](https://docs.mendix.com/apidocs-mxsdk/mxsdk/understanding-the-metamodel#2-elements) in metamodel. All instances of [`IAbstractUnit`](./Mendix.StudioPro.ExtensionsAPI.Model/IAbstractUnit.md) and [`IElement`](./Mendix.StudioPro.ExtensionsAPI.Model/IElement.md) implement this interface. |
| interface [ITransaction](./Mendix.StudioPro.ExtensionsAPI.Model/ITransaction.md) | Transaction grouping the changes in the app model. |
| struct [Location](./Mendix.StudioPro.ExtensionsAPI.Model/Location.md) | This record represents a set of two-dimensional coordinates. |

## Mendix.StudioPro.ExtensionsAPI.Model.CodeActions namespace

| public type | description |
| --- | --- |
| interface [ICodeActionParameter](./Mendix.StudioPro.ExtensionsAPI.Model.CodeActions/ICodeActionParameter.md) |  |

## Mendix.StudioPro.ExtensionsAPI.Model.Constants namespace

| public type | description |
| --- | --- |
| interface [IConstant](./Mendix.StudioPro.ExtensionsAPI.Model.Constants/IConstant.md) |  |

## Mendix.StudioPro.ExtensionsAPI.Model.DataTypes namespace

| public type | description |
| --- | --- |
| class [BinaryType](./Mendix.StudioPro.ExtensionsAPI.Model.DataTypes/BinaryType.md) | Represents the Binary data type. |
| class [BooleanType](./Mendix.StudioPro.ExtensionsAPI.Model.DataTypes/BooleanType.md) | Represents the Boolean data type. |
| abstract class [DataType](./Mendix.StudioPro.ExtensionsAPI.Model.DataTypes/DataType.md) | Represents Mendix data types used in the app model and related places, such as microflow variables. |
| class [DateTimeType](./Mendix.StudioPro.ExtensionsAPI.Model.DataTypes/DateTimeType.md) | Represents the DateTime data type. |
| class [DecimalType](./Mendix.StudioPro.ExtensionsAPI.Model.DataTypes/DecimalType.md) | Represents the Decimal data type. |
| class [EmptyType](./Mendix.StudioPro.ExtensionsAPI.Model.DataTypes/EmptyType.md) | Represents the empty value. |
| abstract class [EntityType](./Mendix.StudioPro.ExtensionsAPI.Model.DataTypes/EntityType.md) | Base class for data types representing one or more instances of a certain entity. |
| class [EnumerationType](./Mendix.StudioPro.ExtensionsAPI.Model.DataTypes/EnumerationType.md) | Represents an enumeration data type. |
| class [FloatType](./Mendix.StudioPro.ExtensionsAPI.Model.DataTypes/FloatType.md) | Represents the Float data type. |
| class [IntegerType](./Mendix.StudioPro.ExtensionsAPI.Model.DataTypes/IntegerType.md) | Represents the Integer data type. |
| class [ListType](./Mendix.StudioPro.ExtensionsAPI.Model.DataTypes/ListType.md) | Represents a data type for a list of objects of a certain entity. |
| class [ObjectType](./Mendix.StudioPro.ExtensionsAPI.Model.DataTypes/ObjectType.md) | Represents a data type for a single object of a certain entity. |
| class [StringType](./Mendix.StudioPro.ExtensionsAPI.Model.DataTypes/StringType.md) | Represents the String data type. |
| class [UnknownType](./Mendix.StudioPro.ExtensionsAPI.Model.DataTypes/UnknownType.md) | Represents an unknown data type. |
| class [VoidType](./Mendix.StudioPro.ExtensionsAPI.Model.DataTypes/VoidType.md) | Represents the Void data type. |

## Mendix.StudioPro.ExtensionsAPI.Model.DomainModels namespace

| public type | description |
| --- | --- |
| enum [ActionMoment](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/ActionMoment.md) |  |
| enum [AssociationDirection](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/AssociationDirection.md) | It determines which type of [`IAssociation`](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IAssociation.md) should be returned when searching for them. If Parent, only associations where the [`IEntity`](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IEntity.md) requested is the parent will be returned. If Child, only associations where the [`IEntity`](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IEntity.md) requested is the child will be returned. Or any associations if Both is used. |
| enum [AssociationOwner](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/AssociationOwner.md) | This property defines whether an [`association`](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IAssociation.md) has one or two owners. If there is one owner, the owner is located at the start of the arrow. |
| [Flags] enum [AssociationType](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/AssociationType.md) | This property defines whether an [`association`](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IAssociation.md) is a reference (single) or a reference set (plural). |
| enum [DeletingBehavior](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/DeletingBehavior.md) | The behavior which occurs when deleting one side of an [`association`](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IAssociation.md). |
| record [EntityAssociation](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/EntityAssociation.md) | It represents an [`IAssociation`](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IAssociation.md) between two [`IEntity`](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IEntity.md) objects. |
| enum [EventType](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/EventType.md) |  |
| interface [IAssociation](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IAssociation.md) |  |
| interface [IAttribute](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IAttribute.md) |  |
| interface [IAttributeType](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IAttributeType.md) |  |
| interface [IAutoNumberAttributeType](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IAutoNumberAttributeType.md) |  |
| interface [IBinaryAttributeType](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IBinaryAttributeType.md) |  |
| interface [IBooleanAttributeType](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IBooleanAttributeType.md) |  |
| interface [ICalculatedValue](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/ICalculatedValue.md) |  |
| interface [IDateTimeAttributeType](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IDateTimeAttributeType.md) |  |
| interface [IDecimalAttributeType](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IDecimalAttributeType.md) |  |
| interface [IDecimalAttributeTypeBase](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IDecimalAttributeTypeBase.md) |  |
| interface [IDomainModel](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IDomainModel.md) |  |
| interface [IEntity](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IEntity.md) |  |
| interface [IEnumerationAttributeType](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IEnumerationAttributeType.md) |  |
| interface [IEventHandler](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IEventHandler.md) |  |
| interface [IGeneralization](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IGeneralization.md) |  |
| interface [IGeneralizationBase](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IGeneralizationBase.md) |  |
| interface [IHashedStringAttributeType](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IHashedStringAttributeType.md) |  |
| interface [IIntegerAttributeType](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IIntegerAttributeType.md) |  |
| interface [IIntegerAttributeTypeBase](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IIntegerAttributeTypeBase.md) |  |
| interface [ILongAttributeType](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/ILongAttributeType.md) |  |
| interface [IMappedValue](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IMappedValue.md) |  |
| interface [INoGeneralization](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/INoGeneralization.md) |  |
| interface [INumericAttributeTypeBase](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/INumericAttributeTypeBase.md) |  |
| interface [IStoredValue](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IStoredValue.md) |  |
| interface [IStringAttributeType](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IStringAttributeType.md) |  |
| interface [IValueType](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IValueType.md) |  |

## Mendix.StudioPro.ExtensionsAPI.Model.Enumerations namespace

| public type | description |
| --- | --- |
| interface [IEnumeration](./Mendix.StudioPro.ExtensionsAPI.Model.Enumerations/IEnumeration.md) |  |
| interface [IEnumerationValue](./Mendix.StudioPro.ExtensionsAPI.Model.Enumerations/IEnumerationValue.md) |  |
| interface [IRemoteEnumerationValue](./Mendix.StudioPro.ExtensionsAPI.Model.Enumerations/IRemoteEnumerationValue.md) |  |

## Mendix.StudioPro.ExtensionsAPI.Model.Images namespace

| public type | description |
| --- | --- |
| interface [IImage](./Mendix.StudioPro.ExtensionsAPI.Model.Images/IImage.md) |  |

## Mendix.StudioPro.ExtensionsAPI.Model.JavaActions namespace

| public type | description |
| --- | --- |
| interface [IJavaAction](./Mendix.StudioPro.ExtensionsAPI.Model.JavaActions/IJavaAction.md) |  |
| interface [IJavaActionParameter](./Mendix.StudioPro.ExtensionsAPI.Model.JavaActions/IJavaActionParameter.md) |  |

## Mendix.StudioPro.ExtensionsAPI.Model.MicroflowExpressions namespace

| public type | description |
| --- | --- |
| interface [IMicroflowExpression](./Mendix.StudioPro.ExtensionsAPI.Model.MicroflowExpressions/IMicroflowExpression.md) | Represents a microflow expression like "$employee/Name". |

## Mendix.StudioPro.ExtensionsAPI.Model.Microflows namespace

| public type | description |
| --- | --- |
| interface [IActionActivity](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActionActivity.md) |  |
| interface [IActivity](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IActivity.md) |  |
| interface [IBasicCodeActionParameterValue](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IBasicCodeActionParameterValue.md) |  |
| interface [ICodeActionParameterMapping](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/ICodeActionParameterMapping.md) |  |
| interface [ICodeActionParameterValue](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/ICodeActionParameterValue.md) |  |
| interface [IEntityTypeCodeActionParameterValue](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IEntityTypeCodeActionParameterValue.md) |  |
| interface [IExpressionBasedCodeActionParameterValue](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IExpressionBasedCodeActionParameterValue.md) |  |
| interface [IJavaActionCallAction](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IJavaActionCallAction.md) |  |
| interface [IJavaActionParameterMapping](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IJavaActionParameterMapping.md) |  |
| interface [IMicroflow](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IMicroflow.md) | Representation of a single [microflow](https://docs.mendix.com/apidocs-mxsdk/mxsdk/microflows-metamodel) in a metamodel. |
| interface [IMicroflowAction](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IMicroflowAction.md) |  |
| interface [IMicroflowBase](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IMicroflowBase.md) |  |
| interface [IMicroflowCall](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IMicroflowCall.md) |  |
| interface [IMicroflowCallAction](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IMicroflowCallAction.md) |  |
| interface [IMicroflowCallParameterMapping](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IMicroflowCallParameterMapping.md) |  |
| interface [IMicroflowExpressionContext](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IMicroflowExpressionContext.md) | The expression context of a microflow action. |
| interface [IMicroflowObject](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IMicroflowObject.md) |  |
| interface [IMicroflowParameterObject](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IMicroflowParameterObject.md) |  |
| interface [IMicroflowParameterValue](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IMicroflowParameterValue.md) |  |
| interface [IRule](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IRule.md) |  |
| interface [IServerSideMicroflow](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IServerSideMicroflow.md) |  |
| interface [IStringTemplateParameterValue](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IStringTemplateParameterValue.md) |  |
| interface [IVariable](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IVariable.md) |  |
| record [MicroflowReturnValue](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/MicroflowReturnValue.md) |  |

## Mendix.StudioPro.ExtensionsAPI.Model.Pages namespace

| public type | description |
| --- | --- |
| interface [IPage](./Mendix.StudioPro.ExtensionsAPI.Model.Pages/IPage.md) | Representation of a single [page](https://docs.mendix.com/apidocs-mxsdk/mxsdk/pages-metamodel/) in the app model. |

## Mendix.StudioPro.ExtensionsAPI.Model.Projects namespace

| public type | description |
| --- | --- |
| interface [IDocument](./Mendix.StudioPro.ExtensionsAPI.Model.Projects/IDocument.md) | Representation of a single [document](https://docs.mendix.com/apidocs-mxsdk/mxsdk/projects-metamodel#2-2-documents) in metamodel. This is an abstract unit, so all instances of [`IDocument`](./Mendix.StudioPro.ExtensionsAPI.Model.Projects/IDocument.md) also implement more concrete interface like [`IMicroflow`](./Mendix.StudioPro.ExtensionsAPI.Model.Microflows/IMicroflow.md). |
| interface [IFolder](./Mendix.StudioPro.ExtensionsAPI.Model.Projects/IFolder.md) |  |
| interface [IFolderBase](./Mendix.StudioPro.ExtensionsAPI.Model.Projects/IFolderBase.md) |  |
| interface [IModule](./Mendix.StudioPro.ExtensionsAPI.Model.Projects/IModule.md) | Representation of a single [module](https://docs.mendix.com/apidocs-mxsdk/mxsdk/projects-metamodel#2-modules) in metamodel. |
| interface [IProject](./Mendix.StudioPro.ExtensionsAPI.Model.Projects/IProject.md) | Representation of a whole [app](https://docs.mendix.com/apidocs-mxsdk/mxsdk/projects-metamodel) in metamodel. |
| interface [IProjectDocument](./Mendix.StudioPro.ExtensionsAPI.Model.Projects/IProjectDocument.md) |  |

## Mendix.StudioPro.ExtensionsAPI.Model.Settings namespace

| public type | description |
| --- | --- |
| interface [IConfiguration](./Mendix.StudioPro.ExtensionsAPI.Model.Settings/IConfiguration.md) |  |
| interface [IConfigurationSettings](./Mendix.StudioPro.ExtensionsAPI.Model.Settings/IConfigurationSettings.md) |  |
| interface [IConstantValue](./Mendix.StudioPro.ExtensionsAPI.Model.Settings/IConstantValue.md) |  |
| interface [IPrivateValue](./Mendix.StudioPro.ExtensionsAPI.Model.Settings/IPrivateValue.md) |  |
| interface [IProjectSettings](./Mendix.StudioPro.ExtensionsAPI.Model.Settings/IProjectSettings.md) |  |
| interface [IProjectSettingsPart](./Mendix.StudioPro.ExtensionsAPI.Model.Settings/IProjectSettingsPart.md) |  |
| interface [IRuntimeSettings](./Mendix.StudioPro.ExtensionsAPI.Model.Settings/IRuntimeSettings.md) |  |
| interface [ISharedOrPrivateValue](./Mendix.StudioPro.ExtensionsAPI.Model.Settings/ISharedOrPrivateValue.md) |  |
| interface [ISharedValue](./Mendix.StudioPro.ExtensionsAPI.Model.Settings/ISharedValue.md) |  |

## Mendix.StudioPro.ExtensionsAPI.Model.Texts namespace

| public type | description |
| --- | --- |
| interface [IText](./Mendix.StudioPro.ExtensionsAPI.Model.Texts/IText.md) | Represents a translatable text in a Mendix app. Translatable texts are mainly used in user-facing places in the app, for example on Pages and in Microflows where the end-user of the app will see the text. |
| interface [ITranslation](./Mendix.StudioPro.ExtensionsAPI.Model.Texts/ITranslation.md) | Represents a single translation of a translatable text. |

## Mendix.StudioPro.ExtensionsAPI.Services namespace

| public type | description |
| --- | --- |
| interface [IBackgroundJobService](./Mendix.StudioPro.ExtensionsAPI.Services/IBackgroundJobService.md) | Provides methods to run background jobs with separate steps. |
| interface [IConfigurationService](./Mendix.StudioPro.ExtensionsAPI.Services/IConfigurationService.md) | Provides access to the global Studio Pro configurations that can depend on environment or user-defined settings. |
| interface [IDomainModelService](./Mendix.StudioPro.ExtensionsAPI.Services/IDomainModelService.md) | It provides methods to retrieve associations between entities in the model. |
| interface [IExtensionFeaturesService](./Mendix.StudioPro.ExtensionsAPI.Services/IExtensionFeaturesService.md) |  |
| interface [IExtensionFileService](./Mendix.StudioPro.ExtensionsAPI.Services/IExtensionFileService.md) | Provides filesystem operations specific to an extension. |
| interface [IHttpClientService](./Mendix.StudioPro.ExtensionsAPI.Services/IHttpClientService.md) | Provides access to the HttpClientFactory from Studio Pro, which manages the usage of the HTTP Client Handler across the application. This prevents socket allocation exhaustion, which can cause undesirable application behavior. |
| interface [ILogService](./Mendix.StudioPro.ExtensionsAPI.Services/ILogService.md) | Provides access to the logging system of Studio Pro to log messages from extensions. Each message is by default decorated with the caller method name and the caller file path. This can be overriden in the method calls. |
| interface [IMicroflowExpressionService](./Mendix.StudioPro.ExtensionsAPI.Services/IMicroflowExpressionService.md) | Provides a set of operations on a [`Microflow Expression`](./Mendix.StudioPro.ExtensionsAPI.Model.MicroflowExpressions/IMicroflowExpression.md). |
| interface [IMicroflowService](./Mendix.StudioPro.ExtensionsAPI.Services/IMicroflowService.md) | Provides a set of operations on a Microflow. |
| interface [INameValidationService](./Mendix.StudioPro.ExtensionsAPI.Services/INameValidationService.md) | Provides validation functionality for names of model elements. |
| interface [INavigationManagerService](./Mendix.StudioPro.ExtensionsAPI.Services/INavigationManagerService.md) | Provides access to the navigation profiles of a Mendix app |
| interface [IPageGenerationService](./Mendix.StudioPro.ExtensionsAPI.Services/IPageGenerationService.md) | Provides access to the page generation features of the StudioPro |
| record [SecretManagerKey](./Mendix.StudioPro.ExtensionsAPI.Services/SecretManagerKey.md) | Represents a key for storing a secret. |
| record [ValidationResult](./Mendix.StudioPro.ExtensionsAPI.Services/ValidationResult.md) | Validation result that is returned by the validation api. |

## Mendix.StudioPro.ExtensionsAPI.UI namespace

| public type | description |
| --- | --- |
| interface [IContextMenuStructure](./Mendix.StudioPro.ExtensionsAPI.UI/IContextMenuStructure.md) |  |
| abstract class [UIExtensionBase](./Mendix.StudioPro.ExtensionsAPI.UI/UIExtensionBase.md) | Base class for all extensions providing custom UI. Do not inherit from this class directly, but use concrete extension points like [`MenuExtension`](./Mendix.StudioPro.ExtensionsAPI.UI.Menu/MenuExtension.md). |
| abstract class [ViewModelBase](./Mendix.StudioPro.ExtensionsAPI.UI/ViewModelBase.md) | Base class for any View Model - class which state is tracked and shown in the UI. Should not be used directly. |

## Mendix.StudioPro.ExtensionsAPI.UI.Dialogs namespace

| public type | description |
| --- | --- |
| abstract class [ModalDialogViewModelBase](./Mendix.StudioPro.ExtensionsAPI.UI.Dialogs/ModalDialogViewModelBase.md) | Representation of a modal popup dialog in Studio Pro. It is topmost and blocking. The only current allowed usage of this class is to implement the [`WebViewModalDialogViewModel`](./Mendix.StudioPro.ExtensionsAPI.UI.Dialogs/WebViewModalDialogViewModel.md) class, used to show a modal dialog containing a [`IWebView`](./Mendix.StudioPro.ExtensionsAPI.UI.WebView/IWebView.md) from [`ShowDialog`](./Mendix.StudioPro.ExtensionsAPI.UI.Services/IDialogService/ShowDialog.md). |
| abstract class [WebViewModalDialogViewModel](./Mendix.StudioPro.ExtensionsAPI.UI.Dialogs/WebViewModalDialogViewModel.md) | Representation of a modal popup dialog in Studio Pro. It is topmost and blocking. This modal popup dialog contains a [`IWebView`](./Mendix.StudioPro.ExtensionsAPI.UI.WebView/IWebView.md). It derives from [`ModalDialogViewModelBase`](./Mendix.StudioPro.ExtensionsAPI.UI.Dialogs/ModalDialogViewModelBase.md), the type of the parameter in [`ShowDialog`](./Mendix.StudioPro.ExtensionsAPI.UI.Services/IDialogService/ShowDialog.md). |

## Mendix.StudioPro.ExtensionsAPI.UI.DockablePane namespace

| public type | description |
| --- | --- |
| enum [DockablePaneBadgePriority](./Mendix.StudioPro.ExtensionsAPI.UI.DockablePane/DockablePaneBadgePriority.md) |  |
| abstract class [DockablePaneExtension](./Mendix.StudioPro.ExtensionsAPI.UI.DockablePane/DockablePaneExtension.md) | Base class for an extension that introduces new [dockable pane](https://docs.mendix.com/refguide/studio-pro-overview/#5-dockable-panes). |
| enum [DockablePanePosition](./Mendix.StudioPro.ExtensionsAPI.UI.DockablePane/DockablePanePosition.md) |  |
| abstract class [DockablePaneViewModelBase](./Mendix.StudioPro.ExtensionsAPI.UI.DockablePane/DockablePaneViewModelBase.md) |  |
| abstract class [WebViewDockablePaneViewModel](./Mendix.StudioPro.ExtensionsAPI.UI.DockablePane/WebViewDockablePaneViewModel.md) | Representation of a [dockable pane](https://docs.mendix.com/refguide/studio-pro-overview/#5-dockable-panes) in Studio Pro. This dockable pane is meant to contain a [`IWebView`](./Mendix.StudioPro.ExtensionsAPI.UI.WebView/IWebView.md). |

## Mendix.StudioPro.ExtensionsAPI.UI.Events namespace

| public type | description |
| --- | --- |
| class [ExtensionLoaded](./Mendix.StudioPro.ExtensionsAPI.UI.Events/ExtensionLoaded.md) | An event that occurs when an extension is loading. |
| class [ExtensionUnloading](./Mendix.StudioPro.ExtensionsAPI.UI.Events/ExtensionUnloading.md) | An event that occurs when an extension will be unloaded. |
| interface [IEvent](./Mendix.StudioPro.ExtensionsAPI.UI.Events/IEvent.md) | Interface for events that occur in Studio Pro. |
| interface [IEventSubscription](./Mendix.StudioPro.ExtensionsAPI.UI.Events/IEventSubscription.md) | Interface for event subscriptions. |

## Mendix.StudioPro.ExtensionsAPI.UI.Menu namespace

| public type | description |
| --- | --- |
| abstract class [ContextMenuExtension&lt;TElement&gt;](./Mendix.StudioPro.ExtensionsAPI.UI.Menu/ContextMenuExtension-1.md) | Base class for an extension that introduces new context menu items for model elements. Currently only elements of type [`IEntity`](./Mendix.StudioPro.ExtensionsAPI.Model.DomainModels/IEntity.md) and of type [`IDocument`](./Mendix.StudioPro.ExtensionsAPI.Model.Projects/IDocument.md) are supported. |
| abstract class [MenuExtension](./Mendix.StudioPro.ExtensionsAPI.UI.Menu/MenuExtension.md) | Base class for an extension that introduces new menu items into the menu bar. The menus will be placed under a Top-level menu 'Extensions' and a submenu named under the name of the extension. |
| [Flags] enum [MenuSeparator](./Mendix.StudioPro.ExtensionsAPI.UI.Menu/MenuSeparator.md) |  |
| class [MenuViewModel](./Mendix.StudioPro.ExtensionsAPI.UI.Menu/MenuViewModel.md) |  |

## Mendix.StudioPro.ExtensionsAPI.UI.Microflows namespace

| public type | description |
| --- | --- |
| class [EditMicroflowExpressionResult](./Mendix.StudioPro.ExtensionsAPI.UI.Microflows/EditMicroflowExpressionResult.md) | Represents the result of showing a microflow expression editor form. |

## Mendix.StudioPro.ExtensionsAPI.UI.Services namespace

| public type | description |
| --- | --- |
| class [DocumentSelectorDialogOptions&lt;TDocument&gt;](./Mendix.StudioPro.ExtensionsAPI.UI.Services/DocumentSelectorDialogOptions-1.md) | Options class for describing the behavior of a document selector dialog in Studio Pro. |
| class [EntitySelectorDialogOptions](./Mendix.StudioPro.ExtensionsAPI.UI.Services/EntitySelectorDialogOptions.md) | Options class for describing the behavior of an entity selector dialog in Studio Pro. |
| interface [IAppService](./Mendix.StudioPro.ExtensionsAPI.UI.Services/IAppService.md) | Provides a set of Studio Pro level operations related to Mendix App. |
| interface [IDialogService](./Mendix.StudioPro.ExtensionsAPI.UI.Services/IDialogService.md) | Provides methods to open and close modal dialogs. |
| interface [IDockingWindowService](./Mendix.StudioPro.ExtensionsAPI.UI.Services/IDockingWindowService.md) | Provides access to the docking window of Studio Pro allowing for interactions with tabs, panes and editors. |
| interface [IEntityService](./Mendix.StudioPro.ExtensionsAPI.UI.Services/IEntityService.md) | Provides a set of operations on an entity. |
| interface [IFindResultsPaneService](./Mendix.StudioPro.ExtensionsAPI.UI.Services/IFindResultsPaneService.md) | Provides operations to control the Find Results pane in Studio Pro. |
| interface [ILocalRunConfigurationsService](./Mendix.StudioPro.ExtensionsAPI.UI.Services/ILocalRunConfigurationsService.md) | Provides access to the active configuration. |
| interface [IMessageBoxService](./Mendix.StudioPro.ExtensionsAPI.UI.Services/IMessageBoxService.md) | Provides a set of methods to show Error, Info or Warning message boxes. |
| interface [IMicroflowExpressionEditorService](./Mendix.StudioPro.ExtensionsAPI.UI.Services/IMicroflowExpressionEditorService.md) | Provides operations to create or edit a [`IMicroflowExpression`](./Mendix.StudioPro.ExtensionsAPI.Model.MicroflowExpressions/IMicroflowExpression.md). |
| interface [INotificationPopupService](./Mendix.StudioPro.ExtensionsAPI.UI.Services/INotificationPopupService.md) | The Studio Pro Notification Service helps you show natively styled theme-aware notifications |
| interface [ISelectorDialogService](./Mendix.StudioPro.ExtensionsAPI.UI.Services/ISelectorDialogService.md) | Provides a set of operations for showing the object (that is [`unit`](./Mendix.StudioPro.ExtensionsAPI.Model/IAbstractUnit.md) or [`element`](./Mendix.StudioPro.ExtensionsAPI.Model/IElement.md)) selection interface to Studio Pro user. |
| interface [IVersionControlService](./Mendix.StudioPro.ExtensionsAPI.UI.Services/IVersionControlService.md) |  |
| abstract class [SelectorDialogOptions&lt;TStructure,TContainerStructure&gt;](./Mendix.StudioPro.ExtensionsAPI.UI.Services/SelectorDialogOptions-2.md) | Options class for describing the behavior of a selector dialog in Studio Pro. |
| class [SelectorResult&lt;TStructure&gt;](./Mendix.StudioPro.ExtensionsAPI.UI.Services/SelectorResult-1.md) | Represents the result of showing a selector dialog. |

## Mendix.StudioPro.ExtensionsAPI.UI.Tab namespace

| public type | description |
| --- | --- |
| abstract class [TabViewModelBase](./Mendix.StudioPro.ExtensionsAPI.UI.Tab/TabViewModelBase.md) |  |
| abstract class [WebViewTabViewModel](./Mendix.StudioPro.ExtensionsAPI.UI.Tab/WebViewTabViewModel.md) | Representation of a tab in the [working area](https://docs.mendix.com/refguide/studio-pro-overview/#4-working-area) of Studio Pro. This tab is meant to contain a [`IWebView`](./Mendix.StudioPro.ExtensionsAPI.UI.WebView/IWebView.md). |

## Mendix.StudioPro.ExtensionsAPI.UI.WebServer namespace

| public type | description |
| --- | --- |
| delegate [HandleWebRequestAsync](./Mendix.StudioPro.ExtensionsAPI.UI.WebServer/HandleWebRequestAsync.md) | Represents a method for handling a web request. |
| interface [IWebServer](./Mendix.StudioPro.ExtensionsAPI.UI.WebServer/IWebServer.md) | Represents the internal web server of Studio Pro. |
| abstract class [WebServerExtension](./Mendix.StudioPro.ExtensionsAPI.UI.WebServer/WebServerExtension.md) | Base class for an extension that adds request handlers to the internal web server of Studio Pro. |

## Mendix.StudioPro.ExtensionsAPI.UI.WebView namespace

| public type | description |
| --- | --- |
| interface [IWebView](./Mendix.StudioPro.ExtensionsAPI.UI.WebView/IWebView.md) | A web view allows developers to display web content from within their extension. |
| class [MessageReceivedEventArgs](./Mendix.StudioPro.ExtensionsAPI.UI.WebView/MessageReceivedEventArgs.md) | Event args for the [`MessageReceived`](./Mendix.StudioPro.ExtensionsAPI.UI.WebView/IWebView/MessageReceived.md) event. |

## Mendix.StudioPro.ExtensionsAPI.VersionControl namespace

| public type | description |
| --- | --- |
| interface [IBranch](./Mendix.StudioPro.ExtensionsAPI.VersionControl/IBranch.md) | Provides access to the details of a branch |
| interface [ICommit](./Mendix.StudioPro.ExtensionsAPI.VersionControl/ICommit.md) | Provides access to the details of a commit |

<!-- DO NOT EDIT: generated by xmldocmd for Mendix.StudioPro.ExtensionsAPI.dll -->
