using Library.ApplicationCore.Entities;

namespace Library.ApplicationCore;

/// <summary>
/// Defines methods for accessing and updating patron data.
/// </summary>
public interface IPatronRepository {
    /// <summary>
    /// Retrieves a patron by their unique identifier.
    /// </summary>
    /// <param name="patronId">The unique identifier of the patron.</param>
    /// <returns>The patron if found; otherwise, null.</returns>
    Task<Patron?> GetPatron(int patronId);

    /// <summary>
    /// Searches for patrons matching the specified input.
    /// </summary>
    /// <param name="searchInput">The search string for patron names.</param>
    /// <returns>A list of matching patrons.</returns>
    Task<List<Patron>> SearchPatrons(string searchInput);

    /// <summary>
    /// Updates the specified patron in the data store.
    /// </summary>
    /// <param name="patron">The patron to update.</param>
    Task UpdatePatron(Patron patron);
}

