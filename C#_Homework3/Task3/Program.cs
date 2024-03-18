static void ReverseUnoCard(string input)
{
char[] alphabetArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

    char[] chars = input.ToCharArray();
   for(int i = 0;  i < chars.Length; i++)
    {
       if (alphabetArray.Contains(chars[i]))
        {
            chars[i] = char.ToUpper(chars[i]);
        }
       else
        {
            chars[i] = char.ToLower(chars[i]);
        }
    }
    string result = new string (chars);
    Console.WriteLine(result);

}

string test = "TeSt StRiNg";
ReverseUnoCard(test);
