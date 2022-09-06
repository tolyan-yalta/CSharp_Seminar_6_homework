// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// Рекомендую учесть три возможных случая расположения двух прямых.

double entering_value_b1()
{
    Console.WriteLine("Введите значение b1 :");
    double b1 = Convert.ToDouble(Console.ReadLine());
    return b1; 
}

double entering_value_b2()
{
    Console.WriteLine("Введите значение b2 :");
    double b2 = Convert.ToDouble(Console.ReadLine());
    return b2;
}

double entering_value_k1()
{
    Console.WriteLine("Введите значение k1 :");
    double k1 = Convert.ToDouble(Console.ReadLine());
    return k1;
}

double entering_value_k2()
{
    Console.WriteLine("Введите значение k2 :");
    double k2 = Convert.ToDouble(Console.ReadLine());
    return k2;
}

double b1 = entering_value_b1();
double b2 = entering_value_b2();
double k1 = entering_value_k1();
double k2 = entering_value_k2();

bool check1 = false;
bool check2 = false;
while(check1 == false || check2 == false)
{
    if(k1 == k2 && b1 == b2)
    {
        Console.WriteLine("При k1 = k2  и b1 = b2 прямые совпадают, задайте значения заново");
        b1 = entering_value_b1();
        b2 = entering_value_b2();
        k1 = entering_value_k1();
        k2 = entering_value_k2();
    }
    else check1 =true;

    if(k1 == k2)
    {
        Console.WriteLine("При k1 = k2 прямые параллельны, задайте значения заново");
        k1 = entering_value_k1();
        k2 = entering_value_k2();   
    }
    else check2 = true;
}

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения двух прямых находится в координатах х = {x} и у = {y}");
