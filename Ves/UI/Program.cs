using System;
using System.IO;
using Ves.BLL.Services;
using Ves.UI;

// Small console application demonstrating usage of the service layer.
// In a real scenario the repositories would connect to SQL Server 2019
// and the services would be resolved via dependency injection.

var repo = new InMemoryFileRecordRepository();
var fileService = new FileHashService(repo);

Console.WriteLine("Procesando archivo de ejemplo...");
fileService.ProcessFile("README.md"); // hash repo root readme as demo

var exportPath = Path.Combine(Environment.CurrentDirectory, "hashes.txt");
fileService.ExportToText(exportPath);
Console.WriteLine($"Hashes exportados a {exportPath}");
