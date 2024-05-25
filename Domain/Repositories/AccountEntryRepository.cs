using System.Collections.Generic;
using Infrastructure.Helpers;
using Shared.Interfaces;

namespace Domain.Repositories;

public class AccountEntryRepository<T> where T : IAccountEntry
{
    private List<T> _entries = new();
    
    public IReadOnlyList<T> Entries => _entries.AsReadOnly();

    /// <summary>
    /// Add a new entry to the repository
    /// </summary>
    /// <param name="entry"></param>
    public void Add(T entry)
    {
        _entries.Add(entry);
        SaveToFile();
    }

    /// <summary>
    /// Load all entries from file into the repository
    /// </summary>
    public void LoadFromFile()
    {
        var fileContent = FileHelper.ReadFile(typeof(T).Name + ".json");
        if (fileContent != null)
        {
            _entries = EncryptionHelper.Decrypt<List<T>>(fileContent);
        }
    }

    /// <summary>
    /// Save all entries to file from the repository
    /// </summary>
    private void SaveToFile()
    {
        var encryptedEntries = EncryptionHelper.Encrypt(_entries);
        FileHelper.WriteFile(typeof(T).Name + ".json", encryptedEntries);
    }
}