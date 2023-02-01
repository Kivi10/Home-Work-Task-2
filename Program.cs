// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.Write("Past the number A -> ");
int number_A = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Past the number B -> ");
int number_B = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Past the number C -> ");
int number_C = Convert.ToInt32(Console.ReadLine());

int max = number_A;

if (max < number_B) max = number_B;
if (max < number_C) max = number_C;

Console.Write("Max = " + max);