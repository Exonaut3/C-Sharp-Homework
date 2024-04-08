using MyDamn.Domain;

int integer = 60420;
double aDouble = 124.2534635;
string aString = "I think that maybe mankind wasn't made to pay taxes";
bool aBoolean = true;
char aChar = 'n';

List<string> aListofStrings = new List<string>()
{
    "H E A V E N", 
    "E E",
    "A   A",
    "V     V",
    "E       E",
    "N         N"

};

List<int> aListOfInts = new List<int>()
{
    01000111, 01101111, 01100100, 01110011, 00100000, 01101001, 01101110, 00100000, 01101000, 01101001, 01110011, 00100000, 01101000, 01100101, 01100001, 01110110, 01100101, 01101110, 00001010, 01000001, 01101100, 01101100, 01110011, 00100000, 01110010, 01101001, 01100111, 01101000, 01110100, 00100000, 01110111, 01101001, 01110100, 01101000, 00100000, 01110100, 01101000, 01100101, 00100000, 01110111, 01101111, 01110010, 01101100, 01100100

};

List<bool> aListOfBools = new List<bool>()
{
    false, true, false, false, false, true, true,true, false,true,true,false,true,true,true,true,false,true,true,true,false,false,true,true
};

List<char> aListOfChars = new List<char>()
{
    'S','I','L','E','N','C','E'
};


PrintInConsole<int>.Print(integer);
PrintInConsole<double>.Print(aDouble);
PrintInConsole<string>.Print(aString);
PrintInConsole<bool>.Print(aBoolean);
PrintInConsole<char>.Print(aChar);
Console.WriteLine("\n");
PrintInConsole<string>.PrintColleciton(aListofStrings);
PrintInConsole<int>.PrintColleciton(aListOfInts);
PrintInConsole<bool>.PrintColleciton(aListOfBools);
PrintInConsole<char>.PrintColleciton(aListOfChars);


