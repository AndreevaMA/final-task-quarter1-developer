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