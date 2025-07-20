namespace API.Interfaces;

public interface IUnitOfWork
{
    IProjectsRepository Projects { get; }
    Task<bool> SaveChangesAsync();
}