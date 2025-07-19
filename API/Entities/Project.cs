namespace API.Entities;

public class Project
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public string OwnerId { get; set; } = default!;
    public AppUser Owner { get; set; } = default!;

    public ICollection<Board> Boards { get; set; } = new List<Board>();
}