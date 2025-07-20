namespace API.DTOs;

public record ProjectDto
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Description { get; init; }
    public DateTime CreatedAt { get; init; }
    public string OwnerId { get; init; }    
}
