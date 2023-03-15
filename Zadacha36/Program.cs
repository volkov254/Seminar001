// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Введи длину массива: ");
int ElementNumbers = Convert.ToInt32(Console.ReadLine()); 
int randomNumber =  RandomNumbers(ElementNumbers, 1, 10);
Console.WriteLine($"  Сумма элементов, стоящих на нечётных позициях: {randomNumber}");

int RandomNumbers(int ElementNumbers, int min, int max)
  {
  int[] randomNumber = new int[ElementNumbers];
  int sumElements = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomNumber.Length; i++ ){
      randomNumber[i] = new Random().Next(min, max);

      Console.Write(randomNumber[i] + " ");

      if (i % 2 != 1)
      {
        sumElements = sumElements + randomNumber[i];
      }
    }
  return sumElements;
  }
