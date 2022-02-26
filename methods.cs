using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 메서드
// 간단히 요약하자면, 메서드는 곧 코드의 한 블록이라고 생각하는 것이 편하다.
// 다만, 언제든지 호출하여 재사용할 수 있다.
// 우리의 Main 메서드는 매우 특별한 존재이다.
// 프로그램이 실행될 때 작동하는 메서드이기 때문,
class Program {
  public static void Main (string[] args) {
    string ipt = Console.ReadLine();
    HelloToUser(ipt);
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Added = " + Add(num1, num2));
    
  }

  // 메서드를 생성해보자 - 사실 함수와 별 다른 것이 없다

  static void HelloToUser(string name){ // 리턴값 이름() 변수
    Console.WriteLine("Hello, "+ name + '!');
  }

  static int Add(int n1, int n2){
    return n1 + n2;
  }
}