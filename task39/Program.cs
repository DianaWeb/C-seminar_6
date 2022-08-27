/* Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */
// Метод возвращает массив на size элементов
const int ARRAY_SIZE = 6;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;
int[] arr = FillArrayWithRandomNumbers(ARRAY_SIZE, LEFT_RANGE, RIGHT_RANGE);
System.Console.WriteLine($"Исходный массив: {string.Join(", ", arr)}");

ReverseArray(arr);
System.Console.WriteLine($"Перевернутый массив : {string.Join(", ", arr)}");

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
	int[] array = new int[size];
	Random random = new Random();

	for (int i = 0; i < size; i++)
	{
		array[i] = random.Next(leftRange, rightRange + 1);
	}
	return array;
}

void ReverseArray(int[] arr)
{
	for (int i = 0; i < arr.Length / 2; i++)
	{
		int temp = 0;
		temp = arr[i];
		arr[i] = arr[arr.Length - 1 - i];
		arr[arr.Length - i - 1] = temp;
	}
}
