using System;
					
public class Program
{
	public static void Main()
	{
		var data = "abc573";
		Console.WriteLine(RemoveNonNumeric(data));
	}
	public static string RemoveNonNumeric(string StrData)
{
    var result = string.Empty;
    foreach (char c in StrData)
    {
         if (c >= '0' && c <= '9')
            result += c;
    }
    return result;
}
}