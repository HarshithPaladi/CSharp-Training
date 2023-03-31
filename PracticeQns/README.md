# Practice Questions
## 31 March 2023
### Q1
``` An event is organized and the following has to happen. 
The chief guest needs to be picked up from the airport. 
The stage has to be decorated. 
The catering team needs to start preparing food
The transport team needs to drop the food raw materials to the venue before the cooking needs to start. 
The chief guest's speech needs to be reviewed by the PA
The venue needs to be checked for security features like bomb threat, etc
Prize distribution is set to happen at the end of the event so all the prizes that need to be presented should be brought to the venue. 
The chief guest needs to give the speech. 
Prizes need to be distributed. 
Food has to be provided to all participants. 

Please write a C# program to make use of the Async Programming concepts and write the program so that all of the above happen in a correct order.
```
Code: [Click Here](PracticeQns\AsyncQn.cs)

<details>
<summary>Output</summary>

```
Security check started..
guest arivved at airport
Raw materials picked up..
Picked up prizes from shop
Raw materials delivered !!
Food preparation started
guest at event !!
speech papers received..
Prizes at stage..
Security check ended !!
Stage Decoration started
Food Prepared !!
speech papers reviewed !!
Stage Decorated !!
Reviewed Chief guest received papers..
speech Delivered !!
prizes distributed
Lunch started
Lunch ended
............ END OF PROGRAM ............
```
</details>

### Q2
```
Create a C# program to manage a photo book using OOPs.

To start, create a class called PhotoBook.  It must also have a public method GetNumberPages that will return the number of photo book pages.

The default constructor will create an album with 16 pages. There will be an additional constructor, with which we can specify the number of pages we want in the album.

There is also a AddPhotoBook class whose constructor will create an album with 64 pages.

Finally create a PhotoBookTest class to perform the following actions:

Create a default photo book and show the number of pages
Create a photo book with 32 pages and show the number of pages
Create a large photo book and show the number of pages
```
Code: [Click Here](PracticeQns\OopsPhotoBook.cs)

<details>
<summary>Output</summary>

```
Default photobook pages : 16
Number of pages : 32
Large Photo book : 64
```
</details>

<details>
<summary>Testing Output</summary>

```
----- Running tests in class "PracticeQns.Tests.OopsPhotoBookTests" -----

MSBuild version 17.5.0+6f08c67f3 for .NET
d:\source\repos\C# - Training\PracticeQns\AsyncQn.cs(79,27): warning CS1998: This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread. [d:\source\repos\C# - Training\PracticeQns\PracticeQns.csproj]
  PracticeQns -> d:\source\repos\C# - Training\PracticeQns\bin\Debug\net6.0\PracticeQns.dll
  PracticeQnsTests -> d:\source\repos\C# - Training\PracticeQnsTests\bin\Debug\net6.0\PracticeQnsTests.dll

Build succeeded.
Time Elapsed 00:00:03.16


----- Test Execution Summary -----

PracticeQns.Tests.OopsPhotoBookTests.OopsPhotoBookTest:
    Outcome: Passed
    
PracticeQns.Tests.OopsPhotoBookTests.OopsPhotoBookTest1:
    Outcome: Passed
    
PracticeQns.Tests.OopsPhotoBookTests.getNumberPagesTest:
    Outcome: Passed
    
PracticeQns.Tests.OopsPhotoBookTests.addPhotoBookTest:
    Outcome: Passed
    
Total tests: 4. Passed: 4. Failed: 0. Skipped: 0
```
</details>

### Q3
```
Working 9 to 5
Write a function that calculates overtime and pay associated with overtime.

Working 9 to 5: regular hours
After 5pm is overtime
Your function gets an array with 4 values:

Start of working day, in decimal format, (24-hour day notation)
End of working day. (Same format)
Hourly rate
Overtime multiplier
Your function should spit out:

$ + earned that day (rounded to the nearest hundreth)
Examples
OverTime([9, 17, 30, 1.5]) ➞ "$240.00"

OverTime([16, 18, 30, 1.8]) ➞ "$84.00"

OverTime([13.25, 15, 30, 1.5]) ➞ "$52.50"
2nd example explained:

From 16 to 17 is regular, so 1 * 30 = 30
From 17 to 18 is overtime, so 1 * 30 * 1.8 = 54
30 + 54 = $84.00
```
Code: [Click Here](PracticeQns\PayCalc.cs)

<details>
<summary>Output</summary>

```
Salary is 240
Salary is 84
Salary is 52.5
```
</details>

<details>
<summary>Testing Output</summary>

```
----- Running tests in class "PracticeQns.Tests.PayCalcTests" -----

MSBuild version 17.5.0+6f08c67f3 for .NET
  PracticeQns -> d:\source\repos\C# - Training\PracticeQns\bin\Debug\net6.0\PracticeQns.dll
  PracticeQnsTests -> d:\source\repos\C# - Training\PracticeQnsTests\bin\Debug\net6.0\PracticeQnsTests.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:01.52


----- Test Execution Summary -----

PracticeQns.Tests.PayCalcTests.ingressDataTest:
    Outcome: Passed
    Standard Output Messages:
    Salary is 52.5

    
Total tests: 1. Passed: 1. Failed: 0. Skipped: 0
```
</details>