/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab1B 
*/
using System;
// Program Lab1B.cs 
// Demonstrate reading a string from the user. 
public class Lab1B
{
    // Reads a character string from the user and prints it. 
    public static void Main(String[] args)
    {
        String message;
        Console.Write("Enter a line of text: ");
        message = Console.ReadLine();
        Console.WriteLine("You wrote'" + message + "'");
    }
}