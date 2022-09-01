// Напищите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y)

int Number = Convert.ToInt32(Console.ReadLine());
string GetCoordinat (int Number)
{
    switch(Number)
    {
        case 1: return "x > 0, y > 0"; 
        case 2: return "x < 0, y > 0"; 
        case 3: return "x < 0, y < 0"; 
        case 4: return "x > 0, y < 0"; 
        default: return("Ошибка"); 
    }
}
string result = GetCoordinat(Number);
System.Console.WriteLine(result);