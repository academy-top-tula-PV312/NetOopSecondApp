using NetOopSecondApp;


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

