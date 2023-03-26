//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
Console.WriteLine ("виводите число");
int n = Convert.ToInt32(Console.ReadLine());
void PrinArray ()
{
     int[] array = new int [n];
     for(int i = 0; i < n; i++)
     {

         array[i] = Random.Shared.Next(0, 9);
         Console.WriteLine ("покажите число");

     }
 

}
int[] myarray = PrinArray ()
Console.WriteLine($"покажите трехзначни число {return} - {array} число");

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
 int[] array = {1,3,4,5};
int n = array.Length;
int sum  = 0;
int index = 0;

while (index < n)
{
   if (array[index]==sum )
   {
        array [n] = Random.Shared.Next(9,9);
    index++;

   }
 

}
//Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
Console.WriteLine ("ведите размер масива");
int a = Convert.ToInt32 (Console.ReadLine());
double [] number = new double [size];
Console.WriteLine ("масив");
PrinArray = (number);
Filarray = (number);
double Max = int.MaxValue;
double Min = int.MinValue;
for (int z = 0; z < number.Length; z++)
{
    if (number[z] > Max)
        {
            Max = number[z];
        }
    if (number[z] < Min)
        {
            Min = number[z];
        }
}

Console.WriteLine($"всего {number.Length} чисел. Максимальное значение = {Max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {Max - Min}");
void Filarray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrinArray (double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
     
 



