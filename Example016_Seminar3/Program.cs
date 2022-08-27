// Напищите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y)

int Number = Convert.ToInt32(Console.ReadLine());
string GetCoordinat (int Number)
{
    switch(Number)
    {
        case 1: return "x > 0, y > 0"; break;
        case 2: return "x < 0, y > 0"; break;
        case 3: return "x < 0, y < 0"; break;
        case 4: return "x > 0, y < 0"; break;
        default: return("Ошибка"); break;
    }
}
string result = GetCoordinat(Number);
System.Console.WriteLine(result);