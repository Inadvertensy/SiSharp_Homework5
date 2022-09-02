// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний 
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int [] EnterRandomArray()
{  
    Console.WriteLine("Please enter size of the array....");
    int arraySize=Convert.ToInt32(Console.ReadLine());
    int []array= new int [arraySize];
    
    for (int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(-1000,1000);
       
    }
    System.Console.WriteLine(String.Join(",",array));
    return array;

}

void PeriodOfPairs(int [] array)
{
    int Pair=0;
    
    int array2Size=(array.Length)/2;
    int []array2=new int [array2Size];
    int j=0;
    
    for (int k=0;k<array2.Length;k++)
    {
            Pair=array[j]*array[array.Length-1-j];
            array2[k]=Pair;
            j++;
    }
    Console.WriteLine("The second array is .... ");
    Console.WriteLine(String.Join(",",array2));
    
}
 PeriodOfPairs(EnterRandomArray());
