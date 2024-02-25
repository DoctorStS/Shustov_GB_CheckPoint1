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
        string[] stringsThreeOrLessChars = ChooseThreeOrLessCharStrings(randomStrings);
        Console.WriteLine();
        //Выводим форматированный массив строк
        foreach (string str in stringsThreeOrLessChars)
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
        int stringsLength = random.Next(5, 21); // Случайная длина массива от 5 до 20
        Console.WriteLine(stringsLength + " - Длина исходного массива"); // Отладочная печать, узнаем сколько элементов массива
        string[] randomStrings = new string[stringsLength];
        for (int i = 0; i < stringsLength; i++)
        {
            int stringLength = random.Next(2, 6); // Случайная длина строки от 2 до 5
            randomStrings[i] = GenerateRandomString(stringLength);
        }
        return randomStrings;
    }
/// <summary>
/// 
/// </summary>
/// <param name="strings"></param>
/// <returns></returns>
    static string[] ChooseThreeOrLessCharStrings(string[] strings)
    {
        string[] formattedString = new string[0];
        foreach (string str in strings)
        {
            if (str.Length <= 3)
            {
                formattedString = AddStrToArr(formattedString, str); // Добавляем строку
            }
            else continue;
        }
        return formattedString;
    }
    /// <summary>
    /// Добавление строки в массив
    /// </summary>
    /// <param name="strings">Обрабатываемый массив</param>
    /// <param name="newString">Добавляемая строка</param>
    /// <returns>Массив с новой строкой</returns>
    static string[] AddStrToArr(string[] strings, string newString)
    {
        // Увеличиваем размер массива на 1 элемент
        Array.Resize(ref strings, strings.Length + 1);
        // Добавляем новую строку в конец массива
        strings[strings.Length - 1] = newString;
        return strings;
    }
}