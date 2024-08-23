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
    }
}
