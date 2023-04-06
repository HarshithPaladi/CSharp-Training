# Practice Questions
> Click to expand / collapse
<details>
<summary>31 March 2023 Questions</summary>

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
Code: [Click Here](PracticeQns/AsyncQn.cs)

<details>
<summary>Output ✔️</summary>

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
Code: [Click Here](PracticeQns/OopsPhotoBook.cs)<br>
Testing Code: [Click Here](PracticeQnsTests/OopsPhotoBookTests.cs)

<details>
<summary>Output ✔️</summary>

```
Default photobook pages : 16
Number of pages : 32
Large Photo book : 64
```
</details>

<details>
<summary>Testing Output ✔️</summary>

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
Code: [Click Here](PracticeQns/PayCalc.cs)<br>
Testing Code: [Click Here](PracticeQnsTests/PayCalcTests.cs)

<details>
<summary>Output ✔️</summary>

```
Salary is 240
Salary is 84
Salary is 52.5
```
</details>

<details>
<summary>Testing Output ✔️</summary>

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
</details>
<details>
<summary>03 April 2023 Questions</summary>

### Q1
```
Question:
English to Pig Latin Translator



Pig latin has two very simple rules:

If a word starts with a consonant move the first letter(s) of the word, till you reach a vowel, to the end of the word and add "ay" to the end.
have ➞ avehay
cram ➞ amcray
take ➞ aketay
cat ➞ atcay
shrimp ➞ impshray
hrimps
rimpsh
impshr
mpshri

trebuchet ➞ ebuchettray
If a word starts with a vowel add "yay" to the end of the word.
ate ➞ ateyay
apple ➞ appleyay
oaken ➞ oakenyay
eagle ➞ eagleyay
Write two functions to make an English to pig latin translator. The first function TranslateWord(word) takes a single word and returns that word translated into pig latin. The second function TranslateSentence(sentence) takes an English sentence and returns that sentence translated into pig latin.

Examples
TranslateWord("flag") ➞ "agflay"

TranslateWord("Apple") ➞ "Appleyay"

TranslateWord("button") ➞ "uttonbay"

TranslateWord("") ➞ ""

TranslateSentence("I like to eat honey waffles.") ➞ "Iyay ikelay otay eatyay oneyhay afflesway."

TranslateSentence("Do you think it is going to rain today?") ➞ "Oday ouyay inkthay ityay isyay oinggay otay ainray odaytay?"
Notes
Regular expressions will help you not mess up the punctuation in the sentence.
If the original word or sentence starts with a capital letter, the translation should preserve its case (see examples #2, #5 and #6).
```
Code: [Click Here](PracticeQns/EnglishToPigLatin.cs)<br>
Testing Code: [Click Here](PracticeQnsTests/IEnglishToPigLatinTests.cs)
<details>
<summary>Output ✔️</summary>

```
impshray
qwtyhkay!?.
Iyay ikelay otay eatyay oneyhay afflesway
Oday ouyay Inkthay ityay isyay oinggay otay ainray odaytay?
Oday ouyay Inkthay, ityay isyay oinggay otay Ainray odaytay?
```
</details>
<details>
<summary>Testing Output ✔️</summary>

```
----- Running tests in class "PracticeQns.Tests.IEnglishToPigLatinTests" -----

MSBuild version 17.5.0+6f08c67f3 for .NET
Build succeeded.
Time Elapsed 00:00:15.66
----- Test Execution Summary -----

PracticeQns.Tests.IEnglishToPigLatinTests.TranslateWordTest:
    Outcome: Passed
    Standard Output Messages:
    Expected result: impshray?!.
Actual Result: impshray?!.

    
PracticeQns.Tests.IEnglishToPigLatinTests.TranslateSentenceTest:
    Outcome: Passed
    Standard Output Messages:
    Expected result: Oday ouyay inkthay ityay isyay oinggay otay ainray odaytay?
Actual Result: Oday ouyay inkthay ityay isyay oinggay otay ainray odaytay?

    
Total tests: 2. Passed: 2. Failed: 0. Skipped: 0
```
</details>
</details>
<details>
<summary>05 April 2023 Questions</summary>

### Q1
```
In this challenge, you have to establish which kind of Poker combination is present in a deck of five cards. Every card is a string containing the card value (with the upper-case initial for face-cards) and the lower-case initial for suits, as in the examples below:
"Ah" ➞ Ace of hearts
"Ks" ➞ King of spades
"3d" ➞ Three of diamonds
"Qc" ➞ Queen of clubs
"10c" ➞ Ten of clubs
There are 10 different combinations. Here's the list, in decreasing order of importance:
Name	Description
Royal Flush	A, K, Q, J, 10, all with the same suit.
Straight Flush	Five cards in sequence, all with the same suit.
Four of a Kind	Four cards of the same rank.
Full House	Three of a Kind with a Pair.
Flush	Any five cards of the same suit, not in sequence.
Straight	Five cards in a sequence, but not of the same suit.
Three of a Kind	Three cards of the same rank.
Two Pair	Two different Pair.
Pair	Two cards of the same rank.
High Card	No other valid combination.
Given an array hand containing five strings being the cards,
implement a function that returns a string with the name of the highest combination obtained, accordingly to the table above.
Examples
PokerHandRanking({ "10h", "Jh", "Qh", "Ah", "Kh" }) ➞ "Royal Flush"
PokerHandRanking({ "3h", "5h", "Qs", "9h", "Ad" }) ➞ "High Card"
PokerHandRanking({ "10s", "10c", "8d", "10d", "10h" }) ➞ "Four of a Kind"
```
Code: [Click Here](PracticeQns/Combination.cs)<br>
Testing Code: [Click Here](PracticeQnsTests/CombinationTests.cs)<br>
<details>
<summary>Output ✔️</summary>

```
Royal Flush
Straight Flush
Four Of A Kind
Full House
Three Of A Kind
```
</details>
<details>
<summary>Testing Output ✔️</summary>

```
----- Running tests in class "PracticeQns.Tests.CombinationTests" -----

MSBuild version 17.5.0+6f08c67f3 for .NET
Build succeeded.
Time Elapsed 00:00:03.07


----- Test Execution Summary -----

PracticeQns.Tests.CombinationTests.IsRoyalFlushTest:
    Outcome: Passed
    
PracticeQns.Tests.CombinationTests.IsStraightFlushTest:
    Outcome: Passed
    
PracticeQns.Tests.CombinationTests.IsFourOfAKindTest:
    Outcome: Passed
    
PracticeQns.Tests.CombinationTests.IsFullHouseTest:
    Outcome: Passed
    
PracticeQns.Tests.CombinationTests.IsThreeOfAKindTest:
    Outcome: Passed
    
PracticeQns.Tests.CombinationTests.IsStraightTest:
    Outcome: Passed
    
PracticeQns.Tests.CombinationTests.IsFlushTest:
    Outcome: Passed
    
PracticeQns.Tests.CombinationTests.IsTwoPairsTest:
    Outcome: Passed
    
PracticeQns.Tests.CombinationTests.IsPairsTest:
    Outcome: Passed
    
Total tests: 9. Passed: 9. Failed: 0. Skipped: 0
```
</details>
</details>
</details>
<details>
<summary>06 April 2023 Questions</summary>

### Q3
```
In Nico Cipher, encoding is done by creating a numeric key and assigning each letter position of the message with the provided key.

Create a function that takes two arguments, key and message, and returns the encoded message.

There are some variations on the rules of encipherment. One version of the cipher rules are outlined below:

message = "mubashirhassan"
key = "crazy"
c r a z y -> a c r y z
             1 2 3 4 5
2 3 1 5 4
nicoCipher(message, key) ➞ "bmusarhiahass n"
Step 1: Assign numbers to sorted letters from the key:

"crazy" = 23154
Step 2: Assign numbers to the letters of the given message:

2 3 1 5 4
---------
m u b a s
h i r h a
s s a n  
Step 3: Sort columns as per assigned numbers:

1 2 3 4 5
---------
b m u s a
r h i a h
a s s   n
Step 4: Return encoded message Rows-wise:
eMessage = "bmusarhiahass n"
Examples
NicoCipher("mubashirhassan", "crazy") ➞ "bmusarhiahass n"

NicoCipher("edabitisamazing", "matt") ➞ "deabtiismaaznig "
2 1 3 4
deabtiismaaznig
NicoCipher("iloveher", "612345") ➞ "lovehir    e"
6 1 2 3 4 5
i l o v e h
e r
--
1 2 3 4 5 6
l o v e h i
r         e
Notes
Keys will have alphabets or numbers only.
```
Code: [Click Here](PracticeQns/NicoCipher.cs)<br>
Testing Code: [Click Here](PracticeQnsTests/NicoCipherEncoderTests.cs)<br>
<details>
<summary>Output ✔️</summary>

```
bmusarhiahass n
deabtiismaaznig
lovehir    e
```
</details>
<details>
<summary>Testing Output ✔️</summary>

```
----- Running tests in class "PracticeQns.Tests.NicoCipherEncoderTests" -----

MSBuild version 17.5.0+6f08c67f3 for .NET
Build succeeded.
Time Elapsed 00:00:01.99
----- Test Execution Summary -----

PracticeQns.Tests.NicoCipherEncoderTests.NicoCipherTest_mubashirhassan:
    Outcome: Passed
    Standard Output Messages:
    Expected result: bmusarhiahass n
Actual Result: bmusarhiahass n

    
PracticeQns.Tests.NicoCipherEncoderTests.NicoCipherTest_edabitisamazing:
    Outcome: Passed
    Standard Output Messages:
    Expected result: deabtiismaaznig 
Actual Result: deabtiismaaznig 

    
PracticeQns.Tests.NicoCipherEncoderTests.NicoCipherTest_iloveher:
    Outcome: Passed
    Standard Output Messages:
    Expected result: lovehir    e
Actual Result: lovehir    e

    
Total tests: 3. Passed: 3. Failed: 0. Skipped: 0


```
</details>
</details>