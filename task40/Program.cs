/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон. */
System.Console.WriteLine("Введите сторону А: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите сторону B: ");
int B = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите сторону C: ");
int C = Convert.ToInt32(Console.ReadLine());

bool res = IsTriangleExist(A, B, C);
if (res == true) Console.WriteLine("Может существовать треугольник.");
else Console.WriteLine("Такой треугольник существовать не может!");

bool IsTriangleExist(int A, int B, int C)
{
	bool isExist = false;
	if (A + B > C && A + C > B && B + C > A) isExist = true;
	// {
	// 	System.Console.WriteLine("Может существовать треугольник.");
	// }
	return isExist;
}

