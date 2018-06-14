# Lecture-Testing
Firstly some knowledge base: https://www.tutorialspoint.com/software_engineering/software_testing_overview.htm

# Talk
- How tests work under cover
	- From code, through test framework into test discovery and test runner to test explorer
- Test frameworks:
	- Table comparison
	- MSTest
	- XUnit
	- NUnit
	- Examples
- The great testing pyramid
- Unit tests
	- Arrange -> Act -> Assert
	- Mocking
- Property based tests
- TDD
	- Perfect world
	- Pitfalls (design, architecture)
- Integration tests
- BDD
	- From story through acceptance criteria to test
	- AKA test suite as a specification
	- Given -> When -> Then
- Regression tests
- UI tests
	- Recorded
	- Coded
	- Image comparison

# Demos:
- Test frameworks
- TDD
- Moq
- Property based tests
- BDD
- Test suite as specification http://gasparnagy.com/2017/04/specflow-without-code-behind-files/
- F# as a cherry on top for BDD
	```
	let ``When 2 is added to 2 expect 4``() =
		Assert.AreEqual(4, 2+2)
	```