using Serilog;
using System.Reflection;
using MethodDecorator.Fody.Interfaces;
using System.Text.Json;

namespace CalculX.Base.Services;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Module | AttributeTargets.Assembly)]
public class LogExecutionAttribute : Attribute, IMethodDecorator
{
    private MethodBase _method;
    private object[] _args;

    public void Init(object instance, MethodBase method, object[] args)
    {
        _method = method;
        _args = args;
    }

    public void OnEntry()
    {
        var paramInfo = GetParameterInfo(_method, _args);
        Log.Information("Entering method {MethodName} with parameters: {Parameters}", _method?.Name ?? "Unknown", paramInfo);
    }

    public void OnExit()
    {
        Log.Information("Exiting method {MethodName} in class {ClassName}", _method?.Name ?? "Unknown", _method?.DeclaringType?.Name ?? "Unknown");
    }

    public void OnException(Exception exception)
    {
        Log.Error(exception, "Exception in method {MethodName} of class {ClassName}: {Message}", _method?.Name ?? "Unknown", _method?.DeclaringType?.Name ?? "Unknown", exception.Message);
    }

    private string GetParameterInfo(MethodBase method, object[] args)
    {
        if (method == null || args == null)
            return "No parameters";

        var paramInfo = method.GetParameters();
        var paramDetails = paramInfo.Select((param, index) =>
        {
            var paramName = param.Name ?? "Unknown";
            var paramValue = args.Length > index && args[index] != null
                ? JsonSerializer.Serialize(args[index])
                : "null";
            return $"{paramName}: {paramValue}";
        });

        return string.Join(", ", paramDetails);
    }
}
