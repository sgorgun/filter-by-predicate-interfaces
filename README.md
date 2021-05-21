# Filter by Various Predicate. Interfaces

## Task description ##

- Analyze your solutions of the `Filter by Digit` and `Filter by Palindromic` tasks in terms of code common to them. What part of the code can be made reusable, and which part is customizable, depending on the specific way of matching the number with a certain attribute (`predicate`)?    
- Using the capabilities of `interfaces`, propose the option of allocating reusable code. Do not use LINQ or delegates.
- Place common code into project [Filter By Various Predicates](/FilterByVariousPredicates).
- Demonstrate the possibility of using common code with two different predicate of the number. Place solutions for predicates in two separate projects:
    - [Filter by Digit](/FilerByDigit);
    - [Filter by Palindromic](/FilterByPalindromic).
- Suggest your custom version of the predicate and place it in separate project.
- Develop unit tests. Consider testing large arrays.
