// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
public static class a3_1
{
    static int[] GenerateNumbers(int size)
    {
        int[] result = new int[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = i;
        }
        return result;
    }
    static void PrintNumbers(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
    static void Reverse(int[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length - i - 1];
            array[array.Length - i - 1] = temp;
        }
    }
    static void Main(string[] args)
    {
        int[] numbers = GenerateNumbers(6);
        Reverse(numbers);
        PrintNumbers(numbers);
    }
}

public class a3_2
{
    static int Fibonacci(int number)
    {
        if (number <= 2)
        {
            return 1;
        }
        else
        {
            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Fibonacci(8));
    }
}
*/
public abstract class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public abstract void PerformWork();
}
public class Student : Person
{
    public string[] classes { get; set; }
    public char[] grades { get; set; }
    public int gpa;
    public override void PerformWork()
    {
        Console.WriteLine("Study");
    }
    public int countGpa(char[] letters)
    {
        int grade = 0;
        foreach (char letter in letters)
        {
            switch (letter)
            {
                case 'A':
                    grade += 4;
                    break;
                case 'B':
                    grade += 3;
                    break;
                case 'C':
                    grade += 2;
                    break;
                case 'D':
                    grade += 1;
                    break;
            }
        }
        return grade / letters.Length;
    }
    public class Instructor
    {
        public int salary { get; set; }
        public int year_exp { get; set; }
        public Department Department { get; set; }
    }
    public class Course
    {
        public string[] enrolled_student { get; set; }
    }
    public class Department
    {
        public Instructor head { get; set; }
        public int budget { get; set; }
        public Course[] list_of_courses { get; set; }
    }
}

public class Color
{
    public byte red { get; set; }
    public byte green { get; set; }
    public byte blue { get; set; }
    public byte alpha { get; set; }
    public Color(byte red, byte green, byte blue, byte alpha = 0)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
        this.alpha = alpha;
    }
    public byte grayscale()
    {
        return (byte)((red * 255 + green * 255 + blue * 255) / 3);
    }
}
public class Ball
{
    public byte size { get; set; }
    public Color color { get; set; }
    public int count { get; set; }
    public Ball(byte size, Color color, int count = 0)
    {
        this.size = size;
        this.color = color;
        this.count = count;
    }

    public void Pop()
    {
        size = 0;
    }
    public void Throw()
    {
        if(size != 0)
        {
            count++;
        }
    }
    public void time_throw()
    {
        Console.WriteLine("Count: " + count);
    }
    static void Main(string[] args)
    {
        Color color = new Color(255, 0, 0);
        Ball my_ball = new Ball(1,color,0);
        for (int i=0; i<5; i++)
        {
            my_ball.Throw();
        }
        my_ball.Pop();
        my_ball.size = 2;
        for (int i = 0; i < 5; i++)
        {
            my_ball.Throw();
        }
        my_ball.time_throw();
    }
}