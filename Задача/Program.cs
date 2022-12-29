/* Напишите программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо равна 3 символа.*/


int[] InitArray(int length) 
{     
    int[] array = new int[length];     
    Random rnd = new Random();    
    for (int i = 0; i < length; i++)    
    {         
        array[i] = rnd.Next(10,50);     
    }      
    return array; 
}  

void PrintArray(int[] array) 
{     
    Console.Write("["); 
    for (int i = 0; i < array.Length; i++)     
        {        
          Console.Write($"{array[i]}, ");     
        }     
        Console.Write("]"); 
    Console.WriteLine(); 
} 

void NewArray(ref int[] array, int index)
{
    int [] newResult = new int [array.Length - 1];
    for (int i = 0; i < index; i++)
    {
        newResult [i] = array[i];
    }
    for (int i = index + 1; i < array.Length; i++)
    {
        newResult [i-1] = array[i];
        array = newResult;
    }
}

int [] array = InitArray(4);
PrintArray(array);
Console.WriteLine();

NewArray(ref array, 2);
PrintArray(array);