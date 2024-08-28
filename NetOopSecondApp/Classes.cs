using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetOopSecondApp
{
    class Employee<T>
    {
        public T Id { get; set; }

        public string Name { set; get; }
        public int Age { set; get; }

        public Employee(T id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"name: {Name}, Age: {Age}, Id: {Id}";
        }
    }

    class Passport
    {
        public string Series { set; get; }
        public string Number { set; get; }

        public override string ToString()
        {
            return $"Series: {Series}, Number: {Number}";
        }
    }

    class Calculator
    {

        public static void Swap<T>(ref T a, ref T b)
        {
            (a, b) = (b, a);
            /*
                T temp = a;
                a = b;
                b = temp
            */
        }
    }

    class Message
    {
        public string Text { set; get; }
        public Message(string text)
        {
            Text = text;
        }
    }

    class EmailMessage : Message
    {
        public EmailMessage(string text) : base(text) { }
    }

    class SmsMessage : Message
    {
        public SmsMessage(string text) : base(text) { }
    }

    interface IMovable
    {

    }

    class Employee<T1, T2> where T2 : class
    {

    }

    class Person<T>
    {
        public T Id { get; set; }
        public string Name { set; get; }
    }

    class Client<T> : Person<T>
    {

    }

    class Admin : Person<int>
    {

    }

    class Memeber<T, K> : Person<T>
    {

    }

    class User<K> : Person<int>
    {

    }

    class FractionException : Exception
    {
        public int Value { get; }

        public FractionException()
            : base("incorrect value of denominator (is zero)"){}

        public FractionException(string message, int value)
            : base(message)
        {
            Value = value;
        }
    }

    class Fraction
    {
        public int Numerator { get; set; }

        int denominator;

        public int Denominator
        {
            set
            {
                if (value != 0)
                    Denominator = value;
                else
                    throw new FractionException();
            }
            get { return denominator; }
        }

        public Fraction(int numerator = 0, int denominator = 1)
        {
            Numerator = numerator;
            if (denominator != 0)
                this.denominator = denominator;
            else
                throw new DivideByZeroException();
        }

        // arithm operators
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new(a.Numerator * b.Denominator + a.Denominator * b.Numerator,
                        a.Denominator * b.Denominator);
        }
        public static Fraction operator +(Fraction a, int b)
        {
            return new(a.Numerator + a.Denominator * b, a.Denominator);
        }


        // bool operators
        public static bool operator <(Fraction a, Fraction b)
        {
            return a.Numerator * b.Denominator < a.Denominator * b.Numerator;
        }

        public static bool operator >(Fraction a, Fraction b)
        {
            return a.Numerator * b.Denominator > a.Denominator * b.Numerator;
        }

        // increment, decrement
        public static Fraction operator ++(Fraction a)
        {
            return new(a.Numerator + a.Denominator, a.Denominator);
        }

        public static bool operator true(Fraction a)
        {
            return a.Numerator != 0;
        }

        public static bool operator false(Fraction a)
        {
            return a.Numerator == 0;
        }

        // types
        public static implicit operator double(Fraction a)
        {
            return (double)a.Numerator / a.Denominator;
        }

        public static explicit operator Money(Fraction a)
        {
            int rub = a.Numerator / a.Denominator;
            int kop = (int)((double)a.Numerator / a.Denominator - rub * 100);
            return new Money(rub, kop);
        }
    }

    class Money
    {
        public int Rub { set; get; }
        public int Kop { set; get; }

        public Money(int rub = 0, int kop = 0)
        {
            Rub = rub;
            Kop = kop;
        }
    }

    class Employee
    {
        public string Name { set; get; }
        public int Age { set; get; }
        string address;
        string phone;
        string email;

        decimal salary;
        decimal bonus;

        public string this[string property]
        {
            get
            {
                switch (property)
                {
                    case "address": return address;
                    case "phone": return phone;
                    case "email": return email;
                    default: throw new Exception("Unknown property");
                }
            }
            set
            {
                switch (property)
                {
                    case "address": address = value; break;
                    case "phone": phone = value; break;
                    case "email": email = value; break;
                    default: throw new Exception("Unknown property");
                }
            }
        }

        public string this[int property]
        {
            get
            {
                switch (property)
                {
                    case 0: return address;
                    case 1: return phone;
                    case 2: return email;
                    default: throw new Exception("Unknown property");
                }
            }
            set
            {
                switch (property)
                {
                    case 0: address = value; break;
                    case 1: phone = value; break;
                    case 2: email = value; break;
                    default: throw new Exception("Unknown property");
                }
            }
        }
    }

    class Company
    {
        public Company()
        {
            employees = new Employee[10];
        }

        public int Count = 10;

        public string Title { set; get; }
        Employee[] employees;

        public Employee this[int index]
        {
            get { return employees[index]; }
            set { employees[index] = value; }
        }
    }

    class Matrix
    {
        int[,] matrix = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
        public int this[int row, int column]
        {
            get { return matrix[row, column]; }
            set { matrix[row, column] = value; }
        }
    }

    class Vector
    {
        int[] array = new int[10];
        
        //public int[] Array
        //{
        //    get { return array; }
        //    set { array = value; }
        //}

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }

    class Auto
    {
        public int Volume { set; get; } = 100;

        public void Start()
        {
            Console.WriteLine("Auto start move");
        }

        public void Stop()
        {
            Console.WriteLine("Auto finish move");
        }
    }

    static class AutoExtension
    {
        public static void Refilling(this Auto auto, int value)
        {
            auto.Volume += value;
        }
    }


    // extension methods
    public static class StringExtension
    {
        public static int CharCount(this string str, char ch)
        {
            int count = 0;
            foreach (var c in str)
                if (c == ch) count++;
            return count;
        }
    }

    // classic
    static class StringAdvased
    {
        public static int CharCount(string str, char ch)
        {
            int count = 0;
            foreach (var c in str)
                if (c == ch) count++;
            return count;
        }
    }
}
