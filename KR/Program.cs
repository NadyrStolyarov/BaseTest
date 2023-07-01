Console.Write("Введите количество элементов массива:");
int num = Convert.ToInt32(Console.ReadLine());
string [] stringArr = new string [num];

void array(string [] stringArr)
{
    for (int i = 0;i<stringArr.Length;i++)
    {
        Console.Write($"Введите {i+1} элемент массива: ");
        stringArr[i] = Console.ReadLine();
    }
}

string [] ArrayResault(string [] stringArr)
{
    int c = 0;
    for (int i = 0;i<stringArr.Length;i++)
    {
        if(stringArr[i].Length <=3)
        c++;
    }
    string [] ArrRes = new string [c];
    int j = 0;
    for (int i = 0;i<stringArr.Length;i++)
    {
        if(stringArr[i].Length <=3)
        {
            ArrRes[j] = stringArr[i];
            j++;
        }
    }
    return ArrRes;
}

void printA(string [] stringArr)
{
    Console.Write("[");
    for (int i = 0;i<stringArr.Length;i++)
    {
    Console.Write($"{stringArr[i]}, ");
    }
    Console.Write("]");
}


array(stringArr);
Console.WriteLine("массив из строк, длина которых <= 3 символам:");
printA(ArrayResault(stringArr));