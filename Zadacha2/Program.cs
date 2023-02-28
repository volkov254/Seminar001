////Решение задачи №2////
Console.Write("Введите первое число :");
string A = Console.ReadLine()??"";
int NumA = 0;
if (A !=null)
    NumA = int.Parse(A);
Console.Write("Введите второе число :");
   string B = Console.ReadLine()??"";
int NumB = 0;
if (B !=null)
    NumB = int.Parse(B);

if (NumA > NumB)
{
    Console.WriteLine($"a={NumA};b={NumB} -> max={NumA}");
}

else
{
    Console.WriteLine($"a={NumA};b={NumB} -> max={NumB}");
}