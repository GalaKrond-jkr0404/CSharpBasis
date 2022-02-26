using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program {
  public static void Main (string[] args) {

    int [,] numGrid = {{1,2,3}, {4,5,6}};

    try{
    int x = 0;
    int y = 3;
    Console.WriteLine(y/x);
  }
  catch(Exception e){
    Console.WriteLine(e.Message);
  }
}

  
  
}