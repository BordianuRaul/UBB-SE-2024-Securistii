
AdminUser
BasicUser
UserRepository
UserService
UserTemplate


BidModel
BidRepository
BidService

AuctionModel
AuctionRepository
AuctionService


TAsks :
- readable code 
- no business logic in UI
- interfaces
- Osherove Unit tests, mocked unit tests
- styleCop 
	- set up
	- actually use

test = write tests

Ritchie : 
- Write the Interfaces
- test : UserService

Tibu : 
- test : AuctionRepository
- test : AuctionService

Luci:
- test: Bid Service
- test: Bid Repo

Roby
- installed testing framework(done)
- test: BidModel
- test: UserTemplate

Alisa
- set-up testing framework (done)
- test AuctionUser

Mihh
- project structure refactoring for interfaces usage-> decoupling the backend from the front end (done) 
- project set-up and configuration
- test AdminUser
- test BasicUser

- __FOR TESTING, WE NEED TO WRITE THEM IN OSHEROVE STYLE:__

Osherove-style unit tests, named after Roy Osherove, are a convention for writing unit tests that emphasizes readability, maintainability, and clarity. Roy Osherove is a prominent figure in the world of unit testing and software craftsmanship.

Here are some key principles and practices often associated with Osherove-style unit tests:

**Descriptive Test Names**: Test names should clearly describe what behavior or scenario is being tested. A reader should understand the purpose of the test just by looking at its name.
One Assert per Test: Each unit test should ideally contain only one assertion. This makes the test focused on a single aspect of the unit under test and makes it easier to pinpoint failures.
**Arrange-Act-Assert Structure (AAA)**: Tests are typically structured into three sections: Arrange (set up the test environment), Act (invoke the method or behavior being tested), and Assert (verify the expected outcome).
**Readable and Maintainable Code**: Code readability is emphasized, making it easier for other developers to understand and modify the tests as needed.
**Isolation and Mocking**: Unit tests should be isolated from external dependencies, such as databases or web services, using techniques like mocking or dependency injection. This ensures that failures are due to issues within the unit being tested rather than external factors.
**Test Data Management**: Clear management of test data, including setup and teardown procedures, to ensure tests are repeatable and consistent.
**Test First Approach (TDD)**: While not exclusive to Osherove-style testing, the practice of writing tests before writing the actual code is often advocated. This ensures that the code is written with testability in mind from the beginning.
(Courtesy of Chat Generative Pre-Trained Transformer)

- Don't forget that you have to make your own database for the project to compile and run; you can just copy-paste the SQL code from the *.sql files for it.
