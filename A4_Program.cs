// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Stack<T>
{
    public static T[] m_stack = new T[10];
    public static int top = -1;
    public static int Count()
    {
        return top;
    }
    public static T Pop()
    {
        if (top < 0)
        {
            Console.WriteLine("Stack underflow");
            return default;
        }
        return m_stack[top--];
        
    }
    public static void Push(T m_ele)
    {
        if(top < m_stack.Length-1)
        {
            top++;
            m_stack[top] = m_ele;
        }
        else
        {
            Console.WriteLine("Stack overflow");
        }
    }
}

public static class MyList<T>
{
    public static T[] m_list = new T[0];
    public static void Add(T element)
    {
        m_list = new T[m_list.Length+1];
        m_list[m_list.Length-1] = element;
    }
    public static T Remove(int index)
    {
        T removed = m_list[index];
        T[] new_list = new T[m_list.Length];
        int j = 0;
        for (int i = 0; i < m_list.Length; i++)
        {
            if(i != index)
            {
                new_list[j] = m_list[i];
                j++;
            }
        }
        m_list = new_list;
        return removed;
    }
    public static bool Contains(T element)
    {
        
        foreach (T item in m_list)
        {
            if (item.Equals(element))
            {
                return true;
            }
        }
        return false;
    }
    public static void clear()
    {
        m_list = new T[0];
    }
    public static void InsertAt(T element,int index)
    {
        T[] new_list = new T[m_list.Length + 1];
        int j = 0;
        for (int i = 0; i < m_list.Length; i++)
        {
            if(i == index)
            {
                j++;
            }
            new_list[j] = m_list[i];
            j++;
        }
        new_list[index] = element;
        m_list = new_list;
    }
    public static void DeleteAt(int index)
    {
        T[] new_list = new T[m_list.Length];
        int j = 0;
        for (int i = 0; i < m_list.Length; i++)
        {
            if (i != index)
            {
                new_list[j] = m_list[i];
                j++;
            }
        }
        m_list = new_list;
    }
    public static T Find(int index)
    {
        return m_list[index];
    }
}