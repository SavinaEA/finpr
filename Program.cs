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
int CalkWoldArray(string[] inArray,int k)
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

Console.Clear();
string[] myArray = { "Hello", "2", "World", ":-)" };
int K = 3;
Console.WriteLine($"\nЗадание: Выбрать из списка элементы их {K}-х символов и менее ");
Console.Write("\nВходящий список: ");
string[] myArray1 = CopyMyArray(myArray);
Console.Write(String.Join(", ", myArray1));
Console.WriteLine();
Console.WriteLine($"\nЭлементов в первичном наборе: {myArray1.Length}");
Console.WriteLine();

int calk = CalkWoldArray(myArray1, K);
Console.WriteLine($"Элементов в итоговом наборе: {calk}");