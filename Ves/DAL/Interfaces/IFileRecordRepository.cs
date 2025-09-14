using System.Collections.Generic;
using Ves.Domain.Entities;

namespace Ves.DAL.Interfaces;

/// <summary>
/// Repository dedicated to storing hashes of uploaded files in a separate database.
/// </summary>
public interface IFileRecordRepository
{
    void Save(FileRecord record);
    IEnumerable<FileRecord> GetAll();
}
