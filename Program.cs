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

Console.Clear();
string[] myArray = { "Hello", "2", "World", ":-)" };
int K = 3;
Console.WriteLine($"Задание: Выбрать из списка элементы их {K}-х символов и менее ");
Console.Write("\nВходящий список: ");
string[] myArray1 =  CopyMyArray(myArray);
Console.Write(String.Join(", ", myArray1));
Console.WriteLine();
Console.WriteLine($"\nЭлементов в первичном наборе: {myArray1.Length}");

int calk = CalkWoldArray(myArray1, K);
string[] myArray2 = CreateSecondArray(myArray1, calk, K);
Console.WriteLine();
Console.WriteLine($"Элементов в итоговом наборе: {calk}");

Console.Write("\nИтоговый список: ");
Console.WriteLine(String.Join(", ", myArray2));
Console.WriteLine();