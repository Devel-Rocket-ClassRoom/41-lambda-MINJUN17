using System;

Func<string, string> toUpper = text => text.ToUpper();
Func<string, string> mask = text => $"{text[0]}{text[1]}***";
Func<string, string> Greet = text => $"안녕하세요, {text}님!";

Console.Write($"[대문자 변환] hello world -> ");
ApplyAndPrint("hello world", toUpper);

Console.Write($"[마스킹 처리] SecretCode -> ");
ApplyAndPrint("SecretCode", mask);

Console.Write($"[인사말 생성] 민수 -> ");
ApplyAndPrint("민수", Greet);
void ApplyAndPrint(string input, Func<string, string> formatter)
{
    Console.WriteLine(formatter(input));
}
