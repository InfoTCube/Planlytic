using System.Security.Claims;
using API.DTOs;
using API.Entities;
using API.Extensions;
using API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Authorize]
public class ProjectController : BaseApiController
{
    private readonly UserManager<AppUser> _userManager;
    private readonly IUnitOfWork _unitOfWork;

    public ProjectController(UserManager<AppUser> userManager, IUnitOfWork unitOfWork)
    {
        _userManager = userManager;
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProjectDto>>> GetProjectsAsync()
    {
        var projects = await _unitOfWork.Projects.GetAllProjectsForUserAsync(User.GetUserId());

        var projectDtos = projects.Select(p => new ProjectDto
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            CreatedAt = p.CreatedAt,
            OwnerId = p.Owner?.Id
        });

        return Ok(projectDtos);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProjectDto>> GetProjectForUserByIdAsync(Guid id)
    {
        var project = await _unitOfWork.Projects.GetProjectForUserByIdAsync(id, User.GetUserId());
        if (project == null) return NotFound();

        var projectDto = new ProjectDto
        {
            Id = project.Id,
            Name = project.Name,
            Description = project.Description,
            CreatedAt = project.CreatedAt,
            OwnerId = project.Owner?.Id
        };

        return Ok(projectDto);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProjectAsync([FromBody] CreateProjectDto project)
    {
        var user = await _userManager.FindByIdAsync(User.GetUserId());
        if (user is null) return NotFound();

        var newProject = new Project
        {
            Name = project.Name,
            Description = project.Description,
            CreatedAt = DateTime.UtcNow,
            Owner = user
        };

        var createdProject = await _unitOfWork.Projects.CreateProjectAsync(newProject);
        if (createdProject == null) return BadRequest("Failed to create project");

        return Created();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProjectAsync(Guid id, [FromBody] CreateProjectDto projectDto)
    {
        var project = await _unitOfWork.Projects.GetProjectForUserByIdAsync(id, User.GetUserId());
        if (project == null) return NotFound();

        project.Name = projectDto.Name;
        project.Description = projectDto.Description;

        var result = await _unitOfWork.Projects.UpdateProjectAsync(project);
        if (!result) return BadRequest("Failed to update project");

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProjectAsync(Guid id)
    {
        var project = await _unitOfWork.Projects.GetProjectForUserByIdAsync(id, User.GetUserId());
        if (project == null) return NotFound();

        var result = await _unitOfWork.Projects.DeleteProjectAsync(id);
        if (!result) return BadRequest("Failed to delete project");

        return NoContent();
    }
}