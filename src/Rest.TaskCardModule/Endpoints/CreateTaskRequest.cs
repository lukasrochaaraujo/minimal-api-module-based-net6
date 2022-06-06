using Rest.TaskCardModule.Core.Entities;

namespace Rest.TaskCardModule.Endpoints;

public class CreateTaskRequest
{
    public string Title { get; init; }
    public string Description { get; init; }
    public Priority Priority { get; init; }

    public CreateTaskRequest(string title, string description, Priority priority)
    {
        Title = title;
        Description = description;
        Priority = priority;
    }
}
