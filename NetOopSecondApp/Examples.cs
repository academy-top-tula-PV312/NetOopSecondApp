using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetOopSecondApp
{
    static class Examples
    {
        public static void GenericsBase()
        {
            //Employee bob = new(123, "Bobby", 26);
            //string id = (string)bob.Id;
            //Console.WriteLine(id);

            Employee<int> bob = new(123, "Bobby", 26);
            Employee<int> joe = new(567, "Joseph", 31);
            Employee<Passport> tom = new(new Passport()
            {
                Series = "XX-00",
                Number = "123456"
            },
                                         "Tommy", 41);

            var idBob = bob.Id;
            var idJoe = joe.Id;
            var idTom = tom.Id;

            Console.WriteLine($"{idBob} {idJoe} {idTom}");

            Calculator.Swap<Employee<int>>(ref bob, ref joe);

            Console.WriteLine(bob);
        }

        public static void GenericsWhere()
        {
            SendMessage<EmailMessage>(new("Hello world"));


            void SendMessage<T>(T message) where T : Message
            {
                Console.WriteLine(message.Text);
            }

        }

        public static void OverloadOperators()
        {
            /*
            +, -, *, /, %
            ++, --
            <, >, <=, >=, ==, !=
            &, |, ^, ~, <<, >>
            []
            (Type)
            */

            Fraction f = new(2, 3);

            double x = 1.5 + f;
            Console.WriteLine(x);

            Money m = new(3, 20);
            Money m2 = (Money)f;

            Employee bob = new() { Name = "Bobby", Age = 25 };
            Company yandex = new() { Title = "Yandex" };
            yandex[0] = bob;
            yandex[2] = new() { Name = "Sammy", Age = 31 };

            for (int i = 0; i < yandex.Count; i++)
                Console.WriteLine($"{yandex[i]?.Name}, {yandex[i]?.Age}");

            Vector vector = new();

            //vector.Array[0] = 0;
            vector[0] = 0;

            Employee tim = new() { Name = "Timmi", Age = 26 };
            tim["address"] = "Moscow";
            tim["phone"] = "+7 999 123-45-67";

        }

        public static void ExtensionsMethods()
        {
            string s = "Hello";
            Console.WriteLine(StringAdvased.CharCount(s, 'l'));
            Console.WriteLine(s.CharCount('l'));


            Auto auto = new();
            auto.Start();
            auto.Stop();
            auto.Refilling(20);
        }

        public static void PartialClass()
        {
            Window window = new();
            window.Open();
        }
    }
}
