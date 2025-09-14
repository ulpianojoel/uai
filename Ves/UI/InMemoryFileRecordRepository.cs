using System.Collections.Generic;
using Ves.DAL.Interfaces;
using Ves.Domain.Entities;

namespace Ves.UI;

/// <summary>
/// Simple in-memory repository used only for console demonstration.
/// </summary>
public class InMemoryFileRecordRepository : IFileRecordRepository
{
    private readonly List<FileRecord> _records = new();

    public IEnumerable<FileRecord> GetAll() => _records;

    public void Save(FileRecord record) => _records.Add(record);
}
