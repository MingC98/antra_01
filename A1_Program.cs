// See https://aka.ms/new-console-template for more information
using System;

/*
 * Uncomment to test
 * 1.
string color;
string cord;
Console.WriteLine("What's your favorite color?");
color = Console.ReadLine();
Console.WriteLine("Cat or Dog?");
cord = Console.ReadLine();
Console.WriteLine("You should get a " + color + " " + cord);

2.
string c;
Console.WriteLine("Enter number of centuries");
int centuries = int.Parse(Console.ReadLine());
int years = 100 * centuries;
int days = 36524 * centuries;
long hours = 876576 * centuries;
long minutes = 52594560 * centuries;
long seconds = 3155673600 * centuries;
long milliseconds = 3155673600000 * centuries;
long microseconds = milliseconds * 1000;
long nanoseconds = microseconds * 1000;
Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = 3155673600000 {milliseconds} = {microseconds} microseconds = {nanoseconds} nanoseconds");

1.
int correctNumber = new Random().Next(3) + 1;
Console.WriteLine("Guess a number 1-3 (int)");
int guessedNumber = int.Parse(Console.ReadLine());
if (guessedNumber > 3 | guessedNumber < 1)
{
    Console.WriteLine("Out of range");
}
else if (guessedNumber < correctNumber)
{
    Console.WriteLine("Guessed number is smaller than correct number");
} else if (guessedNumber > correctNumber)
{
    Console.WriteLine("Guessed number is greater than correct number");
}
else
{
    Console.WriteLine("Correct");
}

2.

int height = 5;
for (int i = 1; i <= height; i++)
{
    int space = height - i;
    for (int j = 0; j < space; j++)
    {
        Console.Write(" ");
    }
    int star = 1+(i-1)*2;
    for (int s = 0;  s < star; s++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

3. Same as Q1

4.
DateTime current = DateTime.Now;
DateTime birthday = new DateTime(2015, 12, 25);
int num_days = (current - birthday).Days;
Console.WriteLine("This person is "+num_days +" days old now born in "+ birthday);

5.
DateTime current = DateTime.Now;
int hr = current.Hour;
if (6 < hr & hr <= 12)
{
    Console.WriteLine("Good Morning");
}
if (12 < hr & hr <= 18)
{
    Console.WriteLine("Good Afternoon");
}
if (18 < hr & hr <= 24)
{
    Console.WriteLine("Good Evening");
}
if (24 < hr & hr <= 6)
{
    Console.WriteLine("Good Night");
}

6.
int max = 4;
int goal = 24;
for (int i = 1; i <= max; i++)
{
    for (int j = 0; j <= goal; j += i)
    {
        Console.Write(j);
        if (j != goal)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine();
}
*/