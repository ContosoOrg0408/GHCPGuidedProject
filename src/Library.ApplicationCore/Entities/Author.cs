namespace Library.ApplicationCore.Entities;

/// <summary>
/// Represents an author in the library system.
/// </summary>
public class Author
{
    /// <summary>
    /// Gets or sets the unique identifier for the author.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the author.
    /// </summary>
    public required string Name { get; set; }
}