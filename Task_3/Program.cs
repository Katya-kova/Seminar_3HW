// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


int N = GetNum();
int GetNum()
{
    Console.WriteLine("Input a number: ");
    while((!int.TryParse(Console.ReadLine(), out N)))
    {
        Console.WriteLine("It's not a number");
    }
    return N;
}

string GetCoube()
{
    string result = " ";
    for( int i = 1; i <= N; i++ )
    {
        result += Math.Pow(i, 3)+" ";
    }
    return result;

}
Console.Write(GetCoube());


