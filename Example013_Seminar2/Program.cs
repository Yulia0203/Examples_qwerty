  // Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

  bool CheckNumber(int number)
  {
    if(number % 7 == 0)
    {
        if(number % 23 == 0)
        {
            return true;
        }
    }
    return false;
  }

  Console.Write("Введите число: ");
  int firstNumber = Convert.ToInt32(Console.ReadLine());
  bool result = CheckNumber(firstNumber);
  Console.Write(result);
  

