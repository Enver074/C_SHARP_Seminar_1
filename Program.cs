// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
double Num1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
double Num2 = double.Parse(Console.ReadLine()!);

if(Num1 > Num2){
    Console.WriteLine("max = " + Num1);}
if(Num1 == Num2){
    Console.WriteLine("max = " + Num1);}
else{
    Console.WriteLine("max = " + Num2);}
