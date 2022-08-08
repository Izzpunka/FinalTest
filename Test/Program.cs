Console.WriteLine("Ввведите 5 строк");
string[] stringArray = new string[5];
for(int i = 0; i < stringArray.Length; i++)
{
   stringArray[i] = Console.ReadLine();
}

string[] finalArray = new string[stringArray.Length];

void NewArray(string[] stringArray, string[] finalArray)
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
    if(stringArray[i].Length <= 3)
        {
        finalArray [count] = stringArray[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

NewArray(stringArray, finalArray);
PrintArray(finalArray);

