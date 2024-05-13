// See https://aka.ms/new-console-template for more information
string hexValue = "12FA3";
Console.WriteLine("Hexadecimal number: " + hexValue);
int decValue = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
Console.WriteLine("Decimal number: " + decValue);
