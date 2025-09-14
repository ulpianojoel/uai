using Ves.Domain.Entities;

namespace Ves.BLL.Interfaces;

/// <summary>
/// Service for hashing files, storing hash in database and exporting list to a text file.
/// </summary>
public interface IFileHashService
{
    void ProcessFile(string path);
    void ExportToText(string destinationPath);
}
