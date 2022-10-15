/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/


int Exponentiation(int NumberA, int NumberB)
{
    int result = NumberA;
    for(int i = 1; i < NumberB; i++)
    {
        result = result * NumberA;
    }
    return result;
}

Console.WriteLine("Введите число A");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int NumberB = Convert.ToInt32(Console.ReadLine());
int exponentiation = Exponentiation(NumberA,NumberB);
Console.WriteLine(exponentiation);




/*
int getResult (string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation} ");
    while (!int.TryParse(Console.ReadLine(), out result) || result <= 1)
    {
        Console.Write($"Ошибка ввода! Введите целое число больше единицы. {userInformation} ");
    }
    return result;
}

int userNumber1 = getResult("Number 1 = ");
int userNumber2 = getResult("Number 2 = ");

double findResult (int Number1, int Number2)
{
    return Math.Pow(Number1, Number2);
}
Console.WriteLine(findResult(userNumber1, userNumber2));
*/