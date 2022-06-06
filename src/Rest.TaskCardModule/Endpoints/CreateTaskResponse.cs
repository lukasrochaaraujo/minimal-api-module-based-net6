namespace Rest.TaskCardModule.Endpoints;

public class CreateTaskResponse
{
    public string TaskId { get; init; }

    public CreateTaskResponse(string taskId)
    {
        TaskId = taskId;
    }
}
