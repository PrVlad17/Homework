



/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
string pol = Console.ReadLine();
if ((pol [0] == pol [4])&& (pol[1] == pol[3]))
{
    Console.WriteLine("Введеное число является палиндромом"); 
}
    else
    {
        Console.WriteLine("Введеное число не является палиндромом");
    }
*/
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.




/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int kub = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= kub; i++)
{
    Console.WriteLine(i+" в кубе= "+i*i*i);


}
*/












//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int result = A;
for(int i= 1;i < B;i++)
{
    result*=A;
}
Console.WriteLine($"{A} в степени {B} = {result}");
*/
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*string chisla = Console.ReadLine();
int result = 0;
for(int i=0;i < chisla.Length;i++)
{
    result+=Convert.ToInt32(chisla[i]-48);

}

Console.WriteLine(result);


*/
//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*int [] chisla = new int [10];
Random rand = new Random ();
int chet =0;
for(int i=0; i<chisla.Length; i++)
{
    chisla[i]=rand.Next(100,999);
    if(chisla[i]%2==0)
    {
        chet++;
    }
    Console.WriteLine(chisla[i]);
}
Console.WriteLine(chet);
*/
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*int [] chisla = new int [10];
Random rand = new Random ();
int nechet=0;
for(int i=0; i<chisla.Length; i++)
{
    chisla[i]=rand.Next(100);
    if(i%2!=0)
    {
        nechet+=chisla[i];
    }
    Console.WriteLine(chisla[i]);
}
Console.WriteLine(nechet);
*/
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. Math.Min Math.Max не использовать
/*double [] chisla = new double [6] {4.2,2.2,5.3,4.5,3.6,7.5};
double raznitca = 0;
double max = chisla[0];
double min = chisla[0];
for(int i=1; i<chisla.Length; i++)
{
    if(chisla[i]>max)
    {
        max=chisla[i];
    }
    if(chisla[i]<min)
    {
        min=chisla[i];
    }
    raznitca=max-min;
} 
Console.WriteLine(raznitca);  
*/
/*//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("введите числа");
int [] chis = new int [5];
int bolshe = 0;
for(int i=0;i<chis.Length;i++)
chis[i]= Convert.ToInt32(Console.ReadLine());
for(int i=0;i<chis.Length;i++)
{
    if(chis[i]>0)
    {
        bolshe++;
    }
}
Console.WriteLine(bolshe);
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.




*/





































//напиши сумму программу от 1 до n
/*int SumFor (int n)

{
    int result = 0;
    for(int i=0; i<=n; i++) result+=i;
    return result;
}



int SumFor1(int n)
{
    if (n == 0) return 0;
    else return n + SumFor1(n-1);
}
Console.WriteLine(SumFor1(3));
*/

//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.







