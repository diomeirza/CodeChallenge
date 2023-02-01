// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");

HighestChar.CountHighestChar("sagjsdhgbja");

TuringTest test = new TuringTest();
int luckyNumber = test.FindLuckyNumber(new int[] { 2,2,2,3,3});
Console.WriteLine($"lucky number = {luckyNumber}");

string param = "ab-cd?/";
string reverseLetter = test.ReverseOnlyLetters(param);
Console.WriteLine($"reverse letter from {param} is {reverseLetter}");

param = "wxstwxuzuyuvyzrsxysxyuvyqxuxyskqwsyqumqrvopvowqumnvrxpwqpwsrnvrztxrxpvuxunvyzvupvupowvyzvzuzwvsrwv";
FunnyString fun = new FunnyString();
string isFunny = fun.funnyString(param);
Console.WriteLine($"this string {param} is {isFunny}");

param = "dkhc";
BiggerIsGreater bigger = new BiggerIsGreater();
string getBigger = bigger.biggerIsGreater(param);
Console.WriteLine($"this bigger string from {param} is {getBigger}");

List<int> cnt = CountingSort.countingSort(new List<int> {19,10,12,10,24,25,22});
Console.WriteLine(string.Join(" ", cnt));

List<int> cnt2 = CountingSort.countingSort2(new List<int> {19,10,12,10,24,25,22});
Console.WriteLine(string.Join(" ", cnt2));

string pangram = "We promptly judged antique ivory buckles for the prize";
string isPangram = Pangrams.pangrams(pangram);
Console.WriteLine($"{pangram} is {isPangram}");

CamelCase.DoCamelCase();

Gemstone.CountGemstones();

ManasaStone.CountManasaStone();

LadyBug.LadyBugIsHappy();

StrangeCounter.CountStrange();

HackerrankString.CheckHackerrankString();

Main main = new Main();
main.SubscribeAll();

PlusMinus.CountPlusMinus();

MiniMaxSum.CountMiniMax();

TimeConversion.TestTimeConversion();

InsertionSort.Test();

StrongPassword.Run();

TwoChars.Run();

InsertionSort.RunInvariant();

MissingNumbers.Run();

BalanceSum.Run();

IceCreamParlor.Run();

JimOrder.Run();

MaxToys.Run();

TwoArrays.Run();

MaksXOR.Run();

FlipBits.Run();

PriyankaToys.Run();

SherlockNumbers.Run();

ClosestNumbers.Run();

BeautifulPair.Run();

MakingAnagram.Run();

GameOfThrone.Run();

LargestPermutation.Run();

// SubstactDatetime.Run();

InsertionSort.RunInsertionSort2();

MakingAnagram.RunAnagram();

StringConstruction.Run();

TwoStrings.Run();

PalindromeIndex.Run();

SumXOR.Run();

AlternateChars.Run();

SeparateNumbers.Run();

BeautifulBinaryStrings.Run();