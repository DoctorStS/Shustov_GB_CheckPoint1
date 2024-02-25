class Program
{
    /* Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
    длина которых меньше, либо равна 3 символам.*/
    private static Random random = new Random(); // Объект ГСЧ, чтобы не создавать заново
    static void Main()
    {
        Console.Clear();
        string[] randomStrings = GenerateRandomStrings();
        // Выводим изначальный массив строк
        foreach (string str in randomStrings)
        {
            Console.Write(str + "\t"); 
        }
    }
    /// <summary>
    /// Генератор символов
    /// </summary>
    /// <returns>Случайный символ</returns>
    static char RandomCharGen()
    {
        char rndChar = (char)random.Next('!', 'z' + 1);
        return rndChar;
    }
    /// <summary>
    /// Генератор строк
    /// </summary>
    /// <param name="length">Длина строки</param>
    /// <returns>Строка случайной длины</returns>
    static string GenerateRandomString(int length)
    {
        char[] randomChars = new char[length];
        for (int i = 0; i < length; i++)
        {
            randomChars[i] = RandomCharGen();
        }
        return new string(randomChars);
    }
    /// <summary>
    /// Генератор массива строк
    /// </summary>
    /// <returns>Массив строк случайной длины</returns>
    static string[] GenerateRandomStrings()
    {
        int arrayLength = random.Next(1, 21); // Случайная длина массива от 1 до 20
        Console.WriteLine(arrayLength + "- Длина массива\n"); // Отладочная печать, узнаем сколько элементов массива
        string[] randomStrings = new string[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            int stringLength = random.Next(2, 6); // Случайная длина строки от 2 до 5
            randomStrings[i] = GenerateRandomString(stringLength);
        }
        return randomStrings;
    }
    //Добавить обработчик по условию, коммит
}