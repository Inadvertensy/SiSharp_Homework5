// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих 
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] EnterRandomArray()
{  
    Console.WriteLine("Please enter size of the array....");
    int arraySize=Convert.ToInt32(Console.ReadLine());
    int []array= new int [arraySize];
    
    for (int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(0,15);
    }
    System.Console.WriteLine("Your array is...");
    System.Console.WriteLine(String.Join(",",array));
    return array;
    }
 
void SumOfNotEvenPositions(int [] array)
{
    int count=0;
    for (int j=0; j<array.Length; j++)
    {
        if (j%2!=0)
        {
        count+=array[j];
        }
    }
    System.Console.WriteLine(count);
} 
 SumOfNotEvenPositions(EnterRandomArray());