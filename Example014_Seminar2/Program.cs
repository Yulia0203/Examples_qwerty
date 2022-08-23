// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого


Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

bool CheckNumber(int firstNumber, int secondNumber)
{
    if(firstNumber > secondNumber)
    {
        if(secondNumber * secondNumber == firstNumber)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    if(firstNumber * firstNumber == secondNumber)
    {
        return true;
    }
        else
            {
                return false;
            }
        }
    

bool result = CheckNumber (a, b);
if(result == true)
{
    Console.WriteLine("Да");
}
else
{
  Console.WriteLine("Нет");  
}