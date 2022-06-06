using Rest.TaskCardModule.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rest.TaskCardModule.Core.Interfaces;

public interface ITaskCardRepository
{
    Task<TaskCard> FindAllByIdAsync(string id);
    Task<IEnumerable<TaskCard>> GetAllByStatusAsync(Status status);
    Task<TaskCard> IncludeAsync(TaskCard taskCard);
    Task<TaskCard> UpdateAsync(TaskCard taskCard);
}
