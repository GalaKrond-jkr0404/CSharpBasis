using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program {
  public static void Main (string[] args) {

    // 조건문, 딱히 바뀐 거 없이 && ||도 잘 써주면 된다.
    bool youSucks = true;
    
    if(youSucks){
      Console.WriteLine("You Sucks Bruh");
    }
    else{
      Console.WriteLine("You're Nice Guy Man");
    }

    int num = 2;
    if(num == 1){
      Console.ReadLine("1!");
    }
    else if(num == 2){
      Console.ReadLine("2!");
    }
  }

}