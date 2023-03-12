/// Задача № 8.    Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. 
/*("Введите трехзначное число: ");

int i = 1;
bool not = true;
Console.WriteLine($"{Num} ->");
while (i <= Num)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}

if (not)
{
    Console.WriteLine("Нет чётных чисел!");
}*/


/*Console.Clear();
int num = ReadNumber("Ввведите номер четверти");
PrintResult(num);
static void PrintResult(int num)
{
    if(num == 1 )
    Console.WriteLine("X > 0  и  Y > 0"); 
    else if (num == 2)
    Console.WriteLine ("X > 0  и  Y < 0");
    else if (num == 3)
    Console.WriteLine ("X < 0  и  Y < 0");
    else if (num == 4)
    Console.WriteLine ("X > 0  и  Y < 0");
    else
    Console.WriteLine ("Ошибка ввода");
}
static int ReadNumber(string message)
{
    int n = 0;
    while (true)
    {
        try
        {
    Console.WriteLine(message);
     n = int.Parse(Console.ReadLine()?? "");
     break;
        }
        catch(Exception exc)
        {
            Console.WriteLine("Ошибка ввода");
        }
    }
     return n;
} */

/*Console.Clear();
int x1 = InputNumber("Введите х1: "); 
int y1 = InputNumber("Введите у1: "); 
int x2 = InputNumber("Введите х2: "); 
int y2 = InputNumber("Введите у2: "); 

Console.WriteLine($"Расстояние между точками ({x1}, {y1}) и ({x2}, {y2}) {CalculateDistance(x1, y1, x2, y2)}");


static int InputNumber(string message)
{
    try
    {
        Console.Write(message);
        return (int.Parse(Console.ReadLine() ?? "")); 
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0; 
    }
}

static double CalculateDistance(int x1, int y1, int x2, int y2)
{
   return Math.Sqrt(Math.Pow(x2-x1, 2)+(Math.Pow(y2-y1, 2)));
}
*/
int num = new Random ().Next(100, 1000);
int a1 = num / 100;
int a2 = num % 10;
int a3 = num / 1;
Console.Write("Введите трехзначное число: ");

