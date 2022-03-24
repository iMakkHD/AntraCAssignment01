// See https://aka.ms/new-console-template for more information

//1.
Console.WriteLine(sizeof(sbyte));
Console.WriteLine(sizeof(byte));
Console.WriteLine(sizeof(short));
Console.WriteLine(sizeof(ushort));
Console.WriteLine(sizeof(int));
Console.WriteLine(sizeof(uint));
Console.WriteLine(sizeof(long));
Console.WriteLine(sizeof(ulong));
Console.WriteLine(sizeof(float));
Console.WriteLine(sizeof(double));
Console.WriteLine(sizeof(decimal));

//2.
Console.WriteLine("Enter number of centuries");
int c = int.Parse(Console.ReadLine());
int centuries = c;
int years = centuries * 100;
double days = years * 365.24;
double hours = 24 * days;
ulong minutes = (ulong)(hours * 60);
ulong seconds = 60 * minutes;
ulong ms = 1000 * seconds;
ulong micro = 1000 * ms;
ulong nano = 1000 * micro;
Console.WriteLine(centuries + " centuries = " + years + " years = " + days + " days = " + hours + " hours = " + minutes + " minutes = " + seconds + " seconds = " + ms + " milliseconds = " + micro + " microseconds = " + nano + " nanoseconds");

/*Test your knowledge
1. What happens when you divide an int variable by 0
int num = 2;
Console.WriteLine(num/0);
Result: System.DivideByZeroException: 'Attempted to divide by zero.'
 
2. What happens when you divide a double variable by 0?
double num = 2.0;
Console.WriteLine("start");
Console.WriteLine(num / 0);
Console.WriteLine("Done");

Result: infinity

3. What happens when you overflow an int variable, that is, 
set it to a value beyond its range?

Answer: An error will be given saying that the number is not in the 32 bit representation. Must be cast to another larger type.

4. What is the difference between x = y++; and x = ++y;?

Answer: x= y++ means that y is assigned to the value of x then incremented after. x = ++y means y is incremented then assigned to the value of x.

5. What is the difference between break,continue, 
and return when used inside a loop statement?

Answer: break means exit the statement in the loop. Return ends the method immediately by returning the value. Continue forces the next iteration of the loop.

6. What are the three parts of a for statement and which of them are required? 

Answer: initialization, condition, iterator. All can be neglected. However, this will create an infinite loop

7.What is the difference between the = and == operators? 

Answer: = is for assignment while == is to check for equality

8.Does the following statement compile? for ( ; true; ) ; 
yes but it is infinite

9.What does the underscore _ represent in a switch expression? 
it means the default keyword can match anything to be executed if reached.

10.What interface must an object implement to be enumerated over by using the foreach statement?
IEnumerator

*/

//Chapter03 Exercise03
int max = 100;
for (int i = 0; i < max; i++)
{
    if (i % 3 == 0 & i % 5 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("fizz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

/*
int max1 = 500; 
for (byte i = 0; i < max1; i++) { 
    WriteLine(i); 
}

Answer: Error is given because it must be Console.WriteLine(i);
*/

int correct = new Random().Next(3) + 1;
Console.WriteLine("Guess a number between 1 and 3");
int guess = int.Parse(Console.ReadLine());
if (guess == correct)
{
    Console.WriteLine("Correct");
}
else if(guess < correct)
{
    Console.WriteLine("Too low");
}
else
{
    Console.WriteLine("Too high");
}

//Print-a-Pyramid
for (int i = 0; i < 5; i++)
{
    for (int j = 1; j <= 5 - i; j++)
    {
        Console.Write(" ");
    }
    for (int j = 1; j <= 2 * i - 1; j++) {
        Console.Write("*");
    }
    Console.Write("\n");
}

DateTime today = DateTime.Today;
DateTime birthdate = Convert.ToDateTime("10/29/1999");
//Console.WriteLine(today.ToString());
// Calculate the age.
var age = today.Year - birthdate.Year;

//leap year
if (birthdate.Date > today.AddYears(--age))
{
    age--;
}
Console.WriteLine(age.ToString());

DateTime time = DateTime.Now;

if(time.Hour <= 8)
{
    Console.WriteLine("Good Morning");
}
if (time.Hour <= 16)
{
    Console.WriteLine("Good Afternoon");
}
if (time.Hour <= 21)
{
    Console.WriteLine("Good Evening");
}
else
{
    Console.WriteLine("Good Night");
}

Console.WriteLine("\n");

for(int i = 1; i < 5; i++)
{
    for(int j = 0; j <= 24; j+=i)
    {
        Console.Write(j + ", ");
    }
    Console.WriteLine("\n");
}
