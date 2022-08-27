/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */
System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

GetBinaryView(n);

void GetBinaryView(int number)
{
	if (number <= 0) return;
	GetBinaryView(number / 2);
	System.Console.Write(number % 2);
}


/* int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
	array[i] = n % 2;
	n = n / 2;
}
Console.WriteLine($"Исходный массив: {string.Join(", ", array)}");

for (int j = 0; j < array.Length / 2; j++)
{
	int temp = array[j];
	array[j] = array[array.Length - 1 - j];
	array[array.Length - 1 - j] = temp;
}
System.Console.WriteLine($"Двоичное число: {string.Join(", ", array)}"); */



