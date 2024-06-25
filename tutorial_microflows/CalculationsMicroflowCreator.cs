using Mendix.StudioPro.ExtensionsAPI.Model;
using Mendix.StudioPro.ExtensionsAPI.Model.DataTypes;
using Mendix.StudioPro.ExtensionsAPI.Model.Microflows;
using Mendix.StudioPro.ExtensionsAPI.Model.Projects;
using Mendix.StudioPro.ExtensionsAPI.Services;
using System.ComponentModel.Composition;

namespace MicroflowTutorial;

[Export(typeof(CalculationsMicroflowCreator))]
[method: ImportingConstructor]
class CalculationsMicroflowCreator(IMicroflowService microflowService, IMicroflowExpressionService microflowExpressionService)
{
    public void CreateMicroflows(IModel currentApp)
    {
        var module = currentApp.Root.GetModules().Single(m => m.Name == "MyFirstModule");

        using var transaction = currentApp.StartTransaction("Create microflows");

        CreateMicroflowsInFolder(currentApp, module);

        transaction.Commit();
    }

    void CreateMicroflowsInFolder(IModel currentApp, IFolderBase folder)
    {
        string multiplicationResult = "multiplicationResult";
        string additionResult = "additionResult";

        string returnValueExpression = $"(${multiplicationResult} - round(${additionResult}) > 0)";

        var callingMicroflow = microflowService.CreateMicroflow(currentApp, folder, "Microflow",
            new MicroflowReturnValue(DataType.Boolean, microflowExpressionService.CreateFromString(returnValueExpression)));

        CreateMultiplicationMicroflow(currentApp, folder, callingMicroflow, multiplicationResult);
        CreateAdditionMicroflow(currentApp, folder, callingMicroflow, additionResult);
    }

    void CreateMultiplicationMicroflow(IModel currentApp, IFolderBase folder, IMicroflow callingMicroflow, string outputVariableName)
    {
        var multiplication1Param = "multiplication1";
        var multiplication2Param = "multiplication2";

        var returnExpression = microflowExpressionService.CreateFromString($"${multiplication1Param} * ${multiplication2Param}");
        var returnValue = new MicroflowReturnValue(DataType.Integer, returnExpression);

        var multiplicationMicroflow = microflowService.CreateMicroflow(currentApp, folder, "MultiplicationMicroflow",
           returnValue,
           (multiplication1Param, DataType.Integer),
           (multiplication2Param, DataType.Integer));

        CreateMicroflowCallActivity(currentApp, callingMicroflow, multiplicationMicroflow,
           outputVariableName,
           (multiplication1Param, "10"),
           (multiplication2Param, "100"));
    }

    void CreateAdditionMicroflow(IModel currentApp, IFolderBase folder, IMicroflow callingMicroflow, string outputVariableName)
    {
        var addition1Param = "addition1";
        var addition2Param = "addition2";

        var returnExpression = microflowExpressionService.CreateFromString($"${addition1Param} + ${addition2Param}");
        var returnValue = new MicroflowReturnValue(DataType.Decimal, returnExpression);

        var additionMicroflow = microflowService.CreateMicroflow(currentApp, folder, "AdditionMicroflow",
            returnValue,
            (addition1Param, DataType.Decimal),
            (addition2Param, DataType.Decimal));

        CreateMicroflowCallActivity(currentApp, callingMicroflow, additionMicroflow,
           outputVariableName,
           (addition1Param, "1.2"),
           (addition2Param, "2.2"));
    }

    void CreateMicroflowCallActivity(IModel currentApp,
    IMicroflow microflowThatCalls,
    IMicroflow calledMicroflow,
    string outputVariableName,
    params (string parameterName, string expression)[] parameters)
    {
        var microflowCallActivity = currentApp.Create<IActionActivity>();
        var microflowCallAction = currentApp.Create<IMicroflowCallAction>();
        microflowCallAction.MicroflowCall = currentApp.Create<IMicroflowCall>();
        microflowCallAction.MicroflowCall.Microflow = calledMicroflow.QualifiedName;
        microflowCallActivity!.Action = microflowCallAction;
        microflowCallAction.OutputVariableName = outputVariableName;

        foreach (var (parameterName, expression) in parameters)
        {
            var parameterInCalledMicroflow = microflowService.GetParameters(calledMicroflow).Single(p => p.Name == parameterName);
            var parameterMapping = currentApp.Create<IMicroflowCallParameterMapping>();
            parameterMapping.Argument = microflowExpressionService.CreateFromString(expression);
            parameterMapping.Parameter = parameterInCalledMicroflow.QualifiedName;
            microflowCallAction.MicroflowCall.AddParameterMapping(parameterMapping);
        }

        microflowService.TryInsertAfterStart(microflowThatCalls, microflowCallActivity);
    }
}
