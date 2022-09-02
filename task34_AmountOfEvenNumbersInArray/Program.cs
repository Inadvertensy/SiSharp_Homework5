// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите 
// программу, которая покажет количество чётных чисел в 
// массиве.

// [345, 897, 568, 234] -> 2

int [] EnterRandomArray()
{  
    Console.WriteLine("Please enter size of the array....");
    int arraySize=Convert.ToInt32(Console.ReadLine());
    int []array= new int [arraySize];
    
    for (int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(100,999);
    }
    System.Console.WriteLine("Your array is...");
    System.Console.WriteLine(String.Join(",",array));
    return array;
    }
 
void SumOfEvenNumbers(int [] array)
{
    int count=0;
    for (int j=0; j<array.Length; j++)
    {
        if (array[j]%2==0)
        {
        count++;
        }
    }
    
    System.Console.WriteLine(count);
} 

 SumOfEvenNumbers(EnterRandomArray());