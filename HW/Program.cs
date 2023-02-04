//Задача намбер ту
Console.WriteLine("input your number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input your number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше чем число {num2}");
}
else
{
    Console.WriteLine($"Число {num2} больше чем число {num1}");
}