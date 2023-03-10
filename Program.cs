//  Создать массив из элементов массива, имеющих 3 символов либо менее

// 1.Создание нового массива по числу элементов входящих данных
string[] CopyMyArray(string[] firstArray)
{
    string[] secondArray = new string[firstArray.Length];
    for (int i = 0; i < firstArray.Length; i++)
    {
        secondArray[i] = firstArray[i];
    }
    return secondArray;
}

//2.  Определение количества элементов массива по требуемому условию
int CalkWoldArray(string[] inArray, int k)
{
    int countW0ld = 0;
    string wold = "";
    for (int i = 0; i < inArray.Length; i++)
    {
        wold = inArray[i];
        int countLetter = wold.Length;
        if (countLetter <= k) countW0ld++;
    }
    return countW0ld;
}

//3. Создание нового массива по количеству элементов
string[] CreateSecondArray(string[] firstArray, int size, int k)
{
    string[] secondArray = new string[size];
    string wold = "";
    int j = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        wold = firstArray[i];
        int countLetter = wold.Length;
        if (countLetter <= k)
        {
            secondArray[j] = wold;
            j++;
        }
    }
    return secondArray;
}

//4. Добавление новых элементов в массив
string[] Append(string[] array, int count)
{
    string[] result = new string[array.Length + count];
    array.CopyTo(result, 0);
    for (int i = array.Length; i < result.Length; i++)
    {
        Console.Write("\nВведите новый элемент: ");
        string text = Console.ReadLine()!;
        result[i] = text;
    }
    return result;
}



Console.Clear();
string[] myArray = { "Hello", "World", "!" };
int K = new Random().Next(1, 6
);;
Console.WriteLine($"Задание: Выбор элементов из списка");
Console.Write("\nВходящий список: ");
string[] myArray1 = CopyMyArray(myArray);
Console.Write(String.Join(", ", myArray1));
Console.WriteLine();
Console.WriteLine($"\nЭлементов в первичном наборе: {myArray1.Length}");

Console.Write("\nДавайте добавим элементов в программный список. Сколько?: ");
int N = int.Parse(Console.ReadLine()!);
string[] result = Append(myArray1, N);

int calk = CalkWoldArray(result, K);
string[] myArray2 = CreateSecondArray(result, calk, K);
Console.WriteLine();
Console.WriteLine($"Символов в элементе будет не более: {K}");
Console.WriteLine($"\nЭлементов в итоговом наборе: {calk}");

Console.Write("\nИтоговый список: ");
Console.WriteLine(String.Join(", ", myArray2));
Console.WriteLine();