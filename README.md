## A Solution for Random Shuffle List

### The Requirements:

> Please write a program that generates a list of 10,000 numbers in random order each time it is run. Each number in the list must be unique and be between 1 and 10,000 (inclusive).

### The Algorithm

> This solution implemented Durstenfeld's version of Fisher–Yates in place suffle algorithm, time complexity is O(N) and space complexity is O(1).

#### Is this Solution 100% Random Shuffle?
> No, even though correctness of Fisher–Yates Algroithm can be mathematical proved. However because of following two reasons , this implementation is not able to achive 100% random shuffle. 

* Modulo bias - To generate random numbers in every range from 0–1 to 0–n pretty much guarantees that some of these ranges will not evenly divide the natural range of the random number generator. Thus, the remainders will not always be evenly distributed and, worse yet, the bias will be systematically in favor of small remainders. Referrence at https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle#Modulo_bias 
* Problem with pseudorandom generators (This is may or may not happens in C#). Referrence at https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle#Pseudorandom_generators:_problems_involving_state_space.2C_seeding.2C_and_usage

#### How random is this implementation?
> Following are two charts shows frequency of each number appears on each index. Those two charts are based on size 100 random shuffle list which conatins 1 to 100. First Chart shows frequency of 1000 such lists and second on based on 10000 such lists.
[<img src="./Images/freq1.png">]
[<img src="./Images/freq2.png">]

### Required Libaray
* Nunit 2.6 or plus http://www.nunit.org/
* .Net 4.5

### Usage

####This solution contains three projects

* Pandell.RandomShuffledListGeneratorDemo - which contain code to show how to use actual random shuffler.
* Pandell.ListShuffler - class libaray, which contains two classes.
   * Implementations of Fisher–Yates in place suffle algorithm.
   * API -  InPlaceShuffle<T> (List<T> list)
   * A RandomShuffledListGenerator - which can genrate a list of 10,000 numbers in random order and each number in the list   is  unique and be between 1 and 10,000 (inclusive).
   * API - GetShuffledIntListOneToTenThousand()
* Pandell.Tests - Unit Tests for Pandell.ListRandomShuffler, requires Nunit 2.6.

####Build and Run

* This solution works with VS2015 (it should work with VS2013 as well)
* To Run RandomShuffledListGeneratorDemo, set RandomShuffledListGeneratorDemo as startup project, build and run.
* To use ListShuffler in your code, simpley include class library in your code.
* For unit tests, please use Nunit-GUI 2.6 or plus which is avaiable at http://www.nunit.org/index.php?p=download