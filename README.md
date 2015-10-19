## A Solution for Random Shuffle List

### The Requirements:

> Please write a program that generates a list of 10,000 numbers in random order each time it is run. Each number in the list must be unique and be between 1 and 10,000 (inclusive).

### The Algorithm

> This solution implemented Durstenfeld's version of Fisher–Yates in place suffle algorithm, time complexity is O(N) and space complexity is O(1)

#### Is this Solution 100% Random Shuffle?
> No, Beacuse of following two reasons

* Modulo bias https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle#Modulo_bias 
* Pseudorandom generators https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle#Pseudorandom_generators:_problems_involving_state_space.2C_seeding.2C_and_usage

### Required Libaray
* Nunit 2.6 or plus http://www.nunit.org/
* .Net 4.5

### Usage

####This solution contains three projects

* Pandell.RandomShuffledListGeneratorDemo - which contain code to show how to use actual random shuffler
* Pandell.ListShuffler - class libaray, which contains two classes
   * Implementations of Fisher–Yates in place suffle algorithm
   * A RandomShuffledListGenerator - which can genrate a list of 10,000 numbers in random order and each number in the list   is  unique and be between 1 and 10,000 (inclusive).
* Pandell.Tests - Unit Tests for Pandell.ListRandomShuffler, requires Nunit 2.6 

####Build and Run

* Open solution with VS2015 (it should work with VS2013 as well)
* Build and Run - This soultion is build against .Net 4.5
* For unit tests, please use Nunit-GUI 2.6 or plus which is avaiable at http://www.nunit.org/index.php?p=download