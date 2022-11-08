// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int DigitSum (int num)
{
    int result = 0; //на случай, если пользователь введет 0, сумма будет 0
    while(num != 0)
    {
        result = result + num%10;
        num = num/10;
    }
    return result;
}


Console.Clear();
Console.WriteLine("Введите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int summa = DigitSum(number);
Console.WriteLine($"Сумма цифр числа {number} равна {summa}");

