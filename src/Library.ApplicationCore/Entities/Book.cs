namespace Library.ApplicationCore.Entities;

/// <summary>
/// Represents a book in the library system.
/// </summary>
public class Book
{
    /// <summary>
    /// Gets or sets the unique identifier for the book.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the title of the book.
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the author of the book.
    /// </summary>
    public int AuthorId { get; set; }

    /// <summary>
    /// Gets or sets the genre of the book.
    /// </summary>
    public required string Genre { get; set; }

    /// <summary>
    /// Gets or sets the image file name associated with the book.
    /// </summary>
    public required string ImageName { get; set; }

    /// <summary>
    /// Gets or sets the International Standard Book Number (ISBN) of the book.
    /// </summary>
    public required string ISBN { get; set; }

    /// <summary>
    /// Gets or sets the author entity related to the book.
    /// </summary>
    public Author? Author { get; set; }
}
