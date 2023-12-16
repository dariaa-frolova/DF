Console.WriteLine("Enter the words:");
List<string> words = new List<string>();
while (true)
{
    string word = Console.ReadLine();
    if (word == "")
        break;
    words.Add(word);
}
string shortword = words[0], longword = words[0];
for (int i = 0; i < words.Count; i++)
{
    if (words[i].Length > longword.Length)
        longword = words[i];
    if (words[i].Length < shortword.Length)
        shortword = words[i];
}
Console.WriteLine($"The longest word is {longword}, the shortest word is {shortword}");