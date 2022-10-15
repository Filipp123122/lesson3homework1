/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());

int SummOfDigits(int Number)
{         
    if(Number < 0)
    {
        Number = Math.Abs(Number);
    }
    int Summ = 0;
    while (Number > 0)
    {
        Summ = Summ + Number % 10;
        Number = Number / 10;
    }
    return Summ;
}
int result = SummOfDigits(Number);
Console.WriteLine(result);


