//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом. Проверка без применения строк

//14212 -> нет
//12821 -> да
//23432 -> дa

int howManyDigits = 5;
int InputInt(string message)
{
    Console.Write($"{message} > ");
    int value;
    if (int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Ошибка.Введено не целочисленное значение");
    Environment.Exit(1);
    return 0;
}

bool ValidateValue(int value)
{
    int result = Convert.ToInt32(Math.Ceiling(Math.Log10(value)));
    if (result != howManyDigits)
    {
        System.Console.WriteLine($"Ошибка:введено число не содержащее {howManyDigits} цифр");
        return false;
    }
    return true;
}

int ReverseNamber(int value)
{
    int reverse = 0;
    while (value > 0)
    {
        reverse = reverse * 10 + value % 10;
        value = value / 10;
    }
    return reverse;
}

int namber = InputInt($"Введите пятизначное число");
if (ValidateValue(namber))
{
    if (namber == ReverseNamber(namber))
    {
        System.Console.WriteLine($"{namber} является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"{namber} не палиндром");
    }
}
