// See https://aka.ms/new-console-template for more information
string str = "Display the pattern like pyramid using the alphabet.";
string[] words =  str.Split(' ');
string result = "";
for (int i = 1; i <= words.Length; i++)
{
    result = result + words[words.Length - i] + " ";
}
Console.WriteLine(result);