// Задача 41
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3




// Console.Write("Введите количество чисел: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[size];
// var rnd = new Random();
// int index = 0;

// while (index < array.Length)
// {
//     array[index] = rnd.Next(-100, 100);
//     Console.Write($"{array[index]} ");
//     index++;
// }

// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0) count++;
// }

// Console.WriteLine();
// Console.WriteLine($"Количество  чисел больше 0 = {count} ");



////////////////////////////////////////

Console.Write($"Введите количество чисел:  ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i + 1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());

    if (array[i] > 0) count++;
}

Console.WriteLine($"Количество  чисел больше 0 = {count} ");

