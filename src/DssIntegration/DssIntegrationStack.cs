using Amazon.CDK;
using Amazon.CDK.AWS.Lambda;
using Amazon.CDK.AWS.APIGateway;
using Amazon.CDK.AWS.StepFunctions;
using Constructs;

namespace DssIntegration
{
    public class DssIntegrationStack : Stack
    {
        internal DssIntegrationStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            // define all the lambda
            var lambda1 = new Function(this, "Lambda1", new FunctionProps()
            {
                Runtime = Runtime.DOTNET_CORE_3_1,
                Code = Code.FromAsset("lambda"),
                Handler = "hello.handler"
            });

            var lambda2 = new Function(this, "Lambda2", new FunctionProps()
            {
                Runtime = Runtime.DOTNET_CORE_3_1,
                Code = Code.FromAsset("lambda"),
                Handler = "hello.handler"
            });

            var lambda3 = new Function(this, "Lambda3", new FunctionProps()
            {
                Runtime = Runtime.DOTNET_CORE_3_1,
                Code = Code.FromAsset("lambda"),
                Handler = "hello.handler"
            });

            var lambda4 = new Function(this, "Lambda4", new FunctionProps()
            {
                Runtime = Runtime.DOTNET_CORE_3_1,
                Code = Code.FromAsset("lambda"),
                Handler = "hello.handler"
            });

            var lambda5 = new Function(this, "Lambda5", new FunctionProps()
            {
                Runtime = Runtime.DOTNET_CORE_3_1,
                Code = Code.FromAsset("lambda"),
                Handler = "hello.handler"
            });

            var lambda6 = new Function(this, "Lambda6", new FunctionProps()
            {
                Runtime = Runtime.DOTNET_CORE_3_1,
                Code = Code.FromAsset("lambda"),
                Handler = "hello.handler"
            });

            var lambda7 = new Function(this, "Lambda7", new FunctionProps()
            {
                Runtime = Runtime.DOTNET_CORE_3_1,
                Code = Code.FromAsset("lambda"),
                Handler = "hello.handler"
            });

            var lambda8 = new Function(this, "Lambda8", new FunctionProps()
            {
                Runtime = Runtime.DOTNET_CORE_3_1,
                Code = Code.FromAsset("lambda"),
                Handler = "hello.handler"
            });

            var lambda9 = new Function(this, "Lambda9", new FunctionProps()
            {
                Runtime = Runtime.DOTNET_CORE_3_1,
                Code = Code.FromAsset("lambda"),
                Handler = "hello.handler"
            });

            // define step function
            Pass stateMachineDefinition = new Pass(this, "PassState");

            IStateMachine stateMachine = new StateMachine(this, "ProductCreateStateMachine", new StateMachineProps
            {
                Definition = stateMachineDefinition,
                StateMachineType = StateMachineType.EXPRESS
            });

            new StepFunctionsRestApi(this, "StepFunctionsRestApi", new StepFunctionsRestApiProps
            {
                Deploy = true,
                StateMachine = stateMachine
            });
        }
    }
}
