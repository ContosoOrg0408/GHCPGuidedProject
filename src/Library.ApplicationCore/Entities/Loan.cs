namespace Library.ApplicationCore.Entities;

/// <summary>
/// Represents a loan transaction for a book item in the library.
/// </summary>
public class Loan
{
    /// <summary>
    /// Gets or sets the unique identifier for the loan.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the book item being loaned.
    /// </summary>
    public int BookItemId { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the patron who borrowed the book item.
    /// </summary>
    public int PatronId { get; set; }

    /// <summary>
    /// Gets or sets the patron entity associated with the loan.
    /// </summary>
    public Patron? Patron { get; set; }

    /// <summary>
    /// Gets or sets the date when the loan was made.
    /// </summary>
    public DateTime LoanDate { get; set; }

    /// <summary>
    /// Gets or sets the due date for returning the book item.
    /// </summary>
    public DateTime DueDate { get; set; }

    /// <summary>
    /// Gets or sets the date when the book item was returned, if applicable.
    /// </summary>
    public DateTime? ReturnDate { get; set; }

    /// <summary>
    /// Gets or sets the book item entity associated with the loan.
    /// </summary>
    public BookItem? BookItem { get; set; }
}
