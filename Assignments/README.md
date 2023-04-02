## Assignments
> Click to expand / collapse
<details>
<summary>Week-2 Assignment</summary>

### Week-2 Assignment
#### Q1
```
You have to get a new driver's license. You show up at the office at the same time as four other people. The office says they will see everyone in alphabetical order and it takes 20 minutes for them to process each new license. All of the agents are available now, and they can each see one customer at a time. How long will it take for you to walk out with your new license?

Your input will be a string of your name me, an integer of the number of available agents, and a string of the other four names separated by spaces others.

Return the number of minutes it will take to get your license.

Examples
License("Eric", 2, "Adam Caroline Rebecca Frank") ➞ 40
// As you are in the second group of people.

License("Zebediah", 1, "Bob Jim Becky Pat") ➞ 100
// As you are the last person.

License("Aaron", 3, "Jane Max Olivia Sam") ➞ 20
// As you are the first.
*
```
Code : [Click Here](Week2-Assignment/DriverLicense.cs)<br>
For Output : [Click Here](#outputs)
#### Q2
```
Travelling through Europe one needs to pay attention to
how the license plate in the given country is displayed.
When crossing the border you need to park on the shoulder,
unscrew the plate, re-group the characters according to
the local regulations, attach it back and proceed with the journey.

Create a solution that can format the dmv number
into a plate number with correct grouping.
The function input consists of string s and group length n.
 The output has to be upper case characters and digits.
The new groups are made from right to left and connected by -.
 The original order of the dmv number is preserved.

Examples
LicensePlate("5F3Z-2e-9-w", 4) ➞ "5F3Z-2E9W"

LicensePlate("2-5g-3-J", 2) ➞ "2-5G-3J"

LicensePlate("2-4A0r7-4k", 3) ➞ "24-A0R-74K"

LicensePlate("nlj-206-fv", 3) ➞ "NL-J20-6FV"
```
Code : [Click Here](Week2-Assignment/FormatNumberPlate.cs)<br>
For Output : [Click Here](#outputs)
#### **OUTPUTS**
```
PS D:\source\repos\C# - Training\Assignments\Week2-Assignment> dotnet run
Question 1
-------------------------
Correct Order : 5F3Z-2E9W 
Correct Order : 2-5G-3J
Correct Order : 24-A0R-74K
Correct Order : NL-J20-6FV
Correct Order : HJ-23A-NP1
-------------------------
Question 2
Time taken to walk out: 40
Time taken to walk out: 100
Time taken to walk out: 20
Time taken to walk out: 60
-------------------------
```
</details>
