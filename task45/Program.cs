/* Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования */
int[] array = { 1, 2, 3, 4, 5 };
Console.WriteLine($"Исходный массив: {string.Join(", ", array)}");

int[] copyArray = CopyArray(array);
Console.WriteLine($"Новый массив: {string.Join(", ", copyArray)}");

int[] CopyArray(int[] sourceArray)
{
	int[] newArray = new int[sourceArray.Length];

	for (int i = 0; i < sourceArray.Length; i++)
	{
		newArray[i] = sourceArray[i];
	}
	return newArray;
}
