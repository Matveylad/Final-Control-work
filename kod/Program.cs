string[] countries = {"RSA", "USA", "Russia", "England", "Spain", "Chaina", "CAR", "UAE", "Iran", "Aruba"};
string[] result = new string[countries.Length];


void NewArr(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void Print(string[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write(mas[i]+" ");
    }
    Console.WriteLine();
}

NewArr(countries, result);
Print(countries);
Console.WriteLine();
Print(result);
