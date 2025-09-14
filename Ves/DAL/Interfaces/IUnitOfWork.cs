namespace Ves.DAL.Interfaces;

/// <summary>
/// Unit of Work pattern to coordinate transactions across repositories.
/// </summary>
public interface IUnitOfWork
{
    void Begin();
    void Commit();
    void Rollback();
}
