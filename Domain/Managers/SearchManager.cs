using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Domain.Interfaces;

namespace Domain.Managers;

public class SearchManager
{
    /// <summary>
    /// Search for entries in the repository
    /// </summary>
    /// <param name="entries"></param>
    /// <param name="searchQuery"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public IReadOnlyList<T> Search<T>(IReadOnlyList<T> entries, string searchQuery) where T : IAccountEntry
    {
        return entries.Where(entry =>
        {
            var properties = entry.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var property in properties)
            {
                // Check if the property is a string or a value type
                if (property.PropertyType != typeof(string) && !property.PropertyType.IsValueType) 
                    continue;
                
                var value = property.GetValue(entry);
                
                // Check if the value contains the search query
                if (value != null && value.ToString().ToLower().Contains(searchQuery.ToLower()))
                    return true;
            }
            return false;
        }).ToList().AsReadOnly();
    }
}