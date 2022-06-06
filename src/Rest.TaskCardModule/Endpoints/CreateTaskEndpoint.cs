using Microsoft.AspNetCore.Http;
using Rest.TaskCardModule.Core.Entities;
using Rest.TaskCardModule.Core.Interfaces;
using System.Threading.Tasks;

namespace Rest.TaskCardModule.Endpoints;

public class CreateTaskEndpoint
{
    public static async Task<IResult> HandleAsync(ITaskCardRepository taskCardRepository, CreateTaskRequest request)
    {
        //todo: validation
        var taskCard = new TaskCard(request.Title, request.Description, request.Priority);
        taskCard = await taskCardRepository.IncludeAsync(taskCard);
        return Results.Ok(new CreateTaskResponse(taskCard.Id));
    }
}
