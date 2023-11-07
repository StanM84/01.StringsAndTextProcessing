string word = Console.ReadLine();

while (word != "end")
{
    //string reversed = "";

    //for (int i = word.Length - 1 ; i >= 0; i -= 1 )
    //{
    //    reversed += word[i];
    //}

    //char[] wordAsCharArray = word.ToCharArray();
    //Array.Reverse(wordAsCharArray);
    //string reversed = string.Join("", wordAsCharArray);

    string reversed = string.Join("", word.ToCharArray().Reverse());

    Console.WriteLine($"{word} = {reversed}");

    word = Console.ReadLine();
}