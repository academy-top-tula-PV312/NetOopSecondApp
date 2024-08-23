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
}
