Console.Write ("Введите первое число:");
int numberA = int.Parse (Console.ReadLine() !);

Console.Write ("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine () !);

Console.Write ("Введите третье число:");
int numberC = int.Parse(Console.ReadLine () !);

int max = numberA;
if(max < numberB) max = numberB;
if(max < numberC) max = numberC;

Console.WriteLine($"Из введенных чисел {numberA}, {numberB}, {numberC} макисмальное {max}");