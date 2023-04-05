// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int i = Read();

int Read()
{

    Console.WriteLine("Input five-digit number: ");
    int.TryParse(Console.ReadLine(), out i);
    return i;
}

int Compare()
{
    int i = Read();
    if ((i % 10) == (i / 10000))
    {
        if (((i % 100) / 10) == (i / 1000) % 10)
        {
            Console.WriteLine("Yes");
        }
        
    }
    else Console.WriteLine("No");
    return Compare();
}
