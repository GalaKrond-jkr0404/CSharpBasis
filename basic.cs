using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program {
  public static void Main (string[] args) {

    // 기본 입출력
    Console.WriteLine("Hello World");

    Console.ReadLine(); 

    // 변수
    string name = "Gala";
    int age = 17;

    Console.Write("no newline");

    Console.WriteLine("His Name is " + name + "and his age is " + age);
    Console.WriteLine(" So \n What");
    Console.WriteLine("\"");
    

    char oneword = 'c';
    double sosu = 1.3;
    int num = 3;
    string text = "asdf";
    bool isHappy = true;

    // 문자열 다루기
    Console.WriteLine(text.ToUpper());
    Console.WriteLine(text.Contains("f")); // bool
    Console.WriteLine(text[0]);
    Console.WriteLine(text.IndexOf("df")); // 시작위치 idx
    Console.WriteLine(text.Substring(0, 2)); // start, length

    // 수 관련은 Math 사용하기

    // 입력
    Console.Write("x = ");
    string s = Console.ReadLine();

    // 배열
    int []ga = {1,2,3,4,5};
    Console.WriteLine(ga[1]);

    string named[] = new string[5];
    
    
    
  }
}