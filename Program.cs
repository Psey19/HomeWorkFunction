//Задача №1


while (true)
{
    Console.Write("Введите число или'q'для выхода:");
    string input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    int digits = Convert.ToInt32(input);
    int count = 0;
    int D = digits;
    while (D > 0)
    {
        D = D / 10;
        count++;
    }
    int sum = 0;
    int[] Alldigits = new int[count];
    for (int i = 0; i < count; i++)
    {
        Alldigits[i] = digits / Convert.ToInt32(Math.Pow(10, count - 1 - i)) % 10;
        sum = sum + Alldigits[i];
    }
    if (sum % 2 == 0)
    {
        Console.WriteLine("[STOP]");
        break;
    }
}

//Задача №2

int[] CreateArray(int size)
{
    int[] createdarray = new int[size];
    for (int i = 0; i < size; i++)
    {
        createdarray[i] = new Random().Next(100, 1000);
    }
    return createdarray;
}

int CountEven(int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]} ");
    }
}

int size = new Random().Next(1, 10);
int[] NewArray = CreateArray(size);
PrintArray(NewArray);
Console.WriteLine();
Console.WriteLine("Count of Even is " + CountEven(NewArray));



//Задача №3


int[] Array = { 1, 5, 53, 22, 21, 6, 4 };
Console.Write("Array:         ");
foreach(int e in Array)
{ 
    Console.Write(e + " ");
}
Console.WriteLine();

int temp;
for (int i = 0; i < Array.Length / 2; i++)
{
    temp = Array[i];
    Array[i] = Array[Array.Length - 1 - i];
    Array[Array.Length - 1 - i] =  temp;
}

Console.Write("Reverse Array: ");
foreach(int e in Array)
{ 
    Console.Write(e + " ");
}