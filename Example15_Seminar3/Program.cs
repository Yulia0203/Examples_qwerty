// Напишите программу, которая принимает на вход координаты точки (X и Y), причем X и Y не равны нулю
// и выдает номер четверти плоскости, в которой находится эта точка

Console.WriteLine("Введите x");
bool isNumberX = int.TryParse(Console.ReadLine(), out int x);

Console.WriteLine("Введите y");
bool isNumberY = int.TryParse(Console.ReadLine(), out int y);

if(isNumberX != true || isNumberY != true)
{
    Console.WriteLine("Числа введены неверно");
    return;
}

bool Validate(int x, int y)
{
    if(x == 0 || y == 0)
    {
        return false;
    }
    return true;
}

bool isValid = Validate(x, y);
if(isValid == false)
{
    Console.WriteLine("Какое-то число равно нулю");
    return;
}

int result = GetPosition(x, y);
Console.WriteLine(result);

int GetPosition(int x, int y)
{
    if(x > 0 && y > 0)
    {
        return 1;
    }
    if(x < 0 && y > 0)
    {
        return 2;
    }
    if(x < 0 && y < 0)
    {
        return 3;
    }
    if(x > 0 && y < 0)
    {
        return 4;
    }
    return -1;
}



