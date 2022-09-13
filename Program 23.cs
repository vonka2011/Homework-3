// Напишите прогр.,кот. принимает на вход число N и выдает табл.кубов от 1 до N/
void CubsNumbers(int number)
{
    if (number < 0)
    {
        Console.WriteLine("Вы ввели отрицательное число, поэтому мы сами его преобразовали в положительное ;)");
        number = number * -1;
    }
    if (number == 0)
    {
        Console.WriteLine("Вы ввели 0, чисел нет!");
    }
    int count = 1;
    while (count <= number)
    {
        int result = count * count * count;
        Console.Write(result + " ");
        count++;
    }
}

Console.Write("Введите число N и программа выдаст таблицу кубов чисел от 1 до N: ");
int number = Convert.ToInt32(Console.ReadLine());

CubsNumbers(number);
Console.WriteLine(); 
