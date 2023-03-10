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