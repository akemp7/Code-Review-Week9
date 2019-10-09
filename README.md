# _Anita Kemp's Word Counter_

#### _A console app to check the token frequency of a word in a sentence as part of the week 9 code review at Epicodus, 10/4/19._

#### By _**Anita Kemp**_

## Description

_This program will allow the user to enter a sentence and a word of interest. It will then check how many times the word appears in the user sentence. It will then return to the user a word count._

## Specifications

| Behavior | Input | Output | Explanation|
| -------- | :---------: | :---------: | :----------:|
|The program will prompt user to enter a sentence if left blank | "" | "Please enter a sentence" | This is in order to control for blank input.|
|The program will disregard upper case letters| "THE CAT SLEEPS." | "the cat sleeps."| This will ensure a more accurate token count|
| The program will return instances of a specified word from the user.| "cat" "The cat was friends with another "cat" | "cat" "cat"| This is to ensure that the program is getting all instances of the specified word, and not getting a word like "cathedral"|
| The program will disregard instances of cat with different affixes or in words like "cathedral"| "The cats are friends with cat one and cat two"| "cat" "cat" | In order to control for token count of particular word.|
| The program will perform a token count| "cat" "cat" "cat" | Token Count: 3 | Having generated all instances of the token, it should now be able to return a count|

## Setup/Installation Requirements

* _Clone this repository and navigate to the WordCount.Solution and then to "WordCount" project directory_
* _Run the command "dotnet restore"_
* _Run the command "dotnet run"_

## Technologies Used

_C#, .NET_

### License

*MIT*

Copyright (c) 2019 **_Anita Kemp_**