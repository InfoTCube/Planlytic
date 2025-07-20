using API.Entities;

namespace API.Interfaces;

public interface IProjectsRepository
{
    Task<Project> GetProjectForUserByIdAsync(Guid id, string userId);
    Task<IEnumerable<Project>> GetAllProjectsForUserAsync(string userId);
    Task<Project> CreateProjectAsync(Project project);
    Task<bool> UpdateProjectAsync(Project project);
    Task<bool> DeleteProjectAsync(Guid id);
}