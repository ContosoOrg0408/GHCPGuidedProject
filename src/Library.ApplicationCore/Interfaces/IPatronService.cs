using Library.ApplicationCore.Enums;

/// <summary>
/// Provides business logic for managing patron memberships.
/// </summary>
public interface IPatronService
{
    /// <summary>
    /// Renews the membership of a patron.
    /// </summary>
    /// <param name="patronId">The unique identifier of the patron.</param>
    /// <returns>The status of the renewal operation.</returns>
    Task<MembershipRenewalStatus> RenewMembership(int patronId);
}
