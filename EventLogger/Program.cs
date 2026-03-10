using System;


var logger1 = CreateLogger("시스템");
logger1("서버를 시작합니다.");
logger1("초기화가 완료되었습니다.");
var logger2 = CreateLogger("네트워크");
logger2("클라이언트가 접속했습니다.");
logger1("요청을 처리합니다.");
logger2("데이터를 수신했습니다.");
logger2("클라이언트가 종료했습니다");



Action<string>CreateLogger(string category)
{
    int count = 1;
    return message => Console.WriteLine($"[{category} #{count++}] {message}");
}
