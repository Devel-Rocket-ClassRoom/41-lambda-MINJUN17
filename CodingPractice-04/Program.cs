using System;
using System.Collections.Generic;


////1
//Action[] actions = new Action[3];

//for(int i = 0; i < actions.Length; i++)
//{
//    actions[i] = () => Console.WriteLine(i);
//}
//foreach(var action in actions)
//{
//    action();
//}

////2
//Action[] actions = new Action[3];

//for (int i = 0; i < actions.Length; i++)
//{
//    int loopVar = i;
//    actions[i] = () => Console.WriteLine(loopVar);
//}
//foreach (var action in actions)
//{
//    action();
//}

string[] names = { "김철수", "이영희", "박민수", "최지연" };
Array.Sort(names, (a, b) => a.Length.CompareTo(b.Length));
Console.WriteLine("이름순 정렬: ");
foreach(string name in names)
{
    Console.WriteLine(name);
}

Array.Sort(names, (a, b) => b.CompareTo(a));
Console.WriteLine("이름 역순 정렬: ");
foreach (string name in names)
{
    Console.WriteLine(name);
}