## About Duke.ConverterExtension
That library is designed to safely convert values to string, int, decimal and etc.

## Installation
A simple way is to install it from the Nuget package library and it is ready to use. 
```sh
dotnet add package Duke.ConverterExtension
```

## Usage
This library used as C# class extension. 
Examples:

```sh
using Duke.ConverterExtension;

string data = "12345";
var UserId = data.ToSaveInt();
data = "14 jun 2000";
var TheDate = data.ToSaveDateTime();
object api_response = null;
var Respone = api_response.ToSaveString();
data = "some value from 'select' database";
var sql = $"select * from Users where email = '{data.ToSaveDbString()}'";
```
