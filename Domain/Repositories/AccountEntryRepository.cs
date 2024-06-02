using System.Collections.Generic;
using Domain.Interfaces;
using Shared.Interfaces;

namespace Domain.Repositories;

public class AccountEntryRepository<T> where T : IAccountEntry
{
    private readonly IFileHelper _fileHelper;
    private readonly IEncryptionHelper _encryptionHelper;
    
    private List<T> _entries = new();
    
    public IReadOnlyList<T> Entries => _entries.AsReadOnly();

    public AccountEntryRepository(IFileHelper fileHelper, IEncryptionHelper encryptionHelper)
    {
        _fileHelper = fileHelper;
        _encryptionHelper = encryptionHelper;
    }
    
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
    /// Remove an entry from the repository
    /// </summary>
    /// <param name="entry"></param>
    /// <param name="saveToFile"></param>
    public void Remove(T entry, bool saveToFile = true)
    {
        _entries.Remove(entry);
        
        if (saveToFile)
            SaveToFile();
    }

    /// <summary>
    /// Load all entries from file into the repository
    /// </summary>
    public void LoadFromFile()
    {
        var fileContent = _fileHelper.ReadFile(typeof(T).Name + ".json");
        if (fileContent != null)
            _entries = _encryptionHelper.Decrypt<List<T>>(fileContent);
    }

    /// <summary>
    /// Save all entries to file from the repository
    /// </summary>
    private void SaveToFile()
    {
        var encryptedEntries = _encryptionHelper.Encrypt(_entries);
        _fileHelper.WriteFile(typeof(T).Name + ".json", encryptedEntries);
    }
}