//Задача намбер фор
Console.WriteLine("введите количество чисел:");
int kolvo = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int [kolvo];
for (int i=0; i<array1.Length; i++)
  array1[i] = Convert.ToInt32(Console.ReadLine());
int max;
max = array1[0];
for (int i=0; i<array1.Length; i++)
if(max < array1[i])
   
    max = array1[i];
   
 
Console.WriteLine($"максимальное число, {max}");