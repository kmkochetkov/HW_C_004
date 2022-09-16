// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы массива вводятся пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// Ввод массива

int[] MassCompletion()
{
    int[] mass = new int[8];
    for (int i = 0; i < 8; ++i)
        {
            mass[i] = 0;
            try
            {
                Console.Write($"Введите элемент массива {i+1}: ");
                mass[i] = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {    
                Console.WriteLine("Нужно вводить целое число!");
            }
        }
    return mass;
}

// Печать массива

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.WriteLine("Массив:");
    Console.Write("[");
    while (position < count)
    {
        if (position != (count-1))      // Проверяю, является ли элемент последним для печати без запятой
        {
        Console.Write($" {col[position]},");
        }
         else
        {
            Console.Write($" {col[position]}");
        }
        position++;
    }
    Console.WriteLine(" ]");    
}

PrintArray(MassCompletion());