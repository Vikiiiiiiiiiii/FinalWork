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

