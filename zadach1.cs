//Напишите программу,которая принимает на вход принимает два числа и выдает ,какое число больше ,какое меньше.

//a = 5  b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("введите первое число: ");
int a=int.Parse(Console.ReadLine()!);

Console.Write("введите второе число: ");
int b=int.Parse(Console.ReadLine()!);

if (a==b)
{
    Console.WriteLine($"введите неравные числа!!!");
}
else
{
    if (a>b)
  {
    Console.WriteLine($"большее число{a}");
    Console.WriteLine($"меньшее число{b}");
  }
  else
  {
    Console.WriteLine($"большее число{b}");
    Console.WriteLine($"меньшее число{a}");
  }
}