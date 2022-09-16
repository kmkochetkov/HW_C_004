// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



// Ввод данных и проверка введённых данных

Console.WriteLine("Введите целое число:");
int num = 0;

try
    {
        num = Convert.ToInt32(Console.ReadLine());
    }
catch 
    {    
        Console.WriteLine("Вводите, пожалуйста, целое число");
    }



int Sum(int num) // Расчёт суммы цифр
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num /10 ; 
    }
    return sum;
}
 
 
 Console.WriteLine(Sum(num));  // Печать суммы цифр