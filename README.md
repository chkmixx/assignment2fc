Student:Tomiris Chekalin
Group:IT-2503
Assignment 2:
This project is about processing telecom call records.

The program can calculate the cost of calls and process them sequentially or using two threads.

The project uses C# 12 and .NET 8.

## Main files

CallRecord.cs - stores information about a call and checks the input.

CallPricing.cs - calculates the price of one call.

CallProcessor.cs - processes calls sequentially and in parallel.

Program.cs - runs a simple example.

assignment2fc.Tests - contains xUnit tests.

## Tariff rules

KZ non-roaming calls cost 15.00 KZT per minute.

KZ roaming calls shorter than 1 minute cost 50.00 KZT.

Roaming calls from 10 minutes cost 120.00 KZT per minute.

Other valid calls use 45.00 KZT per minute.

The result is rounded to two decimal places.

## Immutability

CallRecord is a readonly record struct.

The values are set when the record is created and cannot be changed later.

The constructor checks the record ID, country and duration.

CalculateCost also checks the record because default(CallRecord) can create an invalid record without using the constructor.

## Pure function

CalculateCost is a pure function.

It does not change global data and does not use Console.

For the same CallRecord it returns the same cost.

The processing methods are not completely pure because they create threads and write results to arrays.

## Parallel processing

The input array is divided into two parts.

Each thread works with its own part of the input and its own result array.

After both threads finish, the two result arrays are added together.

This avoids using one shared counter and prevents the race condition from the assignment.

## Tests

The project uses xUnit.

The tests check:

- tariff calculations
- invalid input
- NaN and infinity
- boundary cases
- zero-minute calls
- default CallRecord
- empty and odd arrays
- null input
- 1000 records
- sequential and parallel results
- repeated parallel processing
- unchanged input records

All 23 tests passed.This project is about processing telecom call records.

The program can calculate the cost of calls and process them sequentially or using two threads.

The project uses C# 12 and .NET 8.

## Main files

CallRecord.cs - stores information about a call and checks the input.

CallPricing.cs - calculates the price of one call.

CallProcessor.cs - processes calls sequentially and in parallel.

Program.cs - runs a simple example.

assignment2fc.Tests - contains xUnit tests.

## Tariff rules

KZ non-roaming calls cost 15.00 KZT per minute.

KZ roaming calls shorter than 1 minute cost 50.00 KZT.

Roaming calls from 10 minutes cost 120.00 KZT per minute.

Other valid calls use 45.00 KZT per minute.

The result is rounded to two decimal places.

## Immutability

CallRecord is a readonly record struct.

The values are set when the record is created and cannot be changed later.

The constructor checks the record ID, country and duration.

CalculateCost also checks the record because default(CallRecord) can create an invalid record without using the constructor.

## Pure function

CalculateCost is a pure function.

It does not change global data and does not use Console.

For the same CallRecord it returns the same cost.

The processing methods are not completely pure because they create threads and write results to arrays.

## Parallel processing

The input array is divided into two parts.

Each thread works with its own part of the input and its own result array.

After both threads finish, the two result arrays are added together.

This avoids using one shared counter and prevents the race condition from the assignment.

## Tests

The project uses xUnit.

The tests check:

- tariff calculations
- invalid input
- NaN and infinity
- boundary cases
- zero-minute calls
- default CallRecord
- empty and odd arrays
- null input
- 1000 records
- sequential and parallel results
- repeated parallel processing
- unchanged input records

All 23 tests passed.
This project is about processing telecom call records.

The program can calculate the cost of calls and process them sequentially or using two threads.

The project uses C# 12 and .NET 8.

## Main files

CallRecord.cs - stores information about a call and checks the input.

CallPricing.cs - calculates the price of one call.

CallProcessor.cs - processes calls sequentially and in parallel.

Program.cs - runs a simple example.

assignment2fc.Tests - contains xUnit tests.

## Tariff rules

KZ non-roaming calls cost 15.00 KZT per minute.

KZ roaming calls shorter than 1 minute cost 50.00 KZT.

Roaming calls from 10 minutes cost 120.00 KZT per minute.

Other valid calls use 45.00 KZT per minute.

The result is rounded to two decimal places.

## Immutability

CallRecord is a readonly record struct.

The values are set when the record is created and cannot be changed later.

The constructor checks the record ID, country and duration.

CalculateCost also checks the record because default(CallRecord) can create an invalid record without using the constructor.

## Pure function

CalculateCost is a pure function.

It does not change global data and does not use Console.

For the same CallRecord it returns the same cost.

The processing methods are not completely pure because they create threads and write results to arrays.

## Parallel processing

The input array is divided into two parts.

Each thread works with its own part of the input and its own result array.

After both threads finish, the two result arrays are added together.

This avoids using one shared counter and prevents the race condition from the assignment.

## Tests

The project uses xUnit.

The tests check:

- tariff calculations
- invalid input
- NaN and infinity
- boundary cases
- zero-minute calls
- default CallRecord
- empty and odd arrays
- null input
- 1000 records
- sequential and parallel results
- repeated parallel processing
- unchanged input records

All 23 tests passed.
This project is about processing telecom call records.

The program can calculate the cost of calls and process them sequentially or using two threads.

The project uses C# 12 and .NET 8.

## Main files

CallRecord.cs - stores information about a call and checks the input.

CallPricing.cs - calculates the price of one call.

CallProcessor.cs - processes calls sequentially and in parallel.

Program.cs - runs a simple example.

assignment2fc.Tests - contains xUnit tests.

## Tariff rules

KZ non-roaming calls cost 15.00 KZT per minute.

KZ roaming calls shorter than 1 minute cost 50.00 KZT.

Roaming calls from 10 minutes cost 120.00 KZT per minute.

Other valid calls use 45.00 KZT per minute.

The result is rounded to two decimal places.

## Immutability

CallRecord is a readonly record struct.

The values are set when the record is created and cannot be changed later.

The constructor checks the record ID, country and duration.

CalculateCost also checks the record because default(CallRecord) can create an invalid record without using the constructor.

## Pure function

CalculateCost is a pure function.

It does not change global data and does not use Console.

For the same CallRecord it returns the same cost.

The processing methods are not completely pure because they create threads and write results to arrays.

## Parallel processing

The input array is divided into two parts.

Each thread works with its own part of the input and its own result array.

After both threads finish, the two result arrays are added together.

This avoids using one shared counter and prevents the race condition from the assignment.

## Tests

The project uses xUnit.

The tests check:

- tariff calculations
- invalid input
- NaN and infinity
- boundary cases
- zero-minute calls
- default CallRecord
- empty and odd arrays
- null input
- 1000 records
- sequential and parallel results
- repeated parallel processing
- unchanged input records

All 23 tests passed.
This project is about processing telecom call records.

The program can calculate the cost of calls and process them sequentially or using two threads.

The project uses C# 12 and .NET 8.

## Main files

CallRecord.cs - stores information about a call and checks the input.

CallPricing.cs - calculates the price of one call.

CallProcessor.cs - processes calls sequentially and in parallel.

Program.cs - runs a simple example.

assignment2fc.Tests - contains xUnit tests.

## Tariff rules

KZ non-roaming calls cost 15.00 KZT per minute.

KZ roaming calls shorter than 1 minute cost 50.00 KZT.

Roaming calls from 10 minutes cost 120.00 KZT per minute.

Other valid calls use 45.00 KZT per minute.

The result is rounded to two decimal places.

## Immutability

CallRecord is a readonly record struct.

The values are set when the record is created and cannot be changed later.

The constructor checks the record ID, country and duration.

CalculateCost also checks the record because default(CallRecord) can create an invalid record without using the constructor.

## Pure function

CalculateCost is a pure function.

It does not change global data and does not use Console.

For the same CallRecord it returns the same cost.

The processing methods are not completely pure because they create threads and write results to arrays.

## Parallel processing

The input array is divided into two parts.

Each thread works with its own part of the input and its own result array.

After both threads finish, the two result arrays are added together.

This avoids using one shared counter and prevents the race condition from the assignment.

## Tests

The project uses xUnit.

The tests check:

- tariff calculations
- invalid input
- NaN and infinity
- boundary cases
- zero-minute calls
- default CallRecord
- empty and odd arrays
- null input
- 1000 records
- sequential and parallel results
- repeated parallel processing
- unchanged input records

All 23 tests passed.
This project is about processing telecom call records.

The program can calculate the cost of calls and process them sequentially or using two threads.

The project uses C# 12 and .NET 8.

## Main files

CallRecord.cs - stores information about a call and checks the input.

CallPricing.cs - calculates the price of one call.

CallProcessor.cs - processes calls sequentially and in parallel.

Program.cs - runs a simple example.

assignment2fc.Tests - contains xUnit tests.

## Tariff rules

KZ non-roaming calls cost 15.00 KZT per minute.

KZ roaming calls shorter than 1 minute cost 50.00 KZT.

Roaming calls from 10 minutes cost 120.00 KZT per minute.

Other valid calls use 45.00 KZT per minute.

The result is rounded to two decimal places.

## Immutability

CallRecord is a readonly record struct.

The values are set when the record is created and cannot be changed later.

The constructor checks the record ID, country and duration.

CalculateCost also checks the record because default(CallRecord) can create an invalid record without using the constructor.

## Pure function

CalculateCost is a pure function.

It does not change global data and does not use Console.

For the same CallRecord it returns the same cost.

The processing methods are not completely pure because they create threads and write results to arrays.

## Parallel processing

The input array is divided into two parts.

Each thread works with its own part of the input and its own result array.

After both threads finish, the two result arrays are added together.

This avoids using one shared counter and prevents the race condition from the assignment.

## Tests

The project uses xUnit.

The tests check:

- tariff calculations
- invalid input
- NaN and infinity
- boundary cases
- zero-minute calls
- default CallRecord
- empty and odd arrays
- null input
- 1000 records
- sequential and parallel results
- repeated parallel processing
- unchanged input records

All 23 tests passed.
<img width="1622" height="853" alt="image" src="https://github.com/user-attachments/assets/3ac90c1d-4d3d-4816-9d44-26aef848b3c6" />

## Limitations

The parallel version uses two threads because it is required by the assignment.

For small arrays, parallel processing may not be faster because creating threads also takes time.

The tests show that the program works correctly for the tested cases, but they cannot prove that every possible concurrency problem is impossible.

