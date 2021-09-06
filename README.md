# Customer Management System

# DeveloperPracticalTest
Manages customer data along with call notes.

### Development Notes
Developed using Visual Studio 2019 Community Edition

### Packages Used
| Framework      | Version     |
| -------------- | ----------- |
| netcoreapp     | 3.1         |
| Microsoft.NET.Test.Sdk | 16.9.4 | 
| MSTest.TestAdapter Version | 2.2.3 |
| MSTest.TestFramework | 2.2.3 |
| coverlet.collector | 3.0.2 |

### Project Directory
Main Project - DeveloperPracticalTest
Unit Testing - DeveloperPracticalTest.Tests

### How to run the main project
1. Clone the repo into a folder
2. Navigate to DeveloperPracticalTest and run the command  ```dotnet run```
3. Alternatively import the project into Visual Studio and click run button.
4. The unit test cases can be run using run all test cases button

### TODO
Considering the scope and time available for the project the following decision have been made
1. Unit testing is only done for Customer and CallNote Model Classes.
2. The data generated from the application is not stored in a permanent storage like database.
3. Error handling has been done to 80% of the cases. Some edge cases might be missing.

