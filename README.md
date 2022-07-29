# Filter by Various Predicate. Interfaces

Intermediate level task for practicing inheritance classes, abstract classes and methods, Template Method design pattern.

Estimated time to complete the task - 2h.

The task requires .NET 6 SDK installed.

## Task description

- Develop the [ArrayExtensions](ArrayExtensions) class with following methods:

    - the `FilterByDigit` method, which takes an array of integers as a parameter and, based on it, forms a new array only from those elements that contain the given digit;
    - the `FilterByPalindromic` method, which takes an array of integers as a parameter and, based on it, forms a new array only from those elements that are palindromes.    
    _When implementing these methods, follow the suggested skeletons._

- Analyze the resulting methods:
    - what part of their code is the same?
    - which part depends on a specific _predicate_*?      
    _*A predicate  is a statement made about a subject. The subject of the statement is that about which the statement is made. A predicate in programming is an expression that uses one or more values with a boolean result._

    _Discuss this question and your answer with your trainer, if you work in a regular group._

- Define predicate as a `Verify` method of the [IPredicate](FilterByPredicate/IPredicate.cs) interface. The implementation details of the predicate logic are left to the derived classes.

- Put the common part of the code as a skeleton of operations in the `Select` extesion method of the [ArrayExtensions](FilterByPredicate) static class. The method must contain the `IPredicate` interface as a parameter.

- Develop derived classes for described above predicates. Place the solutions in two separate projects:

    - [Filter by Digit](FilerByDigit);
    - [Filter by Palindromic](FilterByPalindromic).

- Run all unit tests.

- Study [mock](http://xunitpatterns.com/Mock%20Object.html) tests and the [Moq](https://github.com/Moq/moq4/wiki/Quickstart) Framework.

- Suggest your custom version of the predicate and place it in separate project. Add unit tests for this solution to [FilterTests](FilterByPredicates.Tests/FilterTests.cs) class.

- Study the [Strategy](https://refactoring.guru/design-patterns/strategy) design pattern.
