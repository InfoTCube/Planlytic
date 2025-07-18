namespace API.DTOs;

public record RegisterDto
{
    public string? Email { get; init; }
    public string? Password { get; init; }
    public string? ConfirmPassword { get; init; }
}