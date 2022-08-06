Console.Write("Введите число: ");

if (double.TryParse(Console.ReadLine(), out double userInputDouble))
    Console.WriteLine(userInputDouble * userInputDouble); 

else
    Console.WriteLine("Ошибка ввода! Введите число!");
