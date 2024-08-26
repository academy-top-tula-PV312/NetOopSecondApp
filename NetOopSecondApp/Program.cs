using NetOopSecondApp;

var user1 = new { Name = "Donny", Age = 25, Address = "Moscow" };
var user2 = new { Name = "Sammy", Address = "Tula", Age = 38, };
var user3 = new { Name = "Jimmy", Age = 29 };

//Console.WriteLine($"{user1.Name} {user1.Age} {user1.Address}");

Console.WriteLine(user1.GetType());
Console.WriteLine(user2.GetType());
Console.WriteLine(user3.GetType());

Employee employee = new Employee() { Name = "Kenny", Age = 42 };
var anonim = new {employee.Name, employee.Age};

Console.WriteLine(anonim.Name);

var users = new[]
{
    new{Name = "Tom"},
    new{Name = "Sam"},
    new{Name = "Joe"},
};

foreach(var u in users)
    Console.WriteLine(u.Name);

