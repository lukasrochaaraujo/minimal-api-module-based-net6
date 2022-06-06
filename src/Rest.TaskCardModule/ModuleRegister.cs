using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using Rest.TaskCardModule.Core.Interfaces;
using Rest.TaskCardModule.Endpoints;
using Rest.TaskCardModule.Infrastructure.Persistence.Mappings;
using Rest.TaskCardModule.Infrastructure.Persistence.Repositories;

namespace Rest.TaskCardModule;

public static class ModuleRegister
{
    public static IServiceCollection AddTaskCardModule(this IServiceCollection services)
    {
        //todo: move configuration to appsettings approach
        services.AddSingleton<IMongoClient>(sp => new MongoClient("mongodb://172.24.58.227:27017"));
        MongoDbMapping.Map();
        services.AddScoped<ITaskCardRepository, TaskCardRepository>();
        return services;
    }

    public static IEndpointRouteBuilder MapTaskCardEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("tasks", GetTaskListEnpoint.HandleAsync);
        endpoints.MapPost("tasks", CreateTaskEndpoint.HandleAsync);
        return endpoints;
    }
}
