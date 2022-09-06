// Напишите программу, которая принимает на вход три числа и проверяет, может ли существоать треугольник
// со сторонами такой длины

Console.WriteLine("Введите первое число:");
int NumberX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int NumberY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int NumberZ = Convert.ToInt32(Console.ReadLine());

bool resultIsTriangle = IsTriangle(NumberX, NumberY, NumberZ);
if (resultIsTriangle == false)
{
    Console.WriteLine("Неверные параметры");
}
else
{
    Console.WriteLine("Треугольник может существовать");
}

bool IsTriangle(int x, int y, int z)
{
    if (x <= 0 || y <= 0 || z <= 0)
    {
        return false;
    }
    if ((x + y) > z && (x + z) > y && (y + z) > x)
    {
        return true;
    }
    return false;
}