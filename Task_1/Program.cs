// Программа запрашивает натуральное число M, пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

//Console.WriteLine("Введите натуральное число: ");     // Не понятно что подразумевается под
//int value = Convert.ToInt32(Console.ReadLine());      // "Программа запрашивает"?
                                                        // Закоментарен вариант ввода от пользоватля

int value = new Random().Next(1, 10);

Console.WriteLine("Вводите числа " + value + " раз: ");

int[] array = new int[value];

for(int i = 0; i < value; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int count = 0;

for(int i = 0; i < value; i++)
{
    if(array[i] > 0)
    {
        count += 1;
    }
}

Console.WriteLine("Пользователь ввел " + count + " чисел больше 0");
