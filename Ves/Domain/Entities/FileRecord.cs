using System;
namespace Ves.Domain.Entities;

/// <summary>
/// Represents a file tracked by the system with its hash stored in a separate database.
/// </summary>
public class FileRecord
{
    public int Id { get; set; }
    public string FilePath { get; set; } = string.Empty;
    public string Hash { get; set; } = string.Empty;
    public DateTime FechaCarga { get; set; }
}
