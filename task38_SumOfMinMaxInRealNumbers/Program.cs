// Задача 38: Задайте массив вещественных чисел. Найдите 
// разницу между максимальным и минимальным 
// элементов массива.
//[3 7 22 2 78] -> 76


double [] EnterRandomArray()
{  
    Console.WriteLine("Please enter size of the array....");
    int arraySize=Convert.ToInt32(Console.ReadLine());
    double []array= new double [arraySize];
    
    for (int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(-5,15);
    }
    System.Console.WriteLine("Your array is...");
    System.Console.WriteLine(String.Join(",",array));
    
    return array;
    }

void SumOfMinAndMax(double [] array)
{
    int maxPosition=0;
    int minPosition=0;
    double SumMinMAx=0;
    for (int j=0; j<array.Length; j++)
    {       
        {
            if(array[j]>array[maxPosition]) maxPosition=j;
        }
        
        {
            if(array[j]<array[minPosition]) minPosition=j;
        }

    }
    SumMinMAx=array[maxPosition]-array[minPosition];
   
    System.Console.WriteLine(SumMinMAx);
}

SumOfMinAndMax(EnterRandomArray());