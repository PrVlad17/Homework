Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
if(num ==0)
{
    Console.WriteLine("число равно нулю");
}
else if((num % 2)== 0)
{
    Console.WriteLine("число четное");
}
else 
{
    Console.WriteLine("число не четное");
}

