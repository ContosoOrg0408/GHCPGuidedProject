# AccelerateDevGitHubCopilot

## Project Overview
This project is a modular library management system built with C# and .NET 8.0. It is organized into three main layers:
- **ApplicationCore**: Contains core business entities, enums, interfaces, and services.
- **Infrastructure**: Handles data access and repository implementations (JSON-based).
- **Console**: Provides a console-based user interface for interacting with the library system.

## Solution Structure
- `src/Library.ApplicationCore/` — Core domain logic
- `src/Library.Infrastructure/` — Data access and repository implementations
- `src/Library.Console/` — Console application for user interaction
- `tests/UnitTests/` — Unit tests for core logic

---

## Class and Method Organization

### ApplicationCore
#### Entities
- **Author**: `Id`, `Name`
- **Book**: `Id`, `Title`, `AuthorId`, `Genre`, `ImageName`, `ISBN`, `Author`
- **BookItem**: `Id`, `BookId`, `AcquisitionDate`, `Condition`, `Book`
- **Loan**: `Id`, `BookItemId`, `PatronId`, `Patron`, ...
- **Patron**: (not fully listed)

#### Enums
- **LoanExtensionStatus**
- **LoanReturnStatus**
- **MembershipRenewalStatus**
- **EnumHelper**: `GetDescription(Enum value)`

#### Interfaces
- **ILoanRepository**: Data access for loans
- **ILoanService**: Business logic for loans
- **IPatronRepository**: Data access for patrons
- **IPatronService**: Business logic for patrons

#### Services
- **LoanService**
  - `LoanService(ILoanRepository)`
  - `Task<LoanReturnStatus> ReturnLoan(int loanId)`
  - `Task<LoanExtensionStatus> ExtendLoan(int loanId)`
- **PatronService**
  - `PatronService(IPatronRepository)`
  - `Task<MembershipRenewalStatus> RenewMembership(int patronId)`

---

### Infrastructure
#### Data
- **JsonData**
  - `Task EnsureDataLoaded()`
  - `Task LoadData()`
  - `Task SaveLoans(IEnumerable<Loan>)`
  - `Task SavePatrons(IEnumerable<Patron>)`
  - `List<Patron> GetPopulatedPatrons(IEnumerable<Patron>)`
  - `Patron GetPopulatedPatron(Patron)`
  - `Loan GetPopulatedLoan(Loan)`
  - `BookItem GetPopulatedBookItem(BookItem)`
  - `Book GetPopulatedBook(Book)`
- **JsonLoanRepository** (implements ILoanRepository)
  - `Task<Loan?> GetLoan(int id)`
  - `Task UpdateLoan(Loan loan)`
- **JsonPatronRepository** (implements IPatronRepository)
  - `Task<List<Patron>> SearchPatrons(string searchInput)`
  - `Task<Patron?> GetPatron(int id)`
  - `Task UpdatePatron(Patron patron)`

---

### Console
- **ConsoleApp**
  - `ConsoleApp(ILoanService, IPatronService, IPatronRepository, ILoanRepository)`
  - `Task Run()`
  - `static string ReadPatronName()`
  - `static void PrintPatronsList(List<Patron>)`
  - `static CommonActions ReadInputOptions(CommonActions, out int)`
  - `static void WriteInputOptions(CommonActions)`
- **CommonActions** (enum)
- **ConsoleState** (enum)

---

## How to Run
1. Build the solution using Visual Studio or `dotnet build`.
2. Run the console app from `src/Library.Console/`.
3. Data is stored in JSON files under `src/Library.Console/Json/`.

---

## Testing
Unit tests are located in `tests/UnitTests/` and cover core business logic.

---

## Notes
- The system is designed for extensibility and separation of concerns.
- All data access is abstracted via interfaces and implemented using JSON repositories.
- The console app provides a simple UI for library operations.
