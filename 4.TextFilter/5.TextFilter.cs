string[] bannedWords = Console.ReadLine().Split(", ");

string text = Console.ReadLine();

foreach (string word in bannedWords)
{
    //string censorWord = "".PadLeft(word.Length, '*');
    string censorWord = new string('*', word.Length);

    while (text.Contains(word))
    {
        text = text.Replace(word, censorWord);
    }
}

Console.WriteLine(text);