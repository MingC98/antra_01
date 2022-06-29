// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
/*
1.
int[] array1 = { 1, 2, 3, 4, 5, 6,7,8,9,10};
int[] array2 = new int[10];
for (int i = 0; i < array1.Length; i++)
{
    array2[i] = array1[i];
    Console.WriteLine("Original array element " + array1[i]);
    Console.WriteLine("Copied array element" + array2[i]);
}

2.
string[] m_array = new string[100];
int m_index = 0;
while (1 == 1)
{
    Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
    string response = Console.ReadLine();
    if (response[0] == '+')
    {
        response.Remove(0);
        m_array[m_index] = response;
        m_index++;
    }
    else if (response[0] == '-')
    {
        if (response[1] == '-')
        {
            m_array = new string[100];
        }
        response.Remove(0);
        m_array.RemoveAt(m_array.IndexOf(response));
        m_index--;
    }
}

3.
static int[] FindPrimesInRange(startNum, endNum)
{
    int cnt = 0;
    int[] result = new int[100];
    int m_index = 0;
    for (int i = startNum; i < endNum; i++)
    {
        for (int j = i; j < endNum; j++)
        {
            if (i % j == 0)
            {
                cnt++;
            }
        }
        if (cnt == 2)
        {
            result[m_index] = i;
            m_index++;
        }
        cnt = 0;
    }
    return result;
}

4.
static int[] rotateArrays(int[] array1, int[] array2)
{
    int[] rotated1 = new int[array1.length()];
    int[] rotated2 = new int[array2.length()];
    for (int i = 0; i < array1.length(); i++)
    {
        rotated1[(i + 3) % array1.length()] = array1[i];
        rotated2[(i + 3) % array2.length()] = array2[i];
    }
    int[]result = new int[array1.length()];
    for (int i = 0; i < array1.length(); i++)
    {
        result[i] = rotated1[i] + rotated2[i];
    }
    return result;
}

5.
static void printlongest(int[] m_array)
{
    int cur = 1;
    int max = m_array[0];
    int longest = 1;
    for (int i = 0; i < m_array.MaxLength();i++)
    {
        if (m_array[i] == m_array[i - 1])
        {
            cur++;
            if (cur > longest)
            {
                longest = cur;
                max = m_array[i];
            }
        }
    }
    for (int i = 0; i<max; i++)
    {
        Console.Write(max + " ");
    }
}

7.
static void findmost(int[] m_array)
{
    int max = m_array[0];
    int longest = 1;
    int cur = 1;
    for (int i = 0; i < m_array.MaxLength(); i++)
    {
        for (int j = 0; j < m_array.Maxlength(); j++)
        {
            if (m_array[i] = m_array[j])
            {
                cur++;
                if (cur > longest)
                {
                    longest = cur;
                    nax = m_array[i];
                }
            }
        }
    }
    Console.WriteLine("Most frequent is " + max + " " + longest + "times");
}

1.
static void ReverseString(string stringInput)
{
    string reversestring = "";
    int length = stringInput.Length;
    while (length >= 0)
    {
        reversestring = reversestring + stringInput[length];
        length--;
    }
    Console.WriteLine(reversestring);
}

2.
static void ReverseSentence(string stringInput)
{
    string reversestring = "";
    int length = stringInput.Length;
    while (length >= 0)
    {
        reversestring = reversestring + stringInput[length];
        length--;
    }
    Console.WriteLine(reversestring);
}

3.
static void printpalin(string stringInput)
{
    string[] subs = stringInput.Split(' ');
    foreach(string str in subs)
    {
        if(str = ReverseString(str))
        {
            Console.WriteLine(str);
        }
    }
}

4.
NO idea how to do this for now, I assume use regex but we haven't covered it in c#
Maybe split with \ and delete extra \ but doesn't feel right
 */

