using System;
using System.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Ves.BLL.Interfaces;
using Ves.DAL.Interfaces;
using Ves.Domain.Entities;

namespace Ves.BLL.Services;

/// <summary>
/// Computes SHA256 hashes for files and persists them in a dedicated database.
/// Also capable of exporting the list of tracked files to a text file.
/// </summary>
public class FileHashService : IFileHashService
{
    private readonly IFileRecordRepository _repo;

    public FileHashService(IFileRecordRepository repo) => _repo = repo;

    public void ProcessFile(string path)
    {
        using var stream = File.OpenRead(path);
        using var sha = SHA256.Create();
        var hash = sha.ComputeHash(stream);
        var record = new FileRecord
        {
            FilePath = path,
            Hash = Convert.ToHexString(hash),
            FechaCarga = DateTime.UtcNow
        };
        _repo.Save(record);
    }

    public void ExportToText(string destinationPath)
    {
        var lines = _repo.GetAll().Select(r => $"{r.FilePath};{r.Hash}");
        File.WriteAllLines(destinationPath, lines, Encoding.UTF8);
    }
}
