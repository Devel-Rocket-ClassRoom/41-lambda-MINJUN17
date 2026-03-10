using System;


////1
//PrintMessage message = () => Console.WriteLine("안녕하세요");
//message();


//delegate void PrintMessage();

////2
//Transformer t = x => x * x;
//Console.WriteLine(t(3));
//Console.WriteLine(t(5));

//delegate int Transformer(int n);


////3
//IsLonger isLonger = (msg, len) => msg.Length > len;
//Console.WriteLine(isLonger("안녕하세요.", 5));
//Console.WriteLine(isLonger("반값습니다.", 10));


//delegate bool IsLonger(string s, int i);

////4
//Greeting greeting = () =>
//{
//    Console.WriteLine("안녕하세요");
//    Console.WriteLine("반갑습니다");
//};

//greeting();
//delegate void Greeting();

////5
//Calculator add = (x, y) =>
//{
//    int result = x + y;
//    Console.WriteLine($"{x} + {y} = {result}");
//    return result;
//};

//int sum = add(3, 5);
//Console.WriteLine($"합계: {sum}");
//delegate int Calculator(int x, int y);