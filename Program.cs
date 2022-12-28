
System.Console.WriteLine("Введите значения массива через пробел: ");
string str = Console.ReadLine() ?? "";

string[] array = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}


string[] NewArray(string[] arra)
{
    string[] result = new string[arra.Length];

    for (int i = 0; i < arra.Length; i++)
    {
        string str = arra[i];
        if (str.Length <= 3)
        {
            result[i] = arra[i];
        }
    }

    result = result.Where(x => x != null).ToArray();

    if (result.Length == 0)
    {
        System.Console.WriteLine("нет значений");
    }
    
    return result;
}

string[] ar = NewArray(array);
PrintArray(ar);