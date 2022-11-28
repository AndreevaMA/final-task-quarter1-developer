// Final task at 1Q developer course


//------------------------------------Program start------------------------------------
int size = UserInput("Input an integer from 5 to 10: ", "Input error!");
Console.WriteLine($"Now an array with size = {size} will be created");

string[] initArray = FillArray(size);
PrintArray(initArray);

Console.WriteLine();
Console.WriteLine($"The new array will consist only of those elements which symbols quantity <= 3: ");

string[] newArray = CreateArray(initArray);
PrintArray(newArray);

//-------------------------------------Program end-------------------------------------

//---------------------------------------METHODS---------------------------------------
//-------------------------------------User input--------------------------------------
static int UserInput(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int number);
        if (isCorrect)
        {
            if (number > 4 && number < 11) return number;
        }
        else Console.WriteLine(errorMessage);
    }
}

//----------------------------------Printing an array----------------------------------
static void PrintArray(string[] elements)
{
    if (elements.Length == 0) Console.WriteLine($"[]");
    else
    {
        Console.Write($"[");
        for (int i = 0; i < elements.Length - 1; i++)
        {
            Console.Write($"\"{elements[i]}\", ");
        }
        Console.Write($"\"{elements[elements.Length - 1]}\"]");
    }
}

//----------------------------------Filling an array-----------------------------------
static string[] FillArray(int number)
{
    string[] elements = new string[number];
    for (int i = 0; i < number; i++)
    {
        Console.Write($"Input some symbols: ");
        elements[i] = Console.ReadLine() ?? "";
    }
    return elements;
}