// See https://aka.ms/new-console-template for more information

//Understanding Data Types

// Question 1 

/*
 * What type would you choose for the following “numbers”? 
 * A person’s telephone number - String
 * A person’s heightA person’s age - int
 * A person’s gender (Male, Female, Prefer Not To Answer) - String
 * A person’s salary - decimal
 * A book’s ISBN - String
 * A book’s price - decimal
 * A book’s shipping weight - float
 * A country’s population - long
 * The number of stars in the universe - ulong
 * The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business) - int
 */

// Question 2

/*
 * What are the difference between value type and reference type variables? What is boxing and unboxing?
 * A value type directly holds its vaue
 * A reference type holds the memory address for the value
 * Boxing is when a value of any type is converted to an object and stored in the heap
 * unboxing is the conversion of the stored object into another type
 */

// Question 3

/*
 * What is meant by the terms managed resource and unmanaged resource in .NET?
 * The difference between the two is whether the garbage collector manages it.
 * Managed resources are controlled by the garbage collector while unmanaged resources require
 * the user to control memory allocation for them
 */

// Question 4

/*
 * Whats the purpose of Garbage Collector in .NET?
 * The garbage collector is a manager that frees up resources and memory
 */

// Question 5

Console.WriteLine("Type in your favorite color: ");
string color = Console.ReadLine();
Console.WriteLine("Type in your astrology sign: ");
string sign = Console.ReadLine();
Console.WriteLine("Type in your address number: ");
string num = Console.ReadLine();
Console.WriteLine(color + sign + num);

