// Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Если кол-во элементов нечетное, то элемент посередине не учитывать.
// Результат сложения вывести на экран.

Console.WriteLine("Введите длину массива: ");    
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное и максимальное значение генерируемых чисел массива: ");    
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[] array = new int[length];

for(int i = 0; i < length; i++)             // Заполняем массив случайными числами
{
    array[i] = new Random().Next(min, max);
    Console.Write(array[i] + " ");          // Вывод для наглядности
}

int temp = 0;                               // Нужна только для вывода произведений
int sum = 0;
Console.WriteLine( " "); 
for(int i = 0; i < length / 2; i++)
{
    temp = array[i] * array[length - i -1];
    sum = sum + temp;
    Console.Write(temp + " ");              // Вывод для наглядности
}

Console.WriteLine("\nСумма произведений пар чисел: " + sum); 
