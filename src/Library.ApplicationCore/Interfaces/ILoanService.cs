using Library.ApplicationCore.Enums;

/// <summary>
/// Provides business logic for managing loans.
/// </summary>
public interface ILoanService
{
    /// <summary>
    /// Processes the return of a loaned book item.
    /// </summary>
    /// <param name="loanId">The unique identifier of the loan.</param>
    /// <returns>The status of the return operation.</returns>
    Task<LoanReturnStatus> ReturnLoan(int loanId);

    /// <summary>
    /// Extends the due date of a loaned book item.
    /// </summary>
    /// <param name="loanId">The unique identifier of the loan.</param>
    /// <returns>The status of the extension operation.</returns>
    Task<LoanExtensionStatus> ExtendLoan(int loanId);
}