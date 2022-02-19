
OPTION 2 - Java 

Good day Student X, 
I just finished reviewing your Java solution on recursion and here is a breakdown of my review with all the suggested improvements and general comments. 
Question 1: Recursive function that reverse a string 
Firstly, this is a good solution because you have no semantic errors in your solution. The solution is easy to follow and has great logical flow. In summary, your solution to the string reversal problem is correct.   
Additionally, based on the most common solutions provided on the internet, this is the most efficient approach when solving the problem recursively. However, there are some key areas you could improve on, which are:
1. Error checking 
In the reverse string method, on line 20, you validate the string by checking if it is empty but there are no null checks. 

2. Presentation
You could do without some print statments, particulary those on lines 21 and 25. The user does not need to see the string as it is being reversed unless you are using these logs to debug. Then in that case, remember to clean up all logs before submitting a solution. 
i. Java naming conventions - Ideally, you should use camel case when name your class methods. Here is the regular expression for reference: ^[a-z][a-zA-Z0-9]*$ 
An example of that complies with this regular exppresion is naming your method like this reverseString. This will make your code readable and improve the presentation in general
3. Documentation 
The positive aspect of the documentation is that it is brief. However, you could do more work by being more precise. On line 9, you used parameter instead of argument. 
Lastly, on line 26, you called your method with a different name from the name definition on line 18 and that caused a syntax error. 

Question 2: Fibonacci series
1. A good attempt, but there is a lot more work that needs to be done on this solution. There are quite a number of semantic errors that the solution has that need to be fixed. In addition, you hardcoded the solution in line 11. Overall the solution was not correct and will not solve the problem. 
2. While using loops is more efficient with bigger data set, the question requires you to use a recursive approach to solve the solution.
3. Scope - on line 30 you redfined the maxNumber variable which was already within the same scope (in the definition of the method) and that resulted in some syntax errors, ideally you should have assigned the argument passed in on the method to the local max variable you were creating within that function 



