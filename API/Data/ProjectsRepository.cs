using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class ProjectsRepository : IProjectsRepository
{
    private readonly DataContext _context;

    public ProjectsRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<Project> GetProjectForUserByIdAsync(Guid id, string userId)
    {
        return await _context.Projects
            .Include(p => p.Owner)
            .FirstOrDefaultAsync(p => p.Id == id && p.Owner.Id == userId);
    }

    public async Task<IEnumerable<Project>> GetAllProjectsForUserAsync(string userId)
    {
        return await _context.Projects
            .Include(p => p.Owner)
            .Where(p => p.Owner.Id == userId)
            .ToListAsync();
    }

    public async Task<Project> CreateProjectAsync(Project project)
    {
        _context.Projects.Add(project);
        await _context.SaveChangesAsync();
        return project;
    }

    public async Task<bool> UpdateProjectAsync(Project project)
    {
        _context.Projects.Update(project);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteProjectAsync(Guid id)
    {
        var project = await _context.Projects.FindAsync(id);
        if (project == null) return false;

        _context.Projects.Remove(project);
        return await _context.SaveChangesAsync() > 0;
    }
}