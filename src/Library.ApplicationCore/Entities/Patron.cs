namespace Library.ApplicationCore.Entities;

/// <summary>
/// Represents a library patron (member).
/// </summary>
public class Patron
{
    /// <summary>
    /// Gets or sets the unique identifier for the patron.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the patron.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Gets or sets the membership end date.
    /// </summary>
    public DateTime MembershipEnd { get; set; }

    /// <summary>
    /// Gets or sets the membership start date.
    /// </summary>
    public DateTime MembershipStart { get; set; }

    /// <summary>
    /// Gets or sets the image file name for the patron.
    /// </summary>
    public string? ImageName { get; set; }

    /// <summary>
    /// Gets or sets the collection of loans associated with the patron.
    /// </summary>
    public ICollection<Loan> Loans { get; set; } = new HashSet<Loan>();
}
