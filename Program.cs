// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N. */

int[] GetSquareNumer(int numer)

{
  int[] squaresNumers = new int[numer];

  // Заполните массива результата
  for (int i = 1; i <= numer;i++)

  {
    squaresNumers[i - 1] = i * i;
  }
  
  return squaresNumers;
}
  Console.Write("input name: ");
  int num = int.Parse(Console.ReadLine());

  int[] result = GetSquareNumer(num);
  for (int i = 0; i < result.Length; i++) {

    Console.WriteLine(result[i]);
  }



