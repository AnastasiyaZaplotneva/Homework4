// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Degree (int numberA, int numberB)
{
    int result = numberA;
    int count = 2;
    while(count <= numberB)
    {
        result = result*numberA;
        count++;
    }
    return result;
}

Console.Clear();
while(true)
{
    Console.WriteLine("Введите первое число от 0 до 10");
    int numA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число от 0 до 10");
    int numB = Convert.ToInt32(Console.ReadLine());
    if(numB > 0)
    {
        int degree = Degree(numA, numB);
        Console.WriteLine($"Число {numA}, возведенное в степень {numB}, равняется {degree}");
        break;
    }
}
