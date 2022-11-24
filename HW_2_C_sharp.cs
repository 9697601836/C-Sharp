using System;

namespace MySecondSharpProgram
{
class Program {
  static void Main() {
// 1
      string []sotr={"Быков","Иванов","Петров","Быков","Борисов","Сергеев","Быков"};
int k=0; //счетчик однофамильцев
foreach(string s in sotr)
{
if (s=="Быков")
{
k++;
continue;
}
Console.WriteLine (s);
}
Console.WriteLine ("Быков");
Console.WriteLine("У вас {0} Быкова",k);
// 2
int []money={1000,100,2000,500,1999,100,7}; // меньше 1000 не берём!
    int cash = 0;
        for(int i=0; i<money.Length; i++)
        {
            if (cash>=4000)
            {
            break;
            }
            if (money[i]<1000)
            {
            continue;
            }
        cash+=money[i];
        }  
Console.WriteLine("Итого: "+ cash); 
Console.ReadKey();
    }
}
}