namespace API.DTOs;

public record CreateProjectDto
{
    public string Name { get; init; }
    public string Description { get; init; }
}