# ADConnectionTest

This dotnet core app tests your connection strings.
You add a list of connection strings to a file and this app tests them all. 
Can run tests on a remote server or local machine

## Requires: 
* File with List of connection strings per line
* Setup Environment Variable with name *connectionsFile* that specifies the url to the file.

## Execution
### from Visual Studio
 * Open Project in Visual Studio
 * Open Test Explorer Window
 * Click Run all tests
### from commandline
`dotnet test`
