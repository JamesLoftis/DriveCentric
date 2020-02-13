# FizzBuzz

## Table of Contents

- [About](#about)
- [Usage](#usage)


## About <a name = "about"></a>

The classic FizzBuzz problem is as follows:  Write a short program that prints each number from 1 to 100 on a new line. For each multiple of 3, print "Fizz" instead of the number. For each multiple of 5, print "Buzz" instead of the number. For numbers which are multiples of both 3 and 5, print "FizzBuzz" instead of the number.

For this coding exercise, I developed a C# .NET Core Web API for a generic FizzBuzz solver. The max number (e.g. 100), multiples (e.g. 3 and 5), and printed words (e.g. "Fizz" and "Buzz") should all be dynamic and specified as part of the web request body as JSON. Handle exceptions and write tests where necessary. Demonstrate modern development practices with readable, maintainable, testable code.

I Provided example HTTP requests and responses for use cases using Postman or similar.  
Usage
## Usage <a name = "getting_started"></a>

To Run: 
        
        cd FizzBuzz
        dotnet run

For Postman:
```        
Import the json file from the /postman directory into post man, and run individual api posts against a running endpoint: https://localhost:5001/Fizzbuzz

NOTE: May need to turn off 'SSL Certificate Verification' in Postman Settings
``` 

To Run Unit Tests:

        cd FizzBuzz.Tests
        dotnet test



### Prerequisites

What things you need to install the software and how to install them.

```
DotNet Core
Postman
```
