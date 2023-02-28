// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите 3 числа:");
int NumA = Convert.ToInt32(Console.ReadLine());
int NumB = Convert.ToInt32(Console.ReadLine());
int NumC = Convert.ToInt32(Console.ReadLine());

int max = NumA;
Console.WriteLine($"{NumA};{NumB};{NumC} -> max={NumA}");
if (NumB > max)
{
    max = NumB;
}
else
{
    Console.WriteLine($"{NumA};{NumB};{NumC} -> max={NumB}");
}
if (NumC > max)
{
    max = NumC;
}
else
{
    Console.WriteLine($"{NumA};{NumB};{NumC} -> max={NumC}");
}