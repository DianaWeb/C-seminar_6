/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5-> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */
System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

PrintFibToN(N);

void PrintFibToN(int n)
{
	int a = 0;
	System.Console.Write(a + " ");
	int b = 1;
	System.Console.Write(b + " ");
	for (int i = 0; i < n - 2; i++)
	{
		int c = a + b;
		System.Console.Write(c + " ");
		a = b;
		b = c;
	}
}
