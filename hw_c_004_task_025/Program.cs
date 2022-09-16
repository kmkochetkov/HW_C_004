// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Решить задачу с использованием методов.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



// Ввод данных и проверка введённых данных


int[] Data()
{
    int[] data = new int[2];
    for (int i = 0; i < 2; ++i)
        {
            data[i] = 0;
            try
            {
                Console.Write($"Введите {i+1}-e число: ");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {    
                Console.WriteLine("Нужно вводить целое число!");
            }
        }
    return data;
}





double Degree(int[] col)
{
    int number = col[0];
    int res = number;
 for (int i=1; i<col[1]; i++)
     res = res*number;
     return res;
}


Console.WriteLine($" Результат возведения в степень: {Degree(Data())}");
