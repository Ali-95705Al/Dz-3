// Задача 4: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int InputInt(string message)                                
{
    System.Console.Write($"{message}> ");                 
    int value;                                            
    if (int.TryParse(Console.ReadLine(), out value))     
    {                                                     
        return value;                                     
    }                                                     
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);                                 
    return 0;                                             
}

int number = InputInt("Введите число N, до которого выдадим квадраты: "); 

for (int i = 1; i <= number; i++) 
{  
    int square = i * i;              
    System.Console.Write($"{square} ");  
}