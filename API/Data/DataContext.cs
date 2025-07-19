using API.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : IdentityDbContext<AppUser>
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Project> Projects { get; set; } = default!;
    public DbSet<Board> Boards { get; set; } = default!;
    public DbSet<TaskItem> TaskItems { get; set; } = default!;
}