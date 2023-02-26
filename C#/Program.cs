
void ShowStringArray(string[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}
string[] Сhoice(string[] mass)
{
    string[] exit={};
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i].Length <= 3)
        {
            exit = exit.Append(mass[i]).ToArray();
        }
    }
    return exit;
}

string[] mass = { "чур", "реформа", "войско", "метр", "май", "минута", "озеро", "музей", ":-)" };

Console.WriteLine("изначальный массив:");
ShowStringArray(mass);

Console.WriteLine("");

Console.WriteLine("результат выборки:");
ShowStringArray(Сhoice(mass));