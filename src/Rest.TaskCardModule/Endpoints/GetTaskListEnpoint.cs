using Microsoft.AspNetCore.Http;
using Rest.TaskCardModule.Core.Entities;
using Rest.TaskCardModule.Core.Interfaces;
using System.Threading.Tasks;

namespace Rest.TaskCardModule.Endpoints;

public class GetTaskListEnpoint
{
    public static async Task<IResult> HandleAsync(ITaskCardRepository taskCardRepository, Status status)
    {
        var tasks = await taskCardRepository.GetAllByStatusAsync(status);
        return Results.Ok(tasks);
    }
}
