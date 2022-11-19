/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/
int Number1 = new int();
Console.WriteLine("Enter For Number");
Number1 = Convert.ToInt32(Console.ReadLine());
int Number2 = new int();
Console.WriteLine("Enter For Number");
Number2 = Convert.ToInt32(Console.ReadLine());
int Number3 = new int();
Console.WriteLine("Enter For Number");
Number3 = Convert.ToInt32(Console.ReadLine());
int max = Number1;
if (Number1 > max) max = Number1;
if (Number2 > max) max = Number2;
if (Number3 > max) max = Number3;
Console.Write("Max Number");
Console.WriteLine(max);