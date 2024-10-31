Console.WriteLine("Enter a string:");
string str = Console.ReadLine();

Console.WriteLine("Enter a number:");
int n = Convert.ToInt32(Console.ReadLine());


StringGroups(str, n);


static void StringGroups(string str, int n)
{
    string result = "";

    for (int i = 0; i < str.Length - 1; i += n)
    {

        string block = str.Substring(i, Math.Min(n, str.Length - i));
        if (block.Length == n)
        {
            result += block + " , ";
        }


    }

    int remaining = str.Length % n;

    for (int i = str.Length - remaining; i < str.Length; i++)
    {
        result += str[i] + " , ";
    }
    Console.WriteLine("result is: " + result);
}
