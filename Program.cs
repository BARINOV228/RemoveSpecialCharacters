using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(string[] args)
    {
        string input1 = "AA@%^&CC";
        string input2 = "Python";
        string input3 = "w3resource.com";

        string result1 = RemoveSpecialCharacters(input1);
        string result2 = RemoveSpecialCharacters(input2);
        string result3 = RemoveSpecialCharacters(input3);

        Console.WriteLine($"Result 1: {result1}");
        Console.WriteLine($"Result 2: {result2}");
        Console.WriteLine($"Result 3: {result3}");
    }

    public static string RemoveSpecialCharacters(string input)
    {
        string pattern = @"[^a-zA-Z0-9]";
        return Regex.Replace(input, pattern, "");
    }
}