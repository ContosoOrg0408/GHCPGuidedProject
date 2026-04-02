namespace Library.ApplicationCore.Entities;

/// <summary>
/// Represents a physical copy of a book in the library.
/// </summary>
public class BookItem
{
    /// <summary>
    /// Gets or sets the unique identifier for the book item.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the associated book.
    /// </summary>
    public int BookId { get; set; }

    /// <summary>
    /// Gets or sets the acquisition date of the book item.
    /// </summary>
    public DateTime AcquisitionDate { get; set; }

    /// <summary>
    /// Gets or sets the condition of the book item.
    /// </summary>
    public string? Condition { get; set; }

    /// <summary>
    /// Gets or sets the associated book entity.
    /// </summary>
    public Book? Book { get; set; }
}
