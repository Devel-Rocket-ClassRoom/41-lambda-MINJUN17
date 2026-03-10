using System;


////1
//Func<int> getNumber = () => 1234;
//Func<int, int> multiply = x => x * x;
//Func<int, int, int> add = (x, y) => x + y;

//Console.WriteLine(getNumber());
//Console.WriteLine(multiply(3));
//Console.WriteLine(add(3, 5));

////2

//Action hello = () => Console.WriteLine("안녕하세요!");
//hello();
//Action<string> hello2 = s => Console.WriteLine(s);
//hello2("Hello, Lambda!");
//Action<string, int> repeat = (msg, count) =>
//{
//    for (int i = 0; i < count; i++)
//    {
//        Console.WriteLine(msg);
//    }
//};
//repeat("반복!", 3);


//3
Func<int, int> func = delegate (int x) { return x * x; };
Console.WriteLine(func(2));
Func<int, int> func2 = x => x * x;
Console.WriteLine(func2(2));