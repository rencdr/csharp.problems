/*1.Two Sum -Given an array of numbers, find the two numbers such that they add up to a specific target.
public int[] TwoSum(int[] nums, int target) {
    Dictionary<int, int> numIndices = new Dictionary<int, int>();
    
    for (int i = 0; i < nums.Length; i++) {
        int complement = target - nums[i];
        if (numIndices.ContainsKey(complement)) {
            return new int[] { numIndices[complement], i };
        }
        numIndices[nums[i]] = i;
    }
    
    return new int[] { -1, -1 }; // Eğer çözüm bulunamazsa
}
*/
/*2.Reverse Integer-Reverse an integer. For example, reverse 123 to get 321.
public int Reverse(int x) {
    int sign = x >= 0 ? 1 : -1;
    x = Math.Abs(x);
    
    long reversedX = 0;
    while (x > 0) {
        reversedX = reversedX * 10 + x % 10;
        x /= 10;
    }
    
    reversedX *= sign;
    return (reversedX >= int.MinValue && reversedX <= int.MaxValue) ? (int)reversedX : 0;
}
*/
/*3.Palindrome Number-Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.
public bool IsPalindrome(int x) {
    if (x < 0) {
        return false;
    }
    string strX = x.ToString();
    int left = 0, right = strX.Length - 1;
    
    while (left < right) {
        if (strX[left] != strX[right]) {
            return false;
        }
        left++;
        right--;
    }
    
    return true;
}
*/
/*4.Roman to Integer-Convert a Roman numeral to an integer. Input is guaranteed to be within the range from 1 to 3999.
public int RomanToInt(string s) {
    Dictionary<char, int> romanDict = new Dictionary<char, int> {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };
    
    int result = 0;
    int prevValue = 0;
    
    for (int i = s.Length - 1; i >= 0; i--) {
        int value = romanDict[s[i]];
        result += (value >= prevValue) ? value : -value;
        prevValue = value;
    }
    
    return result;
}
*/
/*5.Create a method that takes as input a name, city, and state to welcome a person. Note that name will be an array consisting of one or more values that should be joined together with one space between each, and the length of the name array in test cases will vary.
This example will return the string Hello, John Smith! Welcome to Phoenix, Arizona!

public class Kata
{
    public static string SayHello(string[] name, string city, string state)
    {
        string hello = "Hello,";
        string welcome = "Welcome to";
        string hw = $"{hello} {string.Join(" ", name)}! {welcome} {city}, {state}!";
        return hw;
    }
}
*/
/*6.Given an array of integers.
Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers. 0 is neither positive nor negative.
If the input is an empty array or is null, return an empty array.

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        if(input == null || !input.Any())
        {
            return new int[] {};
        }
        
        int countPositives = input.Count(n => n > 0);
        int sumNegatives = input.Where(n => n < 0).Sum();

        return new int[] { countPositives, sumNegatives };
    }
}
*/
/*7.We need a function that can transform a number (integer) into a string.
public class Kata
{
  public static string NumberToString(int num)
  {
    string strnum = num.ToString();
    return strnum; 
  }
}
*/
/*
8.Write a function that takes an array of words and smashes them together into a sentence and returns the sentence. 
You can ignore any need to sanitize words or add punctuation, 
but you should add spaces between each word. 
Be careful, there shouldn't be a space at the beginning or the end of the sentence!

public class Kata
{
    public static string Smash(string[] words)
    {
        string result = string.Join(" ", words);
        result = result.Trim();
        return result;
    }
}
*/
/*
9.Complete the function so that it finds the average of the three scores passed to it and returns the letter value associated with that grade.

using System;

public class Kata
{
    public static char GetGrade(int s1, int s2, int s3)
    {
        int score = (s1 + s2 + s3) / 3;

        if (score >= 90 && score <= 100)
        {
            return 'A';
        }
        else if (score >= 80 && score < 90)
        {
            return 'B';
        }
        else if (score >= 70 && score < 80)
        {
            return 'C';
        }
        else if (score >= 60 && score < 70)
        {
            return 'D';
        }
        else
        {
            
            return 'F';
        }
    }
}
*/
/*
10.Complete the function that takes two integers (a, b, where a < b) and return an array of all integers 
between the input parameters, including them.

public class Kata
{
    public static int[] Between(int a, int b)
    {
        if (a < b)
        {
            int[] result = new int[b - a + 1];
            
            for (int i = 0; i <= b - a; i++)
            {
                result[i] = a + i;
            }

            return result;
        }
        else
        {
           
            return new int[0]; 
        }
    }
}
*/
/*
11.In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.

using System.Collections;
using System.Collections.Generic;

public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        List<int> integers = new List<int>();

        foreach (var item in listOfItems)
        {
            if (item is int)
            {
                integers.Add((int)item);
            }
        }

        return integers;
    }
}
*/
/*
12.Write a function named setAlarm/set_alarm/set-alarm/setalarm (depending on language) which receives two parameters. The first parameter, employed, is true whenever you are employed and the second parameter, vacation is true whenever you are on vacation.
The function should return true if you are employed and not on vacation (because these are the circumstances under which you need to set an alarm). It should return false otherwise

public class Kata {
  public static bool SetAlarm(bool employed, bool vacation) {
    if (employed == true && vacation== false){
      return true;
      
    }else{
      return false;
    }
  }
}
*/
/*
13.Write a function which calculates the average of the numbers in a given list.
using System;
using System.Linq;

class AverageSolution
{
    public static double FindAverage(double[] array)
    {
        if (array == null || array.Length == 0)
        {
            return 0;
        }

        return array.Average();
    }
}


*/
/*
14.Complete the function that accepts a string parameter, and reverses each word in the string. All spaces in the string should be retained.

using System;
using System.Linq;

public static class Kata
{
    public static string ReverseWords(string str)
    {
        string[] words = str.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            char[] charArray = words[i].ToCharArray();
            Array.Reverse(charArray);
            words[i] = new string(charArray);
        }

        string result = string.Join(" ", words);
        return result;
    }
}
*/