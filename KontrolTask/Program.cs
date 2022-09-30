Console.Clear();

string[] massive1 = {"hello", "2", "world", ":-)"};
string[] massive2 = {"1234", "1567", "-2", "computer science"};
string[] massive3 = {"Russia", "Denmark", "Kazan"};
string[] newMassive = NewMassiveUnder3(massive1);
PrintMassive(newMassive);

string[] NewMassiveUnder3(string[] array)
{
    string[] arrayUnder3 = new string[array.Length];
    int lengthOfWord = 3;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= lengthOfWord) arrayUnder3[i] = array[i];
    }
    return arrayUnder3;
}

void PrintMassive(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
}