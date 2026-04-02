using Library.ApplicationCore.Entities;

namespace Library.ApplicationCore;

/// <summary>
/// Defines methods for accessing and updating loan data.
/// </summary>
public interface ILoanRepository {
    /// <summary>
    /// Retrieves a loan by its unique identifier.
    /// </summary>
    /// <param name="loanId">The unique identifier of the loan.</param>
    /// <returns>The loan if found; otherwise, null.</returns>
    Task<Loan?> GetLoan(int loanId);

    /// <summary>
    /// Updates the specified loan in the data store.
    /// </summary>
    /// <param name="loan">The loan to update.</param>
    Task UpdateLoan(Loan loan);
}