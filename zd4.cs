Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine())!;
int depo = 1;
while (depo <= number)
{
if (depo%2 == 0)
{
Console.Write ($"{depo} | ");
}
depo++;
}