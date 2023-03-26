// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int FirstNumber = int.Parse(Console.ReadLine());
int SecondNumber = int.Parse(Console.ReadLine());

int max = FirstNumber;
int min = FirstNumber;

if(SecondNumber > max)
{
    Console.Write("max = ");
    Console.WriteLine(max = SecondNumber);
    Console.Write("min = ");
    Console.WriteLine(min = FirstNumber);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(max = FirstNumber);
    Console.Write("min = ");
    Console.WriteLine(min = SecondNumber);
}
