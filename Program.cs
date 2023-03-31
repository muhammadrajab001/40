//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
//Console.WriteLine("Введите длину массива:  ");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] numbers = new int[size];
//RandonNumbers(numbers);
//Console.WriteLine("В этом массиве: ");
//PrintArray(numbers);

//void RandonNumbers(int[] numbers)
//{
  //  for(int i = 0; i < size; i++)
    //{
      //  numbers[i] = new Random().Next(100,1000);
   // }
//}
//int count = 0;

//for (int x = 0; x < numbers.Length; x++)
//{
//if (numbers[x] % 2 == 0)
//count++;
//}
//Console.WriteLine($"из {numbers.Length} чисел, {count} четных");


//void PrintArray(int[] numbers)
//{
  //  Console.Write(" ");
    //for(int i = 0; i < numbers.Length; i++)
    //{
      //  Console.Write(numbers[i] + " ");
    //}
    //Console.Write("]");
    //Console.WriteLine();
//Console.WriteLine("Введите длину массива:  ");
//int a = Convert.ToInt32(Console.ReadLine());
//int[] number = new int[a];
//RandonNumbers(numbers);
//Console.WriteLine("В этом массиве: ");
//PrintArray(numbers);

//void RandonNumbers(int[] numbers)
//{
  //  for(int i = 0; i < size; i++)
    //{
      //  numbers[i] = new Random().Next(100,1000);
   // }
//}
//for (int x = 0; x < numbers.Length; x++)
//{
//if (numbers[x] % 2 == 0)
//count++;
//}
//Console.WriteLine($"из {numbers.Length} чисел, {count} четных");


//void PrintArray(int[] numbers)
//{
    
    //for(int i = 0; i < numbers.Length; i++)
    //{
  //     Console.Write(numbers[i] + " ");
  //  }
      
   // Console.WriteLine();
    
//}

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

int [] array = {2,4,6,8};

int[] myArray = new int [0];

Console.WriteLine(myArray.Max());
myArray[0] =1;
myArray [1] =2;
Console.ReadLine();
void PrinArray()
{
 
 int[] myArray = new int [1];
 Console.WriteLine(myArray.Min());
 PrinArray();

}
// Задача 38: Задайте с клавиатуры массив ыещественных (double) чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// Задать размер (int) массива с клавиатуры
// [3 7 22 2 78] => 76

Console.WriteLine("Введите размер массива  ");
int a = Convert.ToInt32(Console.ReadLine());
double[] number = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
double Min = Int32.MaxValue;
double Max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > Max)
        {
            Max = numbers[z];
        }
    if (numbers[z] < Min)
        {
            Min = numbers[z];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {Max}, минимальное значение = {Min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {Max - Min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
   
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    
    Console.WriteLine();
}