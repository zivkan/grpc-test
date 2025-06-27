using Grpc.Core;

namespace grpc_test.Services;

public class GreeterService(ILogger<GreeterService> logger) : Greeter.GreeterBase
{
    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        logger.LogInformation("The message is received from {Name}", request.Who);

        return Task.FromResult(new HelloReply
        {
            Result = "Hello " + request.Who
        });
    }
}
