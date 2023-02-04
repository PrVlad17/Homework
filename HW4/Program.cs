Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
if((num % 2)==0)
{
    for(int i = num;i > 0; i = i - 2) Console.WriteLine(i);
    
}
else
{
    for(int i = num - 1;i > 0; i = i - 2) Console.WriteLine(i);
    
}